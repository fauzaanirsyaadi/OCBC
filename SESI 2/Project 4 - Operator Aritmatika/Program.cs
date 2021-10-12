using System;

namespace Project_4___Operator_Aritmatika
{
    class Program
    {
        static void Main(string[] args)
        {
            int pertama, kedua, ketiga, total;
            double rata;

            Console.WriteLine("=== Menghitung Nilai ===");
            Console.Write("Masuk nilai Pertama : ");
            pertama = int.Parse(Console.ReadLine());
            Console.Write("Masuk nilai Kedua : ");
            kedua = int.Parse(Console.ReadLine());
            Console.Write("Masuk nilai Ketiga : ");
            ketiga = int.Parse(Console.ReadLine());

            total = pertama + kedua + ketiga;
            rata = total / 3.0;
            Console.WriteLine("Total Nilai adalah : "+ total);
            Console.WriteLine("Rata rata Nilai adalah : "+ rata);
        }
    }
}
