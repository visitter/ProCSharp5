using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp5
{
 
    class Program
    {
        public int a = 0;
        static void Main(string[] args)
        {
            //ConfigureUI();                        
            Test test = new Test();
            
            test.showEnvironmentProperties();
            /*
            try
            {
                Console.WriteLine(test.showStartupAgruments(args));
            }
            catch (MyException e)
            {
                Console.WriteLine(e.message);
            }
            */
            //Console.WriteLine(test.GreetUserByDetails());
            //System.Windows.MessageBox.Show(test.FormatValue(123, NumberFormats.CURRENCY));
            //System.Windows.MessageBox.Show(test.FormatValue(123, NumberFormats.INT));

            //test.testCommonProperties();
            //test.getNumericRanges();
            //test.ObjectFunctionality();
            //test.DataTypeFunctionality();
            //test.CharFunctionality();
            //test.BasicStringFunctionality();
            //test.StringEquality();
            //test.FunWithStringBuilder();
            //test.DeclareImplicitVars();
            //test.LinqQueryOverInts();
            //Console.WriteLine("sum is {0}", test.SumMyDoubles(5, 6, 7, 8));
            //test.FunWithNullableType();
            //int myInt = test.GetDBValue() ?? -1;
            //Console.WriteLine(myInt);
            
            #region Car            
            //Car myCar = new Car() { Make = "Volvo", Model = "S40", Speed = 0};
            //Console.WriteLine("Accelerating...");
            //for (int i = 0; i < 10; i++)
            //{                
            //    myCar.speedUp(5);
            //    Console.WriteLine(myCar.Speed);
            //}
            
            //Console.WriteLine("\nStopping...");
            //for (int i = 0; i < 10; i++)
            //{
            //    myCar.slowDown(15);
            //    Console.WriteLine(myCar.Speed);
            //    if (myCar.Speed == 0) break;
            //}
            #endregion;


            // Wait for Enter key to be pressed.            
            Console.ReadLine();
        }

        private static void ConfigureUI()
        {
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(150, 50);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }    
}
