using System;
class overide:Program{
  public override void penjumlahanperkaliandll()
  {
    Console.WriteLine("overiding 2.....----->>>>>");
    Console.WriteLine("Hasil Pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1/bilangan2);
    Console.WriteLine("Hasil Pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2 );
  }

  static void Main(string[] args)
  {
      Program overiding = new Program();
      overiding.bilangan(10, 5);
      overiding.penjumlahanperkaliandll();
      overiding = new overide();
      overiding.bilangan(20, 5);
      overiding.penjumlahanperkaliandll();
      Console.ReadLine();
  }
}
