namespace EmployeeLibrary
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, string title)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Title})";
        }
    }
}
