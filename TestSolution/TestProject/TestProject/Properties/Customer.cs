using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Customer
    {
        public int Id;
        public string Name;
        public int Age;
        public List<int> BookIds { get; set; }

        public static List<Customer> CustomerList = new List<Customer> {
         new Customer(1,"Sumit",25,new List<int> { 101,105,104 }),
         new Customer(2,"Manav",15,new List<int> {103,102 }),
          new Customer(3,"Richa",30,new List<int> {104,105,107 }),
           new Customer(4,"Disha",39,new List<int> {106,101,108 }),
            new Customer(5,"Naman",33,new List<int> {105,103,102 }),



        };

        public Customer(int id, string name, int age, List<int> bookids)
        {
            Id = id;
            Name = name;
            Age = age;
            BookIds = bookids;

        }

        public static void GetCustomerById(int id)
        {
            foreach (var customer in CustomerList)
            {
                if (customer.Id == id)
                {
                    customer.ShowData();
                    
                }
              
            }
        }



        public void ShowData()
        {
            Console.WriteLine("name of customer:{0}", Name);
            Console.WriteLine("age of customer:{0}", Age);
            //foreach (int pi in ProductIds)
            //{
            //    // Console.WriteLine("product id is:{0}", pi);
            //    Product.GetProductById(pi);
            //}

            var totalCost = 0.0;

            //foreach (int bi in BookIds)
            //{
            //    var bookids = Book.BookList.Find(x => x.BookIds.Equals(bi));
            //    foreach (var Id in BookList)
            //    {
            //        var product = Product.Products.Find(x => x.ProductId.Equals(productId));
            //        totalCost += product.Cost;
            //    }

        }
            //Console.WriteLine("Total Cost {0}", totalCost);
    }
}



        
    

