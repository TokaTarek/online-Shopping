using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Employee : IPerson 
    {
        public static List<Employee> _table = new List<Employee>();
        static bool Check;
        public Employee()
        {
            if(_table.Count <= 0 && !Check)
            {
                AddEmployees();
            }
        }
        
        public int Id { get ; set; }
        public string Name { get ; set ; }
        public IPerson.PersonType Type { get; set; }

        void AddEmployees()
        {
            Check = true;
            var emp = new Employee()
            {
                Id = 1,
                Name = "Khaled Mohamed",
                Type = IPerson.PersonType.Manager
            };
            var emp2 = new Employee()
            {
                Id = 2,
                Name = "Ahmed Elsakaa",
                Type = IPerson.PersonType.Cashier
            };
            var emp3 = new Employee()
            {
                Id = 3,
                Name = "Diaa Ali",
                Type = IPerson.PersonType.Manager
            };
            _table.Add(emp);
            _table.Add(emp2);
            _table.Add(emp3);
        }

    }
}
