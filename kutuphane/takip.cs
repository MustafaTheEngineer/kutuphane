using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane
{
    public class takip
    {
        public int ID { get; set; }
        public int uyeID { get; set; }
        public int kitapID { get; set; }
        public DateTime alimTarihi { get; set; }
        public DateTime teslimTarihi { get; set; }
        public DateTime? geldigiTarih { get; set; }

    }
}
