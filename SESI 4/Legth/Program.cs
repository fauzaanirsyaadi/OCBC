using System;

namespace Legth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = new int[10];
            Console.WriteLine("Panjang arrat angka adalah " + angka.Length);

            for (int i = 0 ; i < angka.Length; i++){
                angka[i] = i * i;
            }

            Console.WriteLine("Berikut adalah array angka : ");
            for (int i = 0; i < angka.Length; i++){
                Console.Write(angka[i]+ " ");
            }
            
            Console.WriteLine();
        }
    }
}
