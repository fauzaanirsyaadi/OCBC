using System;

namespace Project_3___Tipe_Data_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama;
            int umur;

            Console.WriteLine("== PROGRAM PENDAFTARAN PENDUDUK ==");
            Console.WriteLine("Masukan nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan alamat : ");
            var alamat = Console.ReadLine();
            Console.WriteLine("Masukan umur : ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima kasih!");
            Console.WriteLine("Data Berikut ");
            Console.WriteLine($"Nama : {nama}");
            Console.WriteLine($"Alamat : {alamat}");
            Console.WriteLine($"Umur : {umur} tahun");
            Console.WriteLine("SUDAH DISIMPAN!");
        }
    }
}
