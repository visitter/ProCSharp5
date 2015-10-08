using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10;
            int value2 = 20;
            int value3;//unassigned; cannot pass unassigned var to a method

            /*
            Console.WriteLine("The values before are {0} and {1}", value1, value2);
            Console.WriteLine("The Sum is {0}", Add(value1, value2));
            Console.WriteLine("The value after are {0} and {1}", value1, value2);
            */
            /*
            int res;
            Add(value1, value2, out res);
            Console.WriteLine("The Sum is {0}", res);
            */
            /*
            String str1 = "Ivan";
            String str2 = "Mira";
            Console.WriteLine("Str1 = {0}\nStr2={1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("Str1 = {0}\nStr2={1}",str1,str2);
            SwapStrings(str1, str2);
            Console.WriteLine("Str1 = {0}\nStr2={1}", str1, str2);
            */
            EnterLogData("MyMessage");
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            int res = x + y;
            x += 1;
            y += 1;
            Console.WriteLine( "Add: \"I have modified the values hehe...\"");
            return res;
        }
        static void Add(int x, int y, out int res)
        {
            res = x + y;
        }
        static void SwapStrings(ref String str1, ref String str2)
        {
            String tmpStr = str1;
            str1 = str2;
            str2 = tmpStr;
        }
        static void SwapStrings(String str1, String str2)
        {
            String tmpStr = str1;
            str1 = str2;
            str2 = tmpStr;
        }
        static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = new DateTime())
        {
            if (timeStamp == DateTime.MinValue)
            {
                timeStamp = DateTime.Now;
            }
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            Console.WriteLine("Time of Error: {0}", timeStamp);
        }
    }
}
