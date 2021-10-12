using System;

namespace hello_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //data string
            String fname, lname, alamat, tanggallahir;
            int umur;

            Console.Write("enter your first name : ");
            fname = Console.ReadLine();

            Console.Write("enter your last name : ");
            lname = Console.ReadLine();

            Console.Write("enter your age: ");
            // umur = Convert.ToInt32(Console.ReadLine());
            umur = int.Parse(Console.ReadLine());

            Console.Write("enter your address: ");
            alamat = Console.ReadLine();
            
            Console.Write("enter your date: ");
            tanggallahir = Console.ReadLine();

            Console.WriteLine("==========");
            Console.WriteLine("--output--");
            Console.WriteLine("my full name is : " + fname + " " + lname);
            Console.WriteLine("my age is : " + umur);
            Console.WriteLine("my address is : " + alamat);
            Console.WriteLine("my date is : "+ tanggallahir);
        }
    }
}
