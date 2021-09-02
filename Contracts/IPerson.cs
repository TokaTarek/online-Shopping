using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPerson
    {
        enum PersonType
        {
            Customer = 0,
            Cashier = 1,
            Manager = 2
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
    }
}
