using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_MojZamger
{
    public class Student : IIspisi
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


        DateTime datum_rodjenja;

        public DateTime Datum_rodjenja
        {
            get { return datum_rodjenja; }
            set { datum_rodjenja = value; }
        }
        string naziv_fakulteta;

        public string Naziv_fakulteta
        {
            get { return naziv_fakulteta; }
            set { naziv_fakulteta = value; }
        }

        public List<string> rezultatiA;

        public List<string> RezultatiA
        {
            get { return rezultatiA; }
            set { rezultatiA = value; }
        }
        public List<string> rezultatiB;

        public List<string> RezultatiB
        {
            get { return rezultatiB; }
            set { rezultatiB = value; }
        }

        int studijska_godina;


        public int Studijska_godina
        {
            get { return studijska_godina; }
            set { studijska_godina = value; }
        }
        bool polozenA;

        public bool PolozenA
        {
            get { return polozenA; }
            set { polozenA = value; }
        }
        bool polozenB;

        public bool PolozenB
        {
            get { return polozenB; }
            set { polozenB = value; }
        }
        int kljuc;

        public int Kljuc
        {
            get { return kljuc; }
            set { kljuc = value; }
        }

        public Student(string i, string p, DateTime dat, string fax, int god)
        {
            Ime = i;
            Prezime = p;
            this.datum_rodjenja = dat;
            this.naziv_fakulteta = fax;
            this.studijska_godina = god;
            Random r = new Random();
            this.kljuc = r.Next();
            polozenA = false;
            polozenB = false;
            this.rezultatiA = new List<string>();
            this.rezultatiB = new List<string>();
        }





        public void IspisiRezultateA()
        {
            int r = 1;
            for (int i = 0; i < RezultatiA.Count; i++)
            {
                Console.WriteLine("\nPitanje: " + rezultatiA[i]);
                Console.WriteLine("Tacan odgovor: " + rezultatiA[++i]);
                Console.WriteLine("Vas odgovor: " + rezultatiA[++i]);

            }
        }
        public void IspisiRezultateB()
        {
            int r = 1;
            for (int i = 0; i < RezultatiB.Count; i++)
            {
                Console.WriteLine("\nPitanje: " + rezultatiB[i]);
                Console.WriteLine("Tacan odgovor: " + rezultatiB[++i]);
                Console.WriteLine("Vas odgovor: " + rezultatiB[++i]);

            }
        }

        public void IspisiPodatke()
        {
            if (PolozenA == true) Console.WriteLine("Imate polozen ispit A");
            else Console.WriteLine("Nemate polozen ispit A");
            if (PolozenB == true) Console.WriteLine("Imate polozen ispit B");
            else Console.WriteLine("Nemate polozen ispit B");
        }
    }
}
