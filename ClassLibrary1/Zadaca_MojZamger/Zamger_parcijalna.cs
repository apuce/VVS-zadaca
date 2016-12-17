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
        public void RadiIspitA(int redni, ref int tacno, ref int netacno, ref int dvazaredom)
        {


            string odg1 = "";
            string odg2 = "";
            int k = 0;
           

            foreach (Tuple<string, string, string, string> pit in a.Pitanja.Keys)
            {
                Console.WriteLine("Pitanje: " + pit.Item1);
                studenti[redni].rezultatiA.Add(pit.Item1);
                Console.WriteLine("a) " + pit.Item2);
                Console.WriteLine("b) " + pit.Item3);
                Console.WriteLine("c) " + pit.Item4);
                Console.WriteLine("Vas odgovor: ");
                int c;
                Int32.TryParse(Console.ReadLine(), out c);

                int s = a.Pitanja[pit];
                if (s == 1)
                {
                    studenti[redni].rezultatiA.Add(pit.Item2);

                }
                else if (s == 2)
                {
                    studenti[redni].rezultatiA.Add(pit.Item3);
                }
                else studenti[redni].rezultatiA.Add(pit.Item4);

                if (c == 1) { studenti[redni].rezultatiA.Add(pit.Item2); }
                else if (c == 2) { studenti[redni].rezultatiA.Add(pit.Item3); }
                else studenti[redni].rezultatiA.Add(pit.Item4);

                if (s == c) { tacno += 1; if (dvazaredom == 1)dvazaredom--; }
                else { 
                    netacno += 1; 
                    dvazaredom++;
                }
                if (dvazaredom == 2) break;




                k++;
            }

            if (dvazaredom == 2)
            {
                Console.WriteLine("Odgovorili ste dva pitanja zaredom netačno! Pali ste!");
            }
            else
            {
                Console.WriteLine("1) DOPUNI: " + a.Dopuni1.Item1);
                studenti[redni].rezultatiA.Add(a.Dopuni1.Item1);
                odg1 = Console.ReadLine();
                if (odg1 == a.Dopuni1.Item2) { tacno += 1; }
                else { netacno += 1; }
                k++;
                studenti[redni].rezultatiA.Add(a.Dopuni1.Item2);
                studenti[redni].rezultatiA.Add(odg1);




                Console.WriteLine("2) DOPUNI: " + a.Dopuni2.Item1);
                studenti[redni].rezultatiA.Add(a.Dopuni2.Item1);
                odg2 = Console.ReadLine();
                if (odg2 == a.Dopuni2.Item2) { tacno += 1; }
                else { netacno += 1; }

                studenti[redni].rezultatiA.Add(a.Dopuni2.Item2);
                studenti[redni].rezultatiA.Add(odg2);


            }
            if (tacno > 5 && dvazaredom != 2)
            {

                poloziloA.Add(tacno);

            }
            else paloA.Add(tacno);


        }

        public void RadiIspitB(int redni, ref int tacno, ref int netacno, ref int dvazaredom)
        {

            string odg1 = "";
            string odg2 = "";


            foreach (Tuple<string, string, string, string> pit in b.Pitanja.Keys)
            {
                Console.WriteLine("Pitanje: " + pit.Item1);
                studenti[redni].rezultatiB.Add(pit.Item1);
                Console.WriteLine("a) " + pit.Item2);
                Console.WriteLine("b) " + pit.Item3);
                Console.WriteLine("c) " + pit.Item4);
                Console.WriteLine("Vas odgovor: ");
                int c;
                Int32.TryParse(Console.ReadLine(), out c);



                int s = b.Pitanja[pit];
                if (s == 1)
                {
                    studenti[redni].rezultatiB.Add(pit.Item2);

                }
                else if (s == 2)
                {
                    studenti[redni].rezultatiB.Add(pit.Item3);
                }
                else studenti[redni].rezultatiB.Add(pit.Item4);

                if (s == c) { tacno += 1; if (dvazaredom == 1)dvazaredom--; }
                else { netacno += 1; dvazaredom++; }

                if (c == 1) { studenti[redni].rezultatiB.Add(pit.Item2); }
                else if (c == 2) { studenti[redni].rezultatiB.Add(pit.Item3); }
                else studenti[redni].rezultatiB.Add(pit.Item4);

                if (dvazaredom == 2) { Console.WriteLine("Odgovorili ste dva pitanja zaredom netačno! Pali ste!"); break; }


            }
            if (dvazaredom != 2)
            {
                Console.WriteLine("1) Dodatno:" + b.Dodatno1.Item1);
                studenti[redni].rezultatiB.Add(b.Dodatno1.Item1);
                Console.WriteLine("a) " + b.Dodatno1.Item2);
                Console.WriteLine("b) " + b.Dodatno1.Item3);
                Console.WriteLine("c) " + b.Dodatno1.Item4);
                Console.WriteLine("d) " + b.Dodatno1.Item5);
                Console.WriteLine("e) " + b.Dodatno1.Item6);
                Console.WriteLine("ODGOVOR?");
                odg1 = Console.ReadLine();
                if (odg1 == b.Dodatno1.Item7) tacno += 1;
                else netacno += 1;

                studenti[redni].rezultatiB.Add(b.Dodatno1.Item7);
                studenti[redni].rezultatiB.Add(odg1);


                Console.WriteLine("1) Dodatno:" + b.Dodatno2.Item1);
                studenti[redni].rezultatiB.Add(b.Dodatno2.Item1);
                Console.WriteLine("a) " + b.Dodatno2.Item2);
                Console.WriteLine("b) " + b.Dodatno2.Item3);
                Console.WriteLine("c) " + b.Dodatno2.Item4);
                Console.WriteLine("d) " + b.Dodatno2.Item5);
                Console.WriteLine("e) " + b.Dodatno2.Item6);
                Console.WriteLine("ODGOVOR?");
                odg2 = Console.ReadLine();
                if (odg2 == b.Dodatno2.Item7) tacno += 1;
                else netacno += 1;

                studenti[redni].rezultatiB.Add(b.Dodatno2.Item7);
                studenti[redni].rezultatiB.Add(odg2);

            }
            if (tacno > 5 && dvazaredom != 2)
            {
                studenti[redni].PolozenB = true;
                PoloziloB.Add(tacno);
            }
            else PaloB.Add(netacno);

        }
    }
}
