type Employee = {
  id: number,
  firstName: string,
  lastName: string,
  title: string
}

const EmployeeTable = ({employees}: {employees: Employee[]}) => (
    <table className="table table-striped">
        <thead className="fw-bold">
            <tr>
                <td>First Name</td>
                <td>Last Name</td>
                <td>Position</td>
            </tr>
        </thead>
        <tbody>
            {employees.map(e => (
                <tr key={e.id}>
                    <td>{e.firstName}</td>
                    <td>{e.lastName}</td>
                    <td>{e.title}</td>
                </tr>
            ))}
        </tbody>
    </table>
)

export {EmployeeTable}
export type {Employee}