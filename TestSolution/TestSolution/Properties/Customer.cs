using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Customer
    {
        public int cId;
       public string Name;
       public int Age;
        public  static List<int> OrderIds { get; set; }

        public static List<Customer> customers = new List<Customer>() {
            new Customer(01,"Riya",18,new List<int>() { 101,104 }),
            new Customer(02,"Raman",26,new List<int>() { 102 }),
             new Customer(03,"Rohit",21,new List<int>() { 103,105 }),
              new Customer(04,"Meera",24,new List<int>() { 107}),
               new Customer(05,"Siya",28,new List<int>() { 106,108 }),





         };

       


        public Customer(int cid,string name,int age, List<int> orderIds)
        {
            cId=cid;
            Name = name;
           Age = age;
           List<int> OrderIds = orderIds;




        }
        public static void GetCustomerById(int id)
        {
            foreach (var c in Customer.customers)
            {
                if (c.cId == id)
                {

                    Console.WriteLine("name of customer:{0}", c.Name);
                    Console.WriteLine("id of customer:{0}", c.cId);


                }    

                







            }
           
        }

        public void ShowData()
        {
            
             Console.WriteLine("customer id is:{0}",cId);
            Console.WriteLine("customer name is:{0}", Name);
            Console.WriteLine("customer age is:{0}", Age);
            


            Console.ReadLine();
           






        }








    }
}
