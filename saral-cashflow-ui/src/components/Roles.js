function Roles({ data }) {
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
          </tr>
        ))}
      </tbody>
    </table>
  );
}

export default Roles;
