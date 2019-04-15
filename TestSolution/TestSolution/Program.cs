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
            // 4 : given orderid
            Customer.GetCustomerById(2);
            //End
            

            DateTime dt = new DateTime();
            Console.WriteLine("Short date pattern (d): " + dt.ToString("d"));

            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
           

            // Console.WriteLine(dt.ToShortDateString());



            // 2 : orders which are placed before 2019
            foreach (var item in Order.Orders)
            {
               if(item.date <2019 && item.ProductId > 2 )
               {
                    
                    Console.WriteLine("order before 2019: ");
                    item.ShowData();
               }

               

            }

            //int Orderplaced = (from item in Order.Orders
            //                   orderby item.Orderdate < 2019
            //                   select item.Orderdate);

            //End

            // 6 : product manufacture in 2018

            foreach (var item in Product.Products)
            {
               
                if (item.Id > 3 )
                {
                    Console.WriteLine("product manufacture in 2018:");

                    item.ShowData();
                    

                }

            }

            // 5 : product details having third largest cost price
            foreach (var item in Product.Products)
            {
                if (item.Cost > 100)
                {
                    Console.WriteLine("largest cost price:");

                    item.ShowData();

                }
            }
            // var thirdMax =Product.Products.OrderByDescending(r => r).Take(2).LastOrDefault();

            double thirdHighest = (from item in Product.Products
                                   orderby item.Cost descending
                                   select item.Cost).Skip(1).First();

            //var Largest = Product.Products.Max();
            //Console.WriteLine("largest cost is:{0}",Largest);



            Console.ReadLine();
       }








    }
}


   































        
    




        
    

