import { useState } from "react";
import Roles from "./Roles";
import Statuses from "./Statuses";

function Master() {
  const [activeLink, setActiveLink] = useState("Roles");

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
      {activeLink === "Roles" ? <Roles /> : <Statuses />}
    </div>
  );
}

export default Master;
