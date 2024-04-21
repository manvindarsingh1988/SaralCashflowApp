import { useEffect, useState } from "react";
import axios from "axios";
import { BASE_URL } from "../constants/constants";

function Roles() {
    const [roles, setRoles] = useState([]);

    useEffect(() => {
      axios
        .get(`${BASE_URL}/roles`)
        .then((result) => setRoles(result?.data || []))
        .catch((err) => console.error(err));
    }, []);

  function addRole() {
    const newRole = document.getElementById("input-add-role");

    if (newRole) {
        
    }
  }

  return (
    <div className="container border border-1 ">
      <div class="mt-3 input-group mb-3">
        <input
          id="input-add-role"
          type="text"
          class="form-control"
          placeholder="Add New Role"
          aria-label="Add New Role"
          aria-describedby="button-addon2"
        />
        <button
          class="btn btn-outline-secondary"
          type="button"
          id="button-addon2"
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
            <tr>
              <td>{d.id}</td>
              <td>{d.name}</td>
              <td>
                <div className="row">
                  <div className="col">
                    <button type="button" className="btn btn-danger">
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
