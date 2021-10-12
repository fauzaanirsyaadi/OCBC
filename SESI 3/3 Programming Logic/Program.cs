using System;

namespace _3_Programming_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nilai;
            Console.Write("Nilai: ");
            Nilai = Convert.ToDouble(Console.ReadLine());
            if (Nilai >= 85){
            Console.WriteLine("Kamu mendapat grade A");
            }
            else if (Nilai >= 65){
            Console.WriteLine("Kamu nendapat grade B");
            }
            else if (Nilai >= 45){
            Console.WriteLine("Kamu nendapat grade C");
            }
            else if (Nilai >= 25){
            Console.WriteLine("Kamu nendapat grade D");
            }
        }
    }
}
