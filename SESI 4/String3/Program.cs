using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] str = { "ini", "adalah", "sebuah", "test."};
            Console.WriteLine("Array asli: ");

            for (int i = 0; i < str.Length; i++){
                Console.Write(str[i] + " ");
            }
            Console.WriteLine("\n");

            //mengubah string
            str[1] = "merupakan";
            str[3] = "test, juga!";
            Console.WriteLine("Array termodifikasi : ");

            for (int i = 0; i < str.Length; i++){
                Console.Write(str[i] + " ");
            }
        }
    }
}
