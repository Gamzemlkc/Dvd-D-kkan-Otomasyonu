using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDDUKKAN.Siniflar
{
   public class Baglanti
    {
        public static string conn
        {
            //MultipleActiveResultSets: Form üzerinde birden fazla DataReader'ı aynı connection üzerinden kullanmak gerektiğinde dr.Close() yapmaya gerek kalmaz. 
            get { return "Server=DESKTOP-V6C2A5J\\SQL2015;Database=OdevDatabase;UID=sa;PWD=123;MultipleActiveResultSets=true"; }
        }
    }
}
