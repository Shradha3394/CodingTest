using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Customer
    {
        public  int CustomerId;
        public  string Name;
        public int Age;
        public List<int> OrderIds;
        public static double TotalCost = 0;

        public static List<Customer> Customers = new List<Customer>() {
            new Customer(01,"Riya",18,new List<int> { 101,104 }),
            new Customer(02,"Raman",26,new List<int>() { 101, 102 }),
             new Customer(03,"Rohit",21,new List<int>() { 103,105}),
              new Customer(04,"Meera",24,new List<int>() { 107}),
               new Customer(05,"Siya",28,new List<int>() { 106,108 }),

        };
         
        public Customer(int customerid, string name, int age, List<int> orderIds)
        {
            CustomerId = customerid;
            Name = name;
            Age = age;
            OrderIds = orderIds;
        }

        public static void GetCustomerById(int id)
        {
            foreach (var customer in Customers)
            {
                if (customer.CustomerId == id)
                {
                    customer.ShowData();


                }
            }
        }

        public void ShowData()
        {
            Console.WriteLine("customer id is:{0}", CustomerId);
            Console.WriteLine("customer name is:{0}", Name);
            Console.WriteLine("customer age is:{0}",Age);
            var totalCost = 0.0;

            foreach (int oi in OrderIds)
            {
                var order = Order.Orders.Find(x => x.OrderId.Equals(oi));
                foreach (var productId in order.ProductIds)
                {
                    var product = Product.Products.Find(x => x.ProductId.Equals(productId));
                    totalCost += product.Cost;
                }
            }
            Console.WriteLine("Total Cost {0}", totalCost);
        }
           






        








    }
}
