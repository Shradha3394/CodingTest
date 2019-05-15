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
        public static double Total = 0;

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
                //else
                //{
                //    Console.WriteLine("no record found");
                //}


            }

        }
        public static void GetCustomerByAuthor(int authorid)
        {
            foreach (var customer in CustomerList)
            {
                if (customer.Id == authorid)
                {

                    Console.WriteLine("female author is:{0}", customer.Name);
                }
                //else
                //{
                //    Console.WriteLine("no record found");
                //}
            }

        }



        public void ShowData()
        {
            Console.WriteLine("name of customer:{0}", Name);
            Console.WriteLine("age of customer:{0}", Age);
            Console.WriteLine("no.of book purchased:{0}", Book.BookList.Count);
         //   Console.WriteLine("name of book:{0}",Book.BookList.BName);
            foreach (int bi in BookIds)
            {
               // Console.WriteLine("book id is:{0}", bi);
                Book.GetBookById(bi);
            }

            var Total = 0.0;

            foreach (int id in BookIds)
            {
                var bookids = Customer.CustomerList.Find(x => x.Id.Equals(id));
                foreach (var bi in Book.BookList)
                {
                    var book = Book.BookList.Find(x => x.Id.Equals(bi));
                    Total += book.Price;
                }

            }
            Console.WriteLine("Total purchase: {0}", Total);
        }
    }
}



        
    

