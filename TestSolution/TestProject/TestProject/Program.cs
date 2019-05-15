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

            //1:(e)
            foreach (var name in Author.AuthorList)
            {
                name.ShowData();
            }
            //End

            //2:given bookid
            Console.WriteLine("enter the book id:");
            int ans = Convert.ToInt32(Console.ReadLine());
            Book.GetBookById(ans);
            //End

            // 3:print name 
            //  Console.WriteLine("name is:");
            foreach (var item in Book.BookList)
            {
                if (item.Type == "Kindle"&& item.Type=="PaperBack")
                {
                    Console.WriteLine("name is:{0}", item.BName);
                }

            }

            //End

            //4:for a given id print name of female author
            Console.WriteLine("Customer id is:");
            int add = Convert.ToInt32(Console.ReadLine());
            Customer.GetCustomerByAuthor(add);
            //End


            //5:given id print book that are published before 2018
            Console.Write("ENTER THE Author ID : ");
            int result = Convert.ToInt32(Console.ReadLine());
            Author.GetAuthorById(result);
            foreach (var book in Book.BookList)
            {
                if (book.PublishedDate.Year < 2018)
                {
                    Console.WriteLine("book name is:{0}",book.BName);

                  

                }
            }





            Console.ReadLine();
        }
        
    }
}
