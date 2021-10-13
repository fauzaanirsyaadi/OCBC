using System;

namespace _2Proj___Pesawat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nama pesawat : ");
            string namaPesawat = Console.ReadLine();

            Console.WriteLine("ketinggian : ");
            string ketinggianPesawat = Console.ReadLine();

            Pesawat pesawat1 = new Pesawat(namaPesawat, ketinggianPesawat);

            pesawat1.terbang();
            pesawat1.sudahTerbang();
        }
    }
}
