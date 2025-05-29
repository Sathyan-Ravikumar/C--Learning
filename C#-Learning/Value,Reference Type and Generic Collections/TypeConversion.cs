using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Value_Reference_Type_and_Generic_Collections
{
    public class TypeConversion : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine($"Implicit conversion: ");

            // byte to int (implicit)
            byte b = 20;
            Console.WriteLine($"\nByte : {b.GetTypeCode()}");

            int number = b;
            Console.WriteLine($"Byte to Int : {number} ({number.GetTypeCode()})");

            double d = number;
            Console.WriteLine($"Int to Double : {d} ({d.GetTypeCode()})");

            float f = number;
            Console.WriteLine($"Int to Float : {f} ({f.GetTypeCode()})");

            decimal c = number;
            Console.WriteLine($"Int to Decimal: {c} ({c.GetTypeCode()})");

            long l = number;
            Console.WriteLine($"Int to Long: {l} ({l.GetTypeCode()})");

            // char to int, long, float, double
            char a = 'A';
            Console.WriteLine($"\nType of char variable : {a} ({a.GetTypeCode()})");

            number = a;
            Console.WriteLine($"Char to Int: {number} ({number.GetTypeCode()})");

            d = a;
            Console.WriteLine($"Char to Double: {d} ({d.GetTypeCode()})");

            f = a;
            Console.WriteLine($"Char to Float: {f} ({f.GetTypeCode()})");

            c = a;
            Console.WriteLine($"Char to Decimal: {c} ({c.GetTypeCode()})");

            l = a;
            Console.WriteLine($"Char to Long: {l} ({l.GetTypeCode()})");

            Console.WriteLine("\n===== Explicit Conversion =====");

            // double to int (explicit)
            d = 123.456;
            number = (int)d;
            Console.WriteLine($"\nDouble to Int (123.456): {number} ({number.GetTypeCode()})");
            // float to byte (explicit)
            f = 255.9f;
            b = (byte)f;
            Console.WriteLine($"Float to Byte (255.9): {b} ({b.GetTypeCode()})");

            // long to short (explicit)
            l = 32768;
            short s = (short)l;
            Console.WriteLine($"Long to Short (32768): {s} ({s.GetTypeCode()})");

            // decimal to int (explicit)
            c = 999.99m;
            number = (int)c;
            Console.WriteLine($"Decimal to Int (999.99): {number} ({number.GetTypeCode()})");

            // int to char (explicit)
            number = 66;
            a = (char)number;
            Console.WriteLine($"Int to Char (66): {a} ({a.GetTypeCode()})");

            // int to byte (explicit) Data loss because byte max range is 255
            number = 300;
            b = (byte)number;
            Console.WriteLine($"Int to Byte (300): {b} ({b.GetTypeCode()})  // Data loss!");

             number = 123;
             d = 45.67;
            bool flag = true;
            object obj = null;


            // Using .ToString()
            string str1 = number.ToString();
            Console.WriteLine($"\nToString() from int: {str1} {str1.GetTypeCode()}");

            string str2 = d.ToString();
            Console.WriteLine($"ToString() from double: {str2} {str2.GetTypeCode()}");

            string str3 = flag.ToString();
            Console.WriteLine($"ToString() from bool: {str3} {str3.GetTypeCode()}");

            //Using Convert.ToString()
            string str4 = Convert.ToString(number);
            string str5 = Convert.ToString(obj); //will return null, not throw error
            Console.WriteLine($"Convert.ToString from int: {str4} {str4.GetTypeCode()}");
            Console.WriteLine($"Convert.ToString from null object: {(str5 == null ? "null" : str5)} {str5.GetTypeCode()}");

            // 3. Using string interpolation
            string str6 = $"The number is {number} ";
            Console.WriteLine($"Interpolation: {str6} {str6.GetTypeCode()}");

            // 4. Using concatenation (implicitly converts)
            string str7 = "Value: " + d;
            Console.WriteLine($"Concatenation: {str7} {str7.GetTypeCode()}");



        }
    }
}
