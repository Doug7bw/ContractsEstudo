using System;

namespace Ex35.Entities
{
    internal class Contract
    {
        public int Id { get; set; }
        public double Salary { get; set; }
        public Employee Employee { get; set; }

        public Contract() { }

        public Contract(int id, double salary, Employee employee)
        {
            Id = id;
            Salary = salary;
            Employee = employee;
        }
    }
}
