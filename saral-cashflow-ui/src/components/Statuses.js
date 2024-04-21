import { useContext, useEffect, useState } from "react";
import axios, { HttpStatusCode } from "axios";
import { ALERTS, STATUSES_API } from "../constants/constants";
import AppContext from "./contexts/AppContext";

function Statuses() {
  const [statuses, setStatuses] = useState([]);
  const { showFadingAlert } = useContext(AppContext);

  useEffect(() => {
    get();
  }, []);

  function get() {
    axios
      .get(STATUSES_API)
      .then((result) => setStatuses(result?.data || []))
      .catch((err) => {
        console.error(err);
        showFadingAlert("Oops! something went wrong.", ALERTS.warning);
      });
  }

  function add() {
    const newStatusInput = document.getElementById("input-add-status");
    const newStatus = newStatusInput.value;
    if (newStatus) {
      axios
        .post(STATUSES_API, {
          statusType: newStatus,
        })
        .then(function (response) {
          if (response.status === HttpStatusCode.Ok) {
            newStatusInput.value = "";
            get();
            showFadingAlert("status added successfully.", ALERTS.success);
          }
        })
        .catch(function (error) {
          showFadingAlert("Oops! something went wrong.", ALERTS.warning);
        });
    }
  }

  function remove(id) {
    axios
      .delete(`${STATUSES_API}/${id}`)
      .then(function (response) {
        if (response.status === HttpStatusCode.NoContent) {
          get();
          showFadingAlert("Status deleted successfully.", ALERTS.success);
        }
      })
      .catch(function (error) {
        console.error(error);
        showFadingAlert("Oops! something went wrong.", ALERTS.warning);
      });
  }

  return (
    <div className="container border border-1 border-top-0">
      <div className="pt-3 input-group pb-3">
        <input
          id="input-add-status"
          type="text"
          className="form-control"
          placeholder="Add New Status"
          aria-label="Add New Status"
          aria-describedby="button-addon2"
        />
        <button
          className="btn btn-primary"
          type="button"
          id="button-addon2"
          onClick={add}
        >
          Add
        </button>
      </div>
      <table className="table table-striped table-hover">
        <thead>
          <tr>
            <th scope="col">Id</th>
            <th scope="col">Status</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {statuses.map((d) => (
            <tr key={d.id}>
              <td>{d.id}</td>
              <td>{d.name}</td>
              <td>
                <button
                  type="button"
                  className="btn btn-danger"
                  onClick={() => remove(d.id)}
                >
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Statuses;
