using System;

namespace _3Proj___pesawat_tempur
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat = new pesawat();
            pesawat_tempur pswttempur = new pesawat_tempur();

            // seting artibut/variabel
            pesawat.Nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumalahPenumpang = "3 penumpang";
            pswttempur.Nama = "AZ500TPU";
            pswttempur.JumlahRoda = 5;
            pswttempur.Ketinggian = "200 kaki";
            pswttempur.JumalahPenumpang = "2 Penumpang plus kopilot dan asistance";

            //memanggil method dari suatu kelas
            pesawat.terbang();
            pswttempur.terbangtinggi();
            Console.Read();
        }
    }
}
