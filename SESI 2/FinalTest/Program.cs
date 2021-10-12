using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username : ");
            string username = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password : ");
            string password = Console.ReadLine();
            Console.Write("gender : ");
            string gender = Console.ReadLine();
            Console.Write("status : ");
            string status = Console.ReadLine();

            
            Console.WriteLine("nilai pertama : ");
            int nilaiPertama = int.Parse(Console.ReadLine());
            Console.WriteLine("nilai kedua : ");
            int nilaiKedua = int.Parse(Console.ReadLine());
            Console.WriteLine("nilai ketiga : ");
            int nilaiKetiga = int.Parse(Console.ReadLine());
            
            bool isAdult = age > 18;
            bool isPasswordValid = password == "OCBC";

            int totalNilai = nilaiPertama + nilaiKedua + nilaiKetiga;
            int Rata = totalNilai/3;

            Console.WriteLine(" ");
            Console.WriteLine("=== Biodata ===");
            Console.WriteLine("Username : " + username);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Status : " + status);

            if (isAdult && isPasswordValid){
                Console.WriteLine("PASSWORD BENAR!");
            }else{
                Console.WriteLine("Sorry, try again!");
            }

            Console.WriteLine("total nilai adalah "+ totalNilai);
            Console.WriteLine("Rata rata nilai adalah " + Rata);
        }
    }
}