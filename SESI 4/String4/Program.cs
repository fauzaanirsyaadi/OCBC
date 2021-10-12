using System;

namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringawal = "C# membuat string mudah.";

            string subtr = stringawal.Substring(5, 12);

            Console.WriteLine("stringawal : " + stringawal);
            Console.WriteLine("substring : " + subtr);
        }
    }
}
