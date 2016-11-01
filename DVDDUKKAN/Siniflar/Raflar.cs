using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDDUKKAN.Siniflar
{
   public class Raflar
    {
        public int RafID { get; set; }
        public string RafAdi { get; set; }
        public string RafAciklama { get; set; }
        public override string ToString()
        {
            return RafAdi;
        }
    }
}
