using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Order
    {
        public int OrderId;
        public DateTime OrderDate;
        public List<int> ProductIds;

        public static List<Order> Orders = new List<Order>() {
            new Order(101,new DateTime(2017,12,25 ),new List<int>() { 1,2,4 }),
            new Order(102, new DateTime(2016,1,1),new List<int>() { 2,4 }),
            new Order(103, new DateTime(2017,2, 3 ),new List<int>() { 1,3}),
             new Order(104, new DateTime(2017,7, 8 ),new List<int>() { 2,5 }),
              new Order(105,new DateTime( 2018, 8, 9 ),new List<int>() { 1,4 }),
               new Order(106,new DateTime(2018, 10, 15),new List<int>() { 2,3,5 }),
                new Order(107,new DateTime(2019, 1, 19 ),new List<int>() { 3,5 }),
                 new Order(108,new DateTime(2019, 2, 21),new List<int>() { 4 }),

        };
        public static void GetOrderById(int OrderId)
        {
            foreach (var order in Orders)
            {
                if (order.OrderId == OrderId)
                {
                    order.ShowData();
                }
            }
        }

        public Order(int orderid, DateTime orderdate, List<int> productids)
        {
                 OrderId = orderid;
                 OrderDate = orderdate;
                 ProductIds = productids;
        }


        public void ShowData()
        {
         //   Console.WriteLine("order id is:{0}", OrderId);
            Console.WriteLine("order date is:{0}", OrderDate);
            foreach (int pi in ProductIds)
            {
             // Console.WriteLine("product id is:{0}", pi);
                Product.GetProductById(pi);
                Console.ReadLine();
            }

        }
    }
}




    













    

