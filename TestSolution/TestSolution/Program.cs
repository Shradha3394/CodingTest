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
            // 4: given orderid
            Customer.GetCustomerById(3);
            //End


            // 3 : Ascending order of age
            var orderByResult = from c in Customer.customers
                                orderby c.Age
                                select c;
            foreach (var agegroup in orderByResult)
            {
                Console.WriteLine("customer detail in ascending order of Age:");
                agegroup.ShowData();

            }
            // End Ascending order of age


            // 1 : customer below 25
            foreach (var c in Customer.customers)
            {
                if (c.Age < 25)
                {
                    Console.WriteLine("Customer Below 25:");
                    c.ShowData();

                }
            }
            //End customer below 25




            // 2 : orders which are placed before 2019
            foreach (var item in Order.Orders)
            {
               if(item.year<2019)

                item.ShowData();

            }
            //End



            // 5 : largest cost price

            foreach (var item in Product.Products)

            {
               
                if (item.Cost>100)
                {


                    Console.WriteLine($" name={item.Name},cost={item.Cost}");
                    Console.ReadKey();
                }
               
            }
            //End



            Console.ReadLine();
       }








    }
}


   































        
    




        
    

