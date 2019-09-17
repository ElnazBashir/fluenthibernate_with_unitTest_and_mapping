using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shakiba.Entities;

namespace shakiba
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    Store store = new Store
                    {
                        Name = "daryani",
                    };

                    Employee employee = new Employee
                    {
                        FirstName = "Allan",
                        LastName = "boomer"
                    };
                    
                    //var p1 = new Product
                    //{
                    //    Name = "bbb",
                    //    Price = 1000
                    //};

                    store.Employees.Add(employee);
                    //store.Products.Add(p1);
                    //p1.Stores.Add(store);


                    session.Save(store);
                    //session.Save(employee);
                    transaction.Commit();
                    //Console.WriteLine("Customer Created: " + customer.Name + "\t" +
                    //                  customer.Id);

                    Console.WriteLine("done");
                }

                Console.ReadKey();
            }
        }
    }
}