import { useEffect, useState } from 'react'
import './App.css'
import { Employee, EmployeeTable } from './components/EmployeeTable'

function App() {
  const [employees, setEmployees] = useState<Employee[] | null>([]);
  const [loading, setLoading] = useState<boolean>(true);
  useEffect(() => {
    setLoading(true);
    fetch('https://localhost:7025/')
    .then(res => res.json())
    .then(data => {
      setLoading(false);
      setEmployees(data as Employee[]);
      console.log(data);
    })
    .catch(() => {
      setLoading(false);
      setEmployees(null);
    });
  }, []);

  if (loading) {
    return <h3>Loading...</h3>
  } else if (employees == null) {
    return <h2>Failed to connect to the API.</h2>
  } else {
    return <EmployeeTable employees={employees} />
  }
}

export default App
