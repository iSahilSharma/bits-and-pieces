namespace CodeSnippets
{
    /// <summary>
    /// Object Reusability - This class demonstrates the use of objects throughout the project.
    /// Key objectives are - Object cloning, Shallow Copy, Deep Copy
    /// </summary>
    public static class ObjectReusabilityAmongOthers
    {
        public static void CloneObjects()
        {
            var employee = new Employee();

            var employeeCopy = employee;
            employeeCopy.Name = "Amyra Sharma";

            Console.WriteLine($"Employee Name is {employee.Name}");
            Console.WriteLine($"Employee Name is {employeeCopy.Name}");
        }

    }

    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = "Sahil Sharma";

        public decimal Salary { get; set; } = 0.0m;
    }
}