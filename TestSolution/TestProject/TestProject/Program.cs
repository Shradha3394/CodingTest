using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1(a):given customerid
            Console.Write("ENTER THE CUSTOMER ID : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Customer.GetCustomerById(value);
            //End

            Book.GetBookById(102);

            // 3:print name of author
            Console.WriteLine("author name is:");
            foreach(var item in Book.BookList)
            {
                if(item.Name=="Kindle"&& item.Name=="PaperBack")
                {
                    Console.WriteLine("author name is:{0}",item.Name);
                }

            }
            //End













            //5:given id print book that are published before 2018
            Console.Write("ENTER THE Author ID : ");
            int result = Convert.ToInt32(Console.ReadLine());
            Author.GetAuthorById(result);





            Console.ReadLine();
        }
        
    }
}
