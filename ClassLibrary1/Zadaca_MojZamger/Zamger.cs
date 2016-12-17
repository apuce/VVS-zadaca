using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Zadaca_MojZamger
{
   public partial class Zamger
    {
        List<Student> studenti;

        internal List<Student> Studenti
        {
            get { return studenti; }
            set { studenti = value; }
        }
        List<Voditelj> voditelji;

        internal List<Voditelj> Voditelji
        {
            get { return voditelji; }
            set { voditelji = value; }
        }
        IspitA a;

        internal IspitA A
        {
            get { return a; }
            set { a = value; }
        }
        IspitB b;

        internal IspitB B
        {
            get { return b; }
            set { b = value; }
        }

        List<int> poloziloA;

        public List<int> PoloziloA
        {
            get { return poloziloA; }
            set { poloziloA = value; }
        }
        List<int> paloA;

        public List<int> PaloA
        {
            get { return paloA; }
            set { paloA = value; }
        }
        List<int> poloziloB;

        public List<int> PoloziloB
        {
            get { return poloziloB; }
            set { poloziloB = value; }
        }
        List<int> paloB;

        public List<int> PaloB
        {
            get { return paloB; }
            set { paloB = value; }
        }
        public Zamger()
        {
            studenti = new List<Student>();
            voditelji = new List<Voditelj>(); ;
            a = new IspitA();
            b = new IspitB();
            poloziloA = new List<int>();
            paloA = new List<int>();
            poloziloB = new List<int>();
            paloB = new List<int>();
        }
        public void DodajStudenta(string i, string p, DateTime d, string f, int g)
        {
            if (DateTime.Today.Year - d.Year > 23)
            {
                Console.WriteLine("Ne mogu se registrovati studenti stariji od 23 godine!");
            }
            else
            {
                studenti.Add(new Student(i, p, d, f, g));
                Console.WriteLine("USPJESNO STE SE REGISTROVALI!");
                Console.WriteLine("Vas kljuc za prijavu je: {0}", studenti[studenti.Count - 1].Kljuc);
            }
        }
        public void DodajVoditelja(string i, string p)
        {
            voditelji.Add(new Voditelj(i, p));
            Console.WriteLine("USPJESNO STE SE REGISTROVALI!");
            Console.WriteLine("Vas kljuc za prijavu je: {0}", voditelji[voditelji.Count - 1].Kljuc);
        }


        public void DodajIspitA(IspitA k)
        {
            a = k;
        }
        public void DodajIspitB(IspitB w)
        {
            b = w;
        }


        public void PrikaziRezultateVoditelju()
        {
            Console.WriteLine("Ispit A polagalo je {0} ", PaloA.Count + PoloziloA.Count + " studenata");
            Console.WriteLine("Od toga je polozilo {0} ", PoloziloA.Count + " studenata");
            Console.WriteLine("sa sljedecim bodovima(broj tacnih odgovora): ");
            foreach (int broj in PoloziloA) Console.WriteLine(broj);
            Console.WriteLine("\n");
            Console.WriteLine("Ispit B polagalo je {0} ", PaloB.Count + PoloziloB.Count + " studenata");
            Console.WriteLine("Od toga je polozilo {0} ", PoloziloB.Count + " studenata");
            Console.WriteLine("sa sljedecim bodovima(broj tacnih odgovora): ");
            foreach (int broj in PoloziloB) Console.WriteLine(broj);
            Console.WriteLine("\n");



        }

        public void Statistika()
        {
            int polA1 = 0, polB1 = 0, polA2 = 0, polB2 = 0, polA3 = 0, polB3 = 0;
            int s1 = 0, s2 = 0, s3 = 0;

            foreach (Student s in studenti)
            {
                if (s.Studijska_godina == 1) s1++;
                if (s.Studijska_godina == 2) s2++;
                if (s.Studijska_godina == 3) s3++;
                if (s.PolozenA && s.Studijska_godina == 1) polA1++;
                if (s.PolozenA && s.Studijska_godina == 2) polA2++;
                if (s.PolozenA && s.Studijska_godina == 3) polA3++;
                if (s.PolozenB && s.Studijska_godina == 2) polB1++;
                if (s.PolozenB && s.Studijska_godina == 2) polB2++;
                if (s.PolozenB && s.Studijska_godina == 2) polB3++;
            }

            Console.WriteLine("Prolaznost ispita A na prvoj studijskoj godini je: " + (polA1 / s1) * 100 + "%");
            Console.WriteLine("Prolaznost ispita A na drugoj studijskoj godini je: " + (polA2 / s2) * 100 + "%");
            Console.WriteLine("Prolaznost ispita A na trecoj studijskoj godini je: " + (polA3 / s3) * 100 + "%");
            Console.WriteLine("Prolaznost ispita B na prvoj studijskoj godini je: " + (polB1 / s1) * 100 + "%");
            Console.WriteLine("Prolaznost ispita B na drugoj studijskoj godini je: " + (polB2 / s2) * 100 + "%");
            Console.WriteLine("Prolaznost ispita B na trecoj studijskoj godini je: " + (polB3 / s3) * 100 + "%");
        }



        public bool jelManjeOd10rijeci(string s)
        {
            int br = 0;

            foreach (char p in s)
            {
                if (char.IsSeparator(p)) br++;
            }

            if (br > 9) return false;

            return true;
        }

        public bool jelImaTriIste(string s)
        {
            List<string> l = new List<string>();

            string[] rijeci = s.Split(' ');
            foreach (string rijec in rijeci)
            {
                l.Add(rijec);
            }

            for (int i = 0; i < l.Count+1; i++)
            {
                string pom = l[i];
                int br = 0;
                foreach (string p in l)
                {
                    if (p == pom) br++;

                    if (br > 3) return true;
                }
            }
            return false;
        }

    }
}
