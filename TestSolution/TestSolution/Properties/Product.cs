using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Product
    {
         public int Id;
         public string Name;
         public double Cost;
         public DateTime MFG;

        public static List<Product> Products = new List<Product>() {
            new Product(1,"Soap",25,new DateTime(2017/ 12/ 25) ),
            new Product(2,"Biscuit",30,new DateTime(2018/ 1/ 1) ),
            new Product(3,"Cream",100,new DateTime(2017/ 2/ 3 )),
            new Product(4,"Chocolate",30,new DateTime(2018/ 7/ 8) ),
            new Product(5,"Powder",105,new DateTime(2018, 8, 9) ),






        };
       

       





        public Product(int id,string name,double cost, DateTime MFG)
        {
            Id = id;
            Name = name;
            Cost = cost;
            MFG =MFG; 
           

        }

        public void ShowData()
        {
            Console.WriteLine("product id is:{0}",Id);
            //Console.WriteLine("product details having third largest cost price: ");
          //  Console.WriteLine("product manufactured in the year 2018: ");
            Console.WriteLine("name of product:{0}", Name);
            Console.WriteLine("cost of product:{0}", Cost);
            Console.WriteLine("manufacturing date:{0}", MFG);
            Console.ReadLine();
        }











    }
}
