using System;

public class pesawat{
  class pesawat_tempur: pesawat{
    public void terbang(){
      Console.WriteLine(" Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membaw jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
  }
}