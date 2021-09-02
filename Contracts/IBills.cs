using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IBills<T> where T:class
    {
        enum billType
        {
            Bill = 0,
            ReturnBill= 1,
            ReplaceBill=2
        }
         int Id { get;}
         IPerson Customer { get; set; }
         DateTime CreateDate { get; }
         billType BillType { get;  }
        bool Add(T entity);
        bool Remove(int Id);
    }
}
