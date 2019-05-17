using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Author
    {
        public int Id;
        public string Name;
        public int Age;
        public string Gender;

        public static List<Author> AuthorList = new List<Author>() {
            new Author(01,"Riya",18,"Female"),
             new Author(02,"Raman",26,"Male"),
              new Author(03,"Rohit",21,"Male"),
               new Author(04,"Meera",24,"Female"),
                new Author(05,"Siya",28,"Female"),

        };
        public Author(int id, string name, int age, string gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
        }
        public static void GetAuthorById(int Id)
        {
            foreach (var item in Author.AuthorList)
            {
                foreach (var book in Book.BookList)
                {
                    if(book.PublishedDate.Year<2018)                                                 // && book.PublishedDate.Year < 2018)
                    {
                    if (item.Id == book.AuthorId)
                    {
                            if (book.AuthorId == Id)
                            {


                                // item.ShowData();
                                Console.WriteLine("book name is:{0}", book.Name);
                            }
                    }

                    }


                }


            }    
            


        }





        public void ShowData()
        {
            Console.WriteLine("name of author:{0}",Name);
          
            //Console.WriteLine("gender is:{0}", Gender);
           
        }
    }
}







    


