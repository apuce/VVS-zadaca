using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Ispit
    {
        int sifra_ispita;

        public int Sifra_ispita
        {
            get { return sifra_ispita; }
            set { sifra_ispita = value; }
        }



        Dictionary<Tuple<string, string, string, string>, int> pitanja;

        public Dictionary<Tuple<string, string, string, string>, int> Pitanja
        {
            get { return pitanja; }
            set { pitanja = value; }
        }
        
        

        public Ispit()
        {
            pitanja = new Dictionary<Tuple<string, string, string, string>, int>();
        }

        public abstract void brojBodova();
    
    }
}
