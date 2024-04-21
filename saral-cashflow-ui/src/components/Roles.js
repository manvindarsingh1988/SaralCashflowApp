import { useEffect, useState } from "react";
import axios, { HttpStatusCode } from "axios";
import { BASE_URL } from "../constants/constants";

const ROLES_API = `${BASE_URL}/roles`;

function Roles() {
  const [roles, setRoles] = useState([]);

  useEffect(() => {
    get();
  }, []);

  function get() {
    axios
      .get(ROLES_API)
      .then((result) => setRoles(result?.data || []))
      .catch((err) => console.error(err));
  }

  function add() {
    const newRoleInput = document.getElementById("input-add-role");
    const newRole = newRoleInput.value;

    if (newRole) {
      axios
        .post(ROLES_API, {
          role: newRole,
        })
        .then(function (response) {
          if (response.status === HttpStatusCode.Ok) {
            newRoleInput.value = "";
            get();
          }
        })
        .catch(function (error) {
          console.error(error);
        });
    }
  }

  function remove(id) {
    axios
      .delete(`${ROLES_API}/${id}`)
      .then(function (response) {
        if (response.status === HttpStatusCode.NoContent) {
          get();
        }
      })
      .catch(function (error) {
        console.error(error);
      });
  }

  return (
    <div className="container border border-1 ">
      <div className="mt-3 input-group mb-3">
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
      <table className="mt-3 table table-striped table-hover">
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
                <div className="row">
                  <div className="col">
                    <button
                      type="button"
                      className="btn btn-danger"
                      onClick={() => remove(d.id)}
                    >
                      Delete
                    </button>
                  </div>
                </div>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Roles;
