using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDDUKKAN.Siniflar
{
    public class Dvdler
    {
        public int DvdID { get; set; }
        public string DvdAdi { get; set; }
        public string DvdAciklama { get; set; }
        public string Dvdimajyolu { get; set; }

        public Raflar RafID { get; set; }
        public Kategoriler KategoriID { get; set; }
        public Durumlar DurumID { get; set; }
    }
}
