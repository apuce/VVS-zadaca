using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class IspitB : Ispit
    {
        Tuple<string, string, string, string, string, string, string> dodatno1;

        public Tuple<string, string, string, string, string, string, string> Dodatno1
        {
            get { return dodatno1; }
            set { dodatno1 = value; }
        }



        Tuple<string, string, string, string, string, string, string> dodatno2;

        public Tuple<string, string, string, string, string, string, string> Dodatno2
        {
            get { return dodatno2; }
            set { dodatno2 = value; }
        }

        
        public void KreirajIspitB(Dictionary<Tuple<string, string, string, string>, int> p, Tuple<string, string, string, string, string, string, string> p7, Tuple<string, string, string, string, string, string, string> p8)
        {
            Pitanja = p;
            this.dodatno1 = p7;
            this.dodatno2 = p8;


        }
    }
}
