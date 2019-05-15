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
        public static void GetAuthorById(int AuthorId)
        {
            foreach (var author in AuthorList)
            {
                if (author.Id == AuthorId)
                {
                  
                    author.ShowData();
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







    


