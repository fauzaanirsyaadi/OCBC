using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charray = { '1', ' ', 's', 't', 'r', 'i', 'n', 'g', '.'};
            String str1 = new string(charray);
            String str2 = "String lain.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
