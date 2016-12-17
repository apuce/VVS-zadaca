using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_MojZamger
{
    class Voditelj : IIspisi
    {
        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }


        int kljuc;

        public int Kljuc
        {
            get { return kljuc; }
            set { kljuc = value; }
        }

        public Voditelj(string i, string p)
        {
            Ime = i;
            Prezime = p;
            Random r = new Random();
            this.kljuc = r.Next();
        }

        public void IspisiPodatke()
        {
            Console.WriteLine("Ime i prezime trenutno prijavljenog voditelja: " + Ime + " " + Prezime);

        }
    }
}
