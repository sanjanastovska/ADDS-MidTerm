using System;
using System.Linq;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverseword = "This is an example!";
            string result = string.Join(" ", reverseword.Split(' ').Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(result);
        }
    }


}
