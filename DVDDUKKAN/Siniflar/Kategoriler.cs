using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDDUKKAN.Siniflar
{
   public class Kategoriler
    {

        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }

    }
}
