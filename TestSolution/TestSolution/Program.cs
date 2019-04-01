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
        static void Main(string[] args)
        {
           
            //Ascending order of age
            var orderByResult = from c in Customer
                                orderby c.CustomerAge
                                select c;

            //var customerInAscOrder = Customer.OrderBy(c => c.customerAge);

           // customer.ToList().ForEach(c => Console.WriteLine(c.Name));

            //customer below 25
            foreach (var c in Customer.customers)
            {
                if(Age < 25)
                {
                    customer.ShowData();
                }


                //Console.WriteLine($"id={item.Id}, name={item.Name}");
                //Console.ReadKey();



            }

            //orders which are placed before 2019
            foreach (var order in Orders)
            {
                if(Order.Id==id)
                {

                }

            }

            //product manufacture in 2018
            foreach ( var product in Products)
            {

            }
            //product details having third largest cost price



            Console.ReadLine();
        }








    }
}


   































        
    




        
    

