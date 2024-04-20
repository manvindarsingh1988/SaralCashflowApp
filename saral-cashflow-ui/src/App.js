import { BrowserRouter, Route, Routes, NavLink } from "react-router-dom";
import Home from "./components/Home";
import Master from "./components/Master";
import "./App.css";

function App() {
  return (
    <BrowserRouter>
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
              <NavLink
                to="/Master"
                className="nav-link"
                activeclassname="active"
              >
                Master
              </NavLink>
            </div>
          </div>
        </div>
      </nav>
      <Routes>
        <Route exact path="/" element={<Home />}></Route>
        <Route exact path="/Master" element={<Master />}></Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
