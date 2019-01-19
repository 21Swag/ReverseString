using System;

namespace ReverseString
{
    class Program
    {     
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            char[] Input =  Console.ReadLine().ToCharArray();
            Array.Reverse( Input );
            string ReverseInput = new string( Input );
            Console.WriteLine(ReverseInput);
        }
    }
}
