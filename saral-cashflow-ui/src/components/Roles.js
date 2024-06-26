import { useContext, useEffect, useState } from "react";
import axios, { HttpStatusCode } from "axios";
import { ALERTS, ROLES_API } from "../constants/constants";
import AppContext from "./contexts/AppContext";

function Roles() {
  const [roles, setRoles] = useState([]);
  const { showFadingAlert } = useContext(AppContext);

  useEffect(() => {
    get();
  }, []);

  function get() {
    axios
      .get(ROLES_API)
      .then((result) => setRoles(result?.data || []))
      .catch((err) => {
        console.error(err);
        showFadingAlert("Oops! something went wrong.", ALERTS.warning);
      });
  }

  function add() {
    const newRoleInput = document.getElementById("input-add-role");
    const newRole = newRoleInput.value;
    if (newRole) {
      axios
        .post(ROLES_API, {
          name: newRole,
        })
        .then(function (response) {
          if (response.status === HttpStatusCode.Ok) {
            newRoleInput.value = "";
            get();
            showFadingAlert("Role added successfully.", ALERTS.success);
          }
        })
        .catch(function (error) {
          showFadingAlert("Oops! something went wrong.", ALERTS.warning);
        });
    }
  }

  function remove(id) {
    axios
      .delete(`${ROLES_API}/${id}`)
      .then(function (response) {
        if (response.status === HttpStatusCode.NoContent) {
          get();
          showFadingAlert("Role deleted successfully.", ALERTS.success);
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
          id="input-add-role"
          type="text"
          className="form-control"
          placeholder="Add New Role"
          aria-label="Add New Role"
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
            <th scope="col">Role</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {roles.map((d) => (
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

export default Roles;
