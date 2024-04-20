import { useEffect, useState } from "react";
import axios from "axios";
import Roles from "./Roles";

function Master() {
  const [activeLink, setActiveLink] = useState("Roles");
  const [roles, setRoles] = useState([]);

  useEffect(() => {
    axios
      .get("https://manvindarsingh.bsite.net/api/roles")
      .then((result) => setRoles(result))
      .catch((err) => console.error(err));
  }, []);

  return (
    <div className="container mt-2">
      <ul className="nav nav-tabs">
        <li className="nav-item">
          <button
            className={activeLink === "Roles" ? "nav-link active" : "nav-link"}
            aria-current={activeLink === "Roles" ? "page" : ""}
            onClick={() => setActiveLink("Roles")}
          >
            Roles
          </button>
          <Roles data={roles} />
        </li>
        <li className="nav-item">
          <button
            className={
              activeLink === "Statuses" ? "nav-link active" : "nav-link"
            }
            aria-current={activeLink === "Statuses" ? "page" : ""}
            onClick={() => setActiveLink("Statuses")}
          >
            Statuses
          </button>
        </li>
        <li className="nav-item">
          <button
            className={activeLink === "Misc" ? "nav-link active" : "nav-link"}
            aria-current={activeLink === "Misc" ? "page" : ""}
            onClick={() => setActiveLink("Misc")}
          >
            Misc
          </button>
        </li>
      </ul>
    </div>
  );
}

export default Master;
