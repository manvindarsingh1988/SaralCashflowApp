import { NavLink } from "react-router-dom";
import Logo from "../imgs/icon_64.png";

function NavBar() {
  return (
    <nav className="navbar navbar-expand-lg bg-success">
      <div className="container-fluid">
        <a className="navbar-brand text-light" href="#">
          <img
            alt="logo"
            className="me-2"
            src={Logo}
            style={{ height: "32px" }}
          />
          Saral Cash Flow
        </a>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNavAltMarkup"
          aria-controls="navbarNavAltMarkup"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
          <div className="navbar-nav me-auto mb-2 mb-lg-0">
            <NavLink
              to="/"
              className="nav-link text-light"
              activeclassname="active"
            >
              Home
            </NavLink>
            <NavLink
              to="/Master"
              className="nav-link text-light"
              activeclassname="active"
            >
              Master
            </NavLink>
          </div>
          <div className="d-flex flex-row-reverse">
            <button className="btn btn-success fw-bold" type="submit">
              Logout
            </button>
          </div>
        </div>
      </div>
    </nav>
  );
}

export default NavBar;
