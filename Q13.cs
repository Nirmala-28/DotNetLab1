using System;

namespace NirmalaLab1
{
  class Q13
    {
        static void Main(string[] args)
        {
            string[] strarray = { "Hi!", "My", "name", "is", "Nirmala" };
            string result = string.Join(" ", strarray);
            Console.WriteLine($"Converted String array into string :\n{result}");
            Console.ReadKey();
        }
    }
}
