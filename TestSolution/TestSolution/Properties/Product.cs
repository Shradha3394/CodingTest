using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Product
    {
          int pId;
         public string Name;
       public  double Cost;
       public  static List< int> MFG;

        public static List<Product> Products = new List<Product>() {
            new Product(1,"Soap",25,new List<int>(){2017, 12, 25 }),
            new Product(2,"Biscuit",30,new List<int>(){2018, 1, 1 }),
            new Product(3,"Cream",100,new List<int>(){2017, 2, 3 }),
            new Product(4,"Chocolate",30,new List<int>(){2018, 7, 8 }),
            new Product(5,"Powder",105,new List<int>(){2018, 8, 9 }),






        };
        





        public Product(int pid,string name,double cost, List<int> MFG)
        {
            pId = pid;
            Name = name;
            Cost = cost;
            List<int> Datetime = MFG; 
           

        }

        public void ShowData()
        {
            Console.WriteLine("product details having third largest cost price: ");
           // Console.WriteLine("product manufactured in the year 2018: ");
            Console.ReadLine();
        }











    }
}
