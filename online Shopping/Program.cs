using Entities;
using System;

namespace ShoppingOnlineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Employee employee = new Employee();
            User user = new User();
            //foreach (var item in Customer._table)
            //{
            //    Console.WriteLine(string.Format("Id = {0} \nName = {1}\nType = {2} " , item.Id , item.Name , item.Type));
            //}
            //foreach (var item in Employee._table)
            //{
            //    Console.WriteLine(string.Format("Id = {0} \nName = {1}\nType = {2} ", item.Id, item.Name, item.Type));
            //}
            foreach (var item in User._table)
            {
                Console.WriteLine(string.Format("Id = {0} \nUsername = {1}\nPassword = {2}\nname = {3}\nType = {4} ", item.Id, item.Username, item.Password, item.Person.Name, item.Person.Type));
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
        }
    }
    
}
