using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1:Customer below 25
            foreach(var c in Customer.Customers)
            {
                if(c.Age<25)
                {
                    Console.WriteLine("CUSTOMER BELOW 25:");
                    c.ShowData();
                }
            }
            //End

            // 2 : Order before 2019
            foreach (var item in Order.Orders)
            {
                if (item.OrderDate.Year < 2019 && item.ProductIds.Count > 2)
                {
                    Console.WriteLine("ORDER BEFORE 2019:");
                    item.ShowData();
                }
            }
            //End

            // 3 : Ascending order of Age
            var orderByResult = from c in Customer.Customers
                                orderby c.Age
                                select c;
            foreach(var agegroup in orderByResult)
            {
                Console.WriteLine("customer detail in ascending order of age:");
                agegroup.ShowData();
            }
            //End

           // 4 : Given orderid
            Console.Write("ENTER THE COURSE ID : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Customer.GetCustomerById(value);
           
            //End
          
            // 5 : Third Largest cost 
            var Result = Product.Products.OrderByDescending(p => p.Cost)
                 .Take(3)
                 .Skip(2)
                 .ToList();

            foreach (var result in Result)
            {
                Console.WriteLine("THE THIRD LARGEST COST IS:");
                result.ShowData();
            }

            //End

           // 6 : Product manufacture in 2018

            foreach (var item in Product.Products)
            {
                if(item.MFG.Year == 2018)
                {
                    Console.WriteLine("PRODUCT MANUFACTURE IN 2018:");
                    item.ShowData();
                }
            }

            //End
            Console.ReadLine();
        }
     
    }
}


   































        
    




        
    

