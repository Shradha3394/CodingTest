using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Book
    {
        public int Id;
        public string BName;
        public double Price;
        public DateTime PublishedDate;
        public string Type;
        public int AuthorId;
       

        public static List<Book> BookList = new List<Book> {
         new Book(101,"Hamlet",200.50,new DateTime(2017,12,25),"PaperBack",01),
         new Book(102,"Ulysses",300,new DateTime(2016,1,1),"HardCover",03),
         new Book(103,"War and Peace",550,new DateTime(2017,2,3),"Kindle",02),
         new Book(104,"the lliad",280,new DateTime(2017,7,8),"CD",04),
         new Book(105,"Pride and Prejudice",300.90,new DateTime(2018,2,9),"HardCover",01),
         new Book(106,"To the Lighthouse",400,new DateTime(2018,10,15),"Kindle",02),
         new Book(107,"Nineteen Eighty Four",300,new DateTime(2019,1,19),"PaperBack",05),
         new Book(108,"The Trial",450,new DateTime(2019,2,21),"CD",04),

        };

        public Book(int id,string bname,double price,DateTime publisheddate,string type,int authorid)
        {
            Id = id;
            BName = bname;
            Price = price;
            PublishedDate = publisheddate;
            Type = type;
            AuthorId = authorid;
        }

        public static void GetBookById(int id)
        {
            foreach(var book in BookList)
            {
                if(book.Id==id)
                {
                    book.ShowData();
                    Customer.Total += book.Price;

                }
                
               
                


            }
        }

        public void ShowData()
        {
            Console.WriteLine("name of book:{0}", BName);
          //  Console.WriteLine("Author id is:{0}",AuthorId);
            
        }










    }
}
