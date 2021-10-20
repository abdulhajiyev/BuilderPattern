using System;

namespace PrototypePattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new()
            {
                Name = "Tom",
                Age = 20,
                EmploymentType = "Permanent"
            };

            Employee copyEmployee = employee.Clone() as Employee;

            employee.Name = "Deep Copy";

            Console.WriteLine(employee.Name);
            Console.WriteLine(copyEmployee.Name);
        }
    }

    // IPrototype interface
    public interface IEmployee
    {
        IEmployee Clone();
    }

    // ConcretePrototype1 class
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmploymentType { get; set; }

        public Employee() { }

        public Employee(Employee prototype)
        {
            Name = prototype.Name;
            Age = prototype.Age;
            EmploymentType = prototype.EmploymentType;
        }

        // Shallow Copy
        public IEmployee Clone() => new Employee(this);
    }
}
