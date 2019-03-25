using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1:prime number

            int count = 0;
            int num = 1;
            Console.WriteLine("prime number 1 to 30:-");
            while (count != 15)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("prime number: " + num);
                    count++;
                }
                num++;
            }

            Console.ReadLine();

            // 2 : simple calculator

            int a, b;
          
            float result=0;
            Console.WriteLine("enter 1st number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number:");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("enter operator");
            string op = Console.ReadLine();
           
            switch(op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-" :
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            Console.WriteLine("result=" +result);
            Console.ReadLine();

            // 3 : sum of individual digit of given number

            int num1=0;
            int sum=0,t;
            Console.WriteLine("enter the sample input");
            num1=int.Parse(Console.ReadLine());
            while(num1!=0)
            {
                t = num1 % 10;
                num1 = num1 / 10;
                sum = sum + t;
            }
            Console.WriteLine("sum of digit of number=" +sum);
            Console.ReadLine();

           
            // 4 : lowercase character/uppercase

            string str;
           //String name = " ";
            Console.WriteLine("enter the string:");
            str = Console.ReadLine();
            string lowerstr = str.ToLower();
            Console.WriteLine(lowerstr);
            string upperstr = str.ToUpper();
            Console.WriteLine(upperstr);
            
            Console.ReadLine();

            // 5 : array occurence of given number

            int i=0;
            int count1=0;
            int item;
            int[] Arr1 = new int[6];
            Console.WriteLine("enter the numbers:");
            for (i = 0; i < 6; i++)
            {
                Console.Write("Element[" + (i + 1) + "]:");
                Arr1[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("enter element:");
            item = int.Parse(Console.ReadLine());
            for (i = 0; i < 6; i++)
            {
                if(item==Arr1[i])
                {
                    count1++;
                }
            }
            Console.WriteLine("total occurence of item = " + item + " is:" + count1);
            Console.ReadLine();

            // 6 : age of candidate eligible or not in votes
            int vote_age;
            Console.WriteLine("enter the age:");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if(vote_age<18)
            {
                Console.WriteLine("sorry you are not eligible for casting their vote");
                
            }
            else
            {
                Console.WriteLine("you are eligible for casting your own vote");
            }
            Console.ReadLine();

            // 7 : calculate profit and loss
            int cp;
            int sp;
            Console.WriteLine("enter the cost price:");
            cp = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the selling price:");
            sp = int.Parse(Console.ReadLine());
            if(sp>cp)
            {
                Console.WriteLine("Profit: {0}", sp - cp);

            }
            else if(cp>sp)
            {
                Console.WriteLine("Loss: {0}", cp - sp);
            }
            else
            {
                Console.WriteLine("No profit No loss");
            }
            Console.ReadLine();
           











        }
            
    }
}
