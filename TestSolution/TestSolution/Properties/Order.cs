using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Properties
{
    class Order
    {
        int oId;
        public List<int> Orderdate { get; set; }
        public List<int> ProductIds { get; set; }

        public static List<Order> Orders = new List<Order>() {
            new Order(101, new List<int>(){2017, 12, 25 } ,new List<int>() { 1,2,4 }),
             new Order(102, new List<int>(){2016, 1, 1 } ,new List<int>() { 2,4 }),
            new Order(103, new List<int>(){2017, 2, 3 } ,new List<int>() { 1,3}),
             new Order(104, new List<int>(){2017, 7, 8 } ,new List<int>() { 2,5 }),
              new Order(105, new List<int>(){2018, 8, 9 } ,new List<int>() { 1,4 }),
               new Order(106, new List<int>(){2018, 10, 15 } ,new List<int>() { 2,3,5 }),
                new Order(107, new List<int>(){2019, 1, 19 } ,new List<int>() { 3,5 }),
                 new Order(108, new List<int>(){2019, 2, 21 } ,new List<int>() { 4 }),





        };








        public Order(int oid,List<int> orderdate, List<int> productids)
        {
            oId = oid;
           List <int> Datetime = orderdate;
           List<int> ProductIds = productids;
        }


        public void ShowData()
        {
            Console.WriteLine("display orders: ");
            Console.ReadLine();

        }




    }
}












    

