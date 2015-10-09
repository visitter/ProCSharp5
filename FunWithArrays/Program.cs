using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInts = new int[3];
            
            arrInts[0] = 1;
            arrInts[1] = 2;
            arrInts[2] = 3;

            foreach( int i in arrInts ){
                Console.WriteLine(i);
            }

            int[] arrInts2 = new int[5];
            arrInts.CopyTo(arrInts2,2);
            Console.WriteLine("Rank arrInt1: "+arrInts.Rank);
            Console.WriteLine("Rank arrInt2: "+arrInts2.Rank);
            Array.Reverse(arrInts2);
            Array.Sort(arrInts2);
            /*
            Array.Clear(arrInts, 0, 3);
            */
            foreach (int i in arrInts2)
            {
                Console.WriteLine(i);
            }

            String[] arrStrings = new String[3];

            Console.ReadLine();
        }
    }
}
