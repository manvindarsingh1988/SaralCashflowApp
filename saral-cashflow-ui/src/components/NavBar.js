import { NavLink } from "react-router-dom";

function NavBar() {
  return (
    <nav className="navbar navbar-expand-lg bg-dark-subtle">
      <div className="container-fluid">
        <a className="navbar-brand" href="#">
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
          <div className="navbar-nav">
            <NavLink to="/" className="nav-link" activeclassname="active">
              Home
            </NavLink>
            <NavLink to="/Master" className="nav-link" activeclassname="active">
              Master
            </NavLink>
          </div>
        </div>
      </div>
    </nav>
  );
}

export default NavBar;
