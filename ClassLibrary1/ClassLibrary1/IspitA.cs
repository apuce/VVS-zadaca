using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class IspitA : Ispit
    {
        Tuple<string, string> dopuni1;

        public Tuple<string, string> Dopuni1
        {
            get { return dopuni1; }
            set { dopuni1 = value; }
        }


        Tuple<string, string> dopuni2;

        public Tuple<string, string> Dopuni2
        {
            get { return dopuni2; }
            set { dopuni2 = value; }
        }

       

        public void KreirajIspitA(Dictionary<Tuple<string, string, string, string>, int> p, Tuple<string, string> p7, Tuple<string, string> p8)
        {
            Pitanja = p;
            this.dopuni1 = p7;
            this.dopuni2 = p8;
            
        }

    }
}
