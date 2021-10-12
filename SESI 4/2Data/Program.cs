using System;

namespace _2Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contoh = new string[4]
            {
                "Motherboard", "Processor", "Power Supply", "Video Card"
            };

            Console.WriteLine("tampilkan semua data dalam array");
            Console.WriteLine("");

            foreach(string contoh1 in contoh)
            {
                Console.WriteLine(contoh1);
            }
            Console.WriteLine("press any key to continue . . .");
        }
    }
}
