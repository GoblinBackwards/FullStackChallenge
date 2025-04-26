import { useEffect, useState } from 'react'
import './App.css'
import { Employee, EmployeeTable } from './components/EmployeeTable'

function App() {
  const [employees, setEmployees] = useState<Employee[]>([]);
  useEffect(() => {
    fetch('https://localhost:7025/')
    .then(res => res.json())
    .then(data => {
      setEmployees(data as Employee[]);
      console.log(data);
    });
  }, []);

  return (
    <EmployeeTable employees={employees} />
  )
}

export default App
