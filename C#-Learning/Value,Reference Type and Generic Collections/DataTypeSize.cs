using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Value_Reference_Type_and_Generic_Collections
{
    public class DataTypeSize : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine($"Size of Int : {sizeof(int)} bytes "); // Range: -2,147,483,648 to 2,147,483,647
            Console.WriteLine($"Size of uInt : {sizeof(uint)} bytes"); // Range: 0 to 4,294,967,295
            Console.WriteLine($"Size of long : {sizeof(long)} bytes"); // Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine($"Size of ulong : {sizeof(ulong)} bytes"); // Range: 0 to 18,446,744,073,709,551,615
            Console.WriteLine($"Size of double : {sizeof(double)} bytes"); // precision: 15-16 decimal places
            Console.WriteLine($"Size of float : {sizeof(float)} bytes"); // precision: 6-7 decimal places
            Console.WriteLine($"Size of byte : {sizeof(byte)} bytes"); // Range: 0 to 255
            Console.WriteLine($"Size of sbyte : {sizeof(sbyte)} bytes"); // Range: -128 to 127
            Console.WriteLine($"Size of short : {sizeof(short)} bytes"); // Range: -32,768 to 32,767
            Console.WriteLine($"Size of ushort : {sizeof(ushort)} bytes"); // Range: 0 to 65,535
            Console.WriteLine($"Size of decimal : {sizeof(decimal)} bytes"); // precision : 28-29 decimal places
            Console.WriteLine($"Size of Char : {sizeof(char)} bytes"); // Stores a single character
            Console.WriteLine($"Size of bool : {sizeof(bool)} bytes"); // true or false

        }
    }
}
