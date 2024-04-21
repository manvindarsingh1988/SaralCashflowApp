import LoginIcon from "../imgs/permission.png";

function Login() {
  return (
    <div className="container mt-2">
      <div className="row justify-content-center mt-2">
        <div className="col-md-4">
          <div className="card shadow-lg">
            <div className="card-body">
              <img
                src={LoginIcon}
                className="img-fluid mx-auto d-block mb-4"
                alt="Login"
              />

              <h3 className="text-center mb-4">Login</h3>
              <form>
                <div className="mb-3">
                  <label htmlFor="email" className="form-label">
                    Email address
                  </label>
                  <input
                    type="email"
                    className="form-control"
                    id="email"
                    placeholder="Enter email"
                    required
                  />
                </div>
                <div className="mb-3">
                  <label htmlFor="password" className="form-label">
                    Password
                  </label>
                  <input
                    type="password"
                    className="form-control"
                    id="password"
                    placeholder="Password"
                    required
                  />
                </div>
                <div className="text-center">
                  <button type="submit" className="btn btn-primary btn-block">
                    Login
                  </button>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Login;
