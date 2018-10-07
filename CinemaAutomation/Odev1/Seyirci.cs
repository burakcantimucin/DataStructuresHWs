using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Seyirci : Kisi
    {
        public int KoltukNo { get; set; }
        public List<Seyirci> Seyirciler { get; set; }
        public Seyirci()
        {
            this.KoltukNo = KoltukNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.TCKimlikNo = TCKimlikNo;
        }
    }
}
