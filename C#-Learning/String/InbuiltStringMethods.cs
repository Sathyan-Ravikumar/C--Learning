using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.String
{
    public class InbuiltStringMethods : ILearnInterface 
    {
        public void Run()
        {
            string sentence = "  Welcome to C# string functions tutorial!  ";
            Console.WriteLine("Original: [" + sentence + "]");

            //Trim - removes leading and trailing spaces
            string trimmed = sentence.Trim();
            Console.WriteLine("Trimmed: [" + trimmed + "]");

            //ToUpper and ToLower - change case
            Console.WriteLine("ToUpper: " + trimmed.ToUpper());
            Console.WriteLine("ToLower: " + trimmed.ToLower());

            //Substring - extract a part of string from the original string
            string sub = trimmed.Substring(11, 10); // From index 11, take 10 chars
            Console.WriteLine("Substring (11,10): " + sub);

            //Replace - replace "tutorial" with "guide"
            string replaced = trimmed.Replace("tutorial", "guide");
            Console.WriteLine("Replaced: " + replaced);

            //Insert - insert "Beginner " at index 11
            string inserted = replaced.Insert(11, "Beginner ");
            Console.WriteLine("Inserted: " + inserted);

            //Remove - remove "Beginner " again (from index 11, 9 characters)
            string removed = inserted.Remove(11, 9);
            Console.WriteLine("Removed: " + removed);

            // Contains - check if string contains "functions"
            Console.WriteLine("Contains 'functions': " + trimmed.Contains("functions"));

            //StartsWith and EndsWith
            Console.WriteLine("StartsWith 'Welcome': " + trimmed.StartsWith("Welcome"));
            Console.WriteLine("EndsWith '!': " + trimmed.EndsWith("!"));

            //Split - split words by space
            string[] words = trimmed.Split(' ');
            Console.WriteLine("Words after Split:");
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    Console.WriteLine("- " + word);
            }

            //Join - join words using comma
            string joined = string.Join(", ", words);
            Console.WriteLine("Joined with commas: " + joined);

            //ToCharArray + Reverse
            char[] letters = "CSharp".ToCharArray();
            Array.Reverse(letters);
            Console.WriteLine("Reversed 'CSharp': " + new string(letters));

            //StringBuilder - build string step by step
            StringBuilder sb = new StringBuilder();
            sb.Append("String");
            sb.Append(" Builder");
            sb.Append(" ...!!!");
            Console.WriteLine("\nStringBuilder result: " + sb.ToString());

            // Insert ", World" at index 5
            sb.Insert(5, ", World");
            Console.WriteLine("After Insert: " + sb.ToString()); // Hello, World

            // Replace "World" with "Sathyan"
            sb.Replace("World", "Sathyan");
            Console.WriteLine("After Replace: " + sb.ToString()); // Hello, Sathyan

            // Remove 2 characters starting from index 5 (", ")
            sb.Remove(5, 2);
            Console.WriteLine("After Remove: " + sb.ToString()); // HelloSathyan

            // Clear the StringBuilder (empties the content)
            sb.Clear();
            Console.WriteLine("After Clear: [" + sb.ToString() + "]"); // Empty string



            //Format - insert values into a template
            string formatted = string.Format("Hi {0}, your score is {1}", "Sathyan", 95);
            Console.WriteLine("\nFormatted: " + formatted);

            //Null/Whitespace checks
            string testStr = "   ";
             // False
            Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(testStr));
            // True
            Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(testStr)); 
        }
    }
}
