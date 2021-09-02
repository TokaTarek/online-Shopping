using System;
using System.Collections.Generic;
using System.Text;
using Contracts;

namespace Entities
{
    public class Customer : IPerson
    {
        public static List<Customer> _table = new List<Customer>();
        static bool Check;
        public Customer()
        {
            if (_table.Count <= 0 && Check == false)
            {
                AddCustomer();
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IPerson.PersonType Type { get; set; }
        void AddCustomer()
        {
            Check = true;
            var cust = new Customer() {
                Id = 1,
                Name = "Mohamed Ali",
                Type = IPerson.PersonType.Customer
            };
            var cust2 = new Customer()
            {
                Id = 2,
                Name = "Ahmed Ali",
                Type = IPerson.PersonType.Customer
            };
            var cust3 = new Customer()
            {
                Id = 3,
                Name = "Joe Ali",
                Type = IPerson.PersonType.Customer
            };
            _table.Add(cust);
            _table.Add(cust2);
            _table.Add(cust3);
        }
    }
}
