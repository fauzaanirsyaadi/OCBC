using System;

namespace fundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Pelanggan");
            Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
            Console.WriteLine("tahap 1 kita belajar dasar C#");

            //data string
            String namacustomer = "foxi";
            double harga1 = 10000, harga2 = 5000, harga3 = 20000;
            int jumlah1 =10, jumlah2 = 7, jumlah3 = 13;

            double total1 = harga1*jumlah1;
            double total2 = harga2*jumlah2;
            double total3 = harga3*jumlah3;

            double totalhargasemuabarang = total1+total2+total3;
            int jumlahsemuabarang = jumlah1+jumlah2+jumlah3;

            Console.WriteLine();
            Console.WriteLine("nama customer : " + namacustomer);
            Console.WriteLine(" barang 1 ber jumlah : " + jumlah1 + "dengan harga "+harga1+ " jumlah harga yang harus dibayar "+total1);
            Console.WriteLine(" barang 1 ber jumlah : " + jumlah2 + "dengan harga "+harga2+ " jumlah harga yang harus dibayar "+total2);
            Console.WriteLine(" barang 1 ber jumlah : " + jumlah3 + "dengan harga "+harga3+ " jumlah harga yang harus dibayar "+total3);
            Console.WriteLine();
            Console.WriteLine("jumlah semua barang : " + jumlahsemuabarang);
            Console.WriteLine("total harga semua barang : "+ totalhargasemuabarang); 

            
        }
    }
}
