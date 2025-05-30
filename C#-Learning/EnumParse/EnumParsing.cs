using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.EnumParse
{
    public class EnumParsing : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine("=== Enum.Parse Examples ===");

            // Enum.Parse(Type, string) - Parse is Case sensitive
            var status1 = (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), "Pending");
            Console.WriteLine($"1. Parse(Type, string): {status1}");

            //Enum.Parse(Type, string, bool) - here the bool/true for parse to accept the ignorecase
            var status2 = (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), "shipped", true);
            Console.WriteLine($"2. Parse(Type, string, bool): {status2}");

            //Enum.Parse(Type, ReadOnlySpan<char>) - ReadOnlySpan is a struct which point the memory of the string, no extra memory is allocated by using this.
            ReadOnlySpan<char> span3 = "Delivered";
            var status3 = (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), span3);
            Console.WriteLine($"3. Parse(Type, ReadOnlySpan<char>): {status3}");

            //Enum.Parse(Type, ReadOnlySpan<char>, bool)
            ReadOnlySpan<char> span4 = "cancelled";
            var status4 = (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), span4, true);
            Console.WriteLine($"4. Parse(Type, ReadOnlySpan<char>, bool): {status4}");

            //Enum.Parse<TEnum>(string)
            var status5 = Enum.Parse<OrderStatusEnum>("Processing");
            Console.WriteLine($"5. Parse<TEnum>(string): {status5}");

            //Enum.Parse<TEnum>(string, bool)
            var status6 = Enum.Parse<OrderStatusEnum>("processing", true);
            Console.WriteLine($"6. Parse<TEnum>(string, bool): {status6}");

            //Enum.Parse<TEnum>(ReadOnlySpan<char>)
            ReadOnlySpan<char> span7 = "Pending";
            var status7 = Enum.Parse<OrderStatusEnum>(span7);
            Console.WriteLine($"7. Parse<TEnum>(ReadOnlySpan<char>): {status7}");

            //Enum.Parse<TEnum>(ReadOnlySpan<char>, bool)
            ReadOnlySpan<char> span8 = "delivered";
            var status8 = Enum.Parse<OrderStatusEnum>(span8, true);
            Console.WriteLine($"8. Parse<TEnum>(ReadOnlySpan<char>, bool): {status8}");

            //Enum.Parse(Type, string) - Numeric string
            var status9 = (OrderStatusEnum)Enum.Parse(typeof(OrderStatusEnum), "5");
            Console.WriteLine($"9. Parse(Type, string) with number: {status9}");

            //Exception example (uncomment to test)
            try
            {
                var status10 = Enum.Parse<OrderStatusEnum>("Returned");
                Console.WriteLine($"10. Invalid enum value: {status10}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"10. Exception: {ex.Message}");
            }

            

        }
    }
}
