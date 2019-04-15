using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Order
    {
        public int oId;
        public int ProductId;
        public int date;
        public DateTime Orderdate;
        public static List<int> ProductIds { get; set; }

        public static List<Order> Orders = new List<Order>() {
            new Order(101,new DateTime(25/12/2017),new List<int>() { 1,2,4 }),
            new Order(102, new DateTime(1/ 1/ 2016),new List<int>() { 2,4 }),
            new Order(103, new DateTime(3/ 2/ 2017),new List<int>() { 1,3}),
             new Order(104, new DateTime(8/ 7/ 2017),new List<int>() { 2,5 }),
              new Order(105,new DateTime( 9/ 8/ 2018),new List<int>() { 1,4 }),
               new Order(106,new DateTime(15/ 10/ 2018),new List<int>() { 2,3,5 }),
                new Order(107,new DateTime(19/ 1/ 2019),new List<int>() { 3,5 }),
                 new Order(108,new DateTime(21/ 2/ 2019),new List<int>() { 4 }),





        };
        
     







        public Order(int oid,DateTime orderdate, List<int> productids)
        {
            oId = oid;
            Orderdate = orderdate;
          List<int> ProductIds = productids;
        }


        public void ShowData()
        {
            Console.WriteLine("order id is:{0}", oId);
            Console.WriteLine("product id is:{0}",ProductIds);
            Console.WriteLine("order date is:{0}",Orderdate);
            Console.ReadLine();

        }




    }
}












    

