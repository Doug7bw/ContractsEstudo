using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Ex35.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Contract> Contracts { get; private set; } = new List<Contract>();

        public Employee() { }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(Contract contract)
        {
            if(contract != null)
            {
                AddContrract(contract);
            }
        }

        public void AddContrract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContrract(Contract contract)
        {
            Contracts.Remove(contract);
        }

        public double AverageWage()
        {
            double x = 0;

            foreach (Contract contract in Contracts)
            {
                x += contract.Salary;
            }

            return x;
        }

        public double HighestSalary()
        {
            double highestSalary = 0.0;

            foreach (Contract contract in Contracts)
            {
                if (contract.Salary > highestSalary)
                {
                    highestSalary = contract.Salary;
                }
            }

            return highestSalary;
        }

        public Contract GetContract()
        {
            Contract contract = null;
            foreach (Contract obj in this.Contracts)
            {
                if (obj.Employee == this)
                {
                    contract = obj;
                    return contract;
                }
            }
            return contract;
        }

        public override string ToString()
        {
            Contract contract = this.GetContract();
            return $"Employee ID: {Id}\n" +
                $"Employee name: {Name}\n" +
                $"Contract ID: {contract.Id}\n" +
                $"Contract Salary: $ {contract.Salary}";
        }
    }
}
