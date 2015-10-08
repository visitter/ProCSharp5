using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp5
{
    class Test
    {
        public Test()
        {

        }
        public void showEnvironmentProperties()
        {
            try
            {                
                System.Collections.Hashtable props = (Hashtable)Environment.GetEnvironmentVariables();

                foreach (DictionaryEntry item in props)
                {
                    Console.WriteLine(item.Key + ":" + item.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }
        public string showStartupAgruments(String[] args)
        {
            String result = String.Empty;

            foreach (String item in args)
            {
                result += item + " ";
            }

            if (result.Trim().Equals(String.Empty))
            {
                throw new MyException("String is empty");
            }
            return result;
        }

        public string GreetUserByDetails()
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            short userAge = 0;
            if (Int16.TryParse(Console.ReadLine(), out userAge))
            {
                int diff = 50 - userAge;
                string eval = String.Empty;

                if (diff > 0)
                {
                    eval = diff + " years older than";
                }
                else if (diff < 0)
                {
                    eval = Math.Abs(diff) + " years younger than";
                }
                else if (diff == 0)
                {
                    eval = "as old as";
                }
                return String.Format("Hello {0}, I am {1} you are", userName, eval);
            }
            else return "Wroing input, please try again";
        }
        public string FormatValue(double value, NumberFormats format)
        {
            try
            {            
                switch (format)
                {
                    case
                        NumberFormats.CURRENCY:
                        return String.Format("Currency formatting: {0:C}", value);
                    case
                        NumberFormats.DECIMAL:
                        return String.Format("DECIMAL formatting:{0:D15}", value);
                    case
                        NumberFormats.EXPONENTIAL:
                        return String.Format("EXPONENTIAL formatting:{0:E}", value);
                    case
                        NumberFormats.FIXED_POINT:
                        return String.Format("FIXED_POINT formatting:{0:F3}", value);
                    case
                        NumberFormats.HEX:
                        return String.Format("HEX formatting: {0:X}", (int)value);
                    case
                        NumberFormats.GENERALS:
                        return String.Format("GENERALS formatting: {0:G}", value);
                    case
                        NumberFormats.INT:
                    default:
                        return String.Format("All formats: Currency:{0:C}\nDecimal:{0:D15}\nEXP:{0:E}\nFixed_point:{0:F3}\nHEX:{0:X}\nGeneral:{0:G}\nDefault:{0:n}", (int)value);                        
                }
            }
                
            catch (FormatException nfe)
            {
                //throw new FormatException("My Invalid format");
                return nfe.Message;
            }    
        }
        public void testCommonProperties()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(13));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        public void getNumericRanges()
        {
            Console.WriteLine(" int16 :  {0} - {1}", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine(" int32 :  {0} - {1}", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine(" int64 :  {0} - {1}", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine(" UInt16:  {0} - {1}", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine(" short :  {0} - {1}", short.MinValue, short.MaxValue);
            Console.WriteLine(" byte  :  {0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(" sbyte :  {0} - {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(" float :  {0} - {1}", float.MinValue, float.MaxValue);
            Console.WriteLine(" ushort:  {0} - {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(" Double:  {0} - {1}", FormatValue(Double.MinValue, NumberFormats.CURRENCY), Double.MaxValue);
        }

        public void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(12) = {0}", 12.Equals(12));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        public void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();

            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        }
        public void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        public void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        public void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }
        public void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }
        public void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            var myArray = new String[5];

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
            Console.WriteLine("myArray is a: {0}", myArray.GetType().Name);
        }
        public void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
        public void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        public double SumMyDoubles( params double[] members)
        {
            double sum = 0;
            foreach (double item in members)
	        {
                sum += item;
	        }
            return sum;
        }
        public void FunWithNullableType()
        {
            Nullable<int> myInt = 5;
            Console.WriteLine("My Int equals {0}", myInt);
            myInt = null;
            Console.WriteLine("My Int equals {0}", myInt.HasValue);
        }
        public int? GetDBValue()
        {
            return null;
        }
    }

    enum NumberFormats { DECIMAL, CURRENCY, FIXED_POINT, INT, HEX, EXPONENTIAL, GENERALS }
    
    class MyException : Exception
    {
        public string message { get; set; }

        public MyException(String message)
        {
            this.message = message;
        }
    }
} 