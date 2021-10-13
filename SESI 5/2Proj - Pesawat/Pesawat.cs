using System;

class class_pesawat{
    public string nama;

    private string ketinggian;

    public Pesawat(string namaPesawat, string ketinggianPesawat){
      this.nama = namaPesawat;
      this.ketinggian = ketinggianPesawat;
    }

    public string Ketinggian
    {
      get { return this.ketinggian; }
      set { this.ketinggian = value; }
    }

    public void terbang(){
      Console.WriteLine("pesawat dengan nama {0}, sedang take off", this.nama);

    }

    public void sudahTerbang(){
      Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.Ketinggian);
    }
}
