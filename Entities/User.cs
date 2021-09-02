using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class User
    {
        public User()
        {
            if (_table.Count <= 0 && !Check)
            {
                AddUsers();
            }
        }
        public static List<User> _table = new List<User>();
        static bool Check;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IPerson Person  {get ;set ; }
        void AddUsers()
        {
            Check = true;
            // add Customers
            var user1 = new User()
            {
                Id = 1,
                Username = "Customer1",
                Password = "123",
                Person = Customer._table.Where(x =>x.Id == 1).FirstOrDefault()
            };
            var user2 = new User()
            {
                Id = 2,
                Username = "Customer2",
                Password = "123",
                Person = Customer._table.Where(x => x.Id == 2).FirstOrDefault()
            };
            var user3 = new User()
            {
                Id = 3,
                Username = "Customer3",
                Password = "123",
                Person = Customer._table.Where(x => x.Id == 3).FirstOrDefault()
            };
            _table.Add(user1);
            _table.Add(user2);
            _table.Add(user3);

            // add Employee
            var user4 = new User()
            {
                Id = 4,
                Username = "emp1",
                Password = "123",
                Person = Employee._table.Where(x => x.Id == 1).FirstOrDefault()
            };
            var user5 = new User()
            {
                Id = 5,
                Username = "emp2",
                Password = "123",
                Person = Employee._table.Where(x => x.Id == 2).FirstOrDefault()
            };
            var user6 = new User()
            {
                Id = 6,
                Username = "emp3",
                Password = "123",
                Person = Employee._table.Where((x) => x.Id == 3).FirstOrDefault()
            };
            _table.Add(user4);
            _table.Add(user5);
            _table.Add(user6);
        }
    }
}
