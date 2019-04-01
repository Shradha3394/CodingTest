using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Properties
{
    class Customer
    {
        public int cId;
       public string Name;
       public int Age;
        public List<int> OrderIds { get; set; }

         IList<Customer> customers = new List<Customer>() {
            new Customer(01,"Riya",18,new List<int>() { 101,104 }),
            new Customer(02,"Raman",26,new List<int>() { 102 }),
             new Customer(03,"Rohit",26,new List<int>() { 103,105 }),
              new Customer(04,"Meera",26,new List<int>() { 107}),
               new Customer(05,"Siya",26,new List<int>() { 106,108 }),





         };



        public Customer(int cid,string name,int age, List<int> orderIds)
        {
            cId=cid;
            Name = name;
           Age = age;
            List<int> OrderIds = orderIds;




        }

        public void ShowData()
        {
            Console.WriteLine("Customers are: ");
            Console.WriteLine("customer id is:{0}",cId);
            Console.WriteLine("customer name is:{0}", Name);
            Console.WriteLine("list of customers in ascending order of age:");

            Console.ReadLine();





        }








    }
}
