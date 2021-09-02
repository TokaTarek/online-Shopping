using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IStock<T> where T : class
    {
         
        enum StockType
        {
            Store = 0,
            Category = 1,
            Product = 2
        }
        public int Id { get;  }
        public string Name { get; set; }
        public DateTime CreatedDate { get;  }
        public StockType Type { get;  }
        bool Add(T entity);
        bool Remove(int Id);
    }
}
