using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.EnumParse
{
    public class EnumTryParsing : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine("=== Enum.TryParse Examples ===");

            //Try Parse don't throw any exception if the parse is failed, only returns true or false
            //out keyword is to get the enum value if enum is parsed successfully
            //If parsing fails, the out parameter will have the default value of the enum type.

            string w = "Pending";
            bool tryParse1 = Enum.TryParse<OrderStatusEnum>(w, out OrderStatusEnum out1);
            Console.WriteLine($"1. Parsed boolian output: {tryParse1}");
            Console.WriteLine($"   Parsed output : {out1}");

            //ignore case
            string caseMismatch = "cancelled";
            if (Enum.TryParse<OrderStatusEnum>(caseMismatch, true, out OrderStatusEnum out2))
                Console.WriteLine($"\n2. Parsed '{caseMismatch}' as {out2}");
            else
                Console.WriteLine($"2. Failed to parse '{caseMismatch}'");

            // invalid name
            ReadOnlySpan<char> invalidName = "Invalid";
            if (Enum.TryParse<OrderStatusEnum>(invalidName, out OrderStatusEnum status3))
                Console.WriteLine($"3. Parsed '{invalidName}' as {status3}");
            else
                Console.WriteLine($"3. Failed to parse '{invalidName}'");

            // numberic string in enum
            string numericString = "5";
            if (Enum.TryParse<OrderStatusEnum>(numericString, out OrderStatusEnum status4))
                Console.WriteLine($"4. Parsed numeric string '{numericString}' as {status4}");
            else
                Console.WriteLine($"4. Failed to parse '{numericString}'");
        }
    }
}
