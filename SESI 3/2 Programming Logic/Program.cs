using System;

namespace _2_Programming_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            String Username;
            String Password;

            Console.Write("Username: ");
            Username = Console.ReadLine();
            Console.Write ("Password: ");
            Password= Console.ReadLine();

            if(Username == "ocbc" && Password == "bootcamp"){
            Console.WriteLine("Anda berhasil login");
            }
            else{
                Console.WriteLine("Username atau Password anda salah");

            }
        }
    }
}
