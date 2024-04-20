function Roles({ data }) {
  if (data?.length === 0) {
    return "- No Data available -";
  }

  return (
    <table class="table">
      <thead>
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Role</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        {data.map((d) => (
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
  );
}

export default Roles;
