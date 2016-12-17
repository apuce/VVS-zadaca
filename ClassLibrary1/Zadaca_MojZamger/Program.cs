using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Zadaca_MojZamger
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamger osnovno = new Zamger();
            
          

            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nPRIJAVI SE KAO STUDENT -> 1");
                Console.WriteLine("PRIJAVI SE KAO VODITELJ -> 2");
                Console.WriteLine("REGISTRUJ SE KAO STUDENT -> 3");
                Console.WriteLine("REGISTRUJ SE KAO VODITELJ -> 4");
                Console.WriteLine("IZLAZ -> 0");
                int n;
                Int32.TryParse(Console.ReadLine(), out n);
                if (n == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\nUnesite svoj kljuc: ");
                    int kljucc;
                    bool postoji = false;
                    int redni=0;
                    Int32.TryParse(Console.ReadLine(), out kljucc);


                    for(int i=0; i<osnovno.Studenti.Count; i++){
                        
                        if (osnovno.Studenti[i].Kljuc == kljucc) { 
                         postoji = true;
                         break;     
                        }
                        redni++;
                        }

                    if (postoji == true)
                    {
                        for (int i=1; i<1000; i++)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("POLAZI ISPIT A -> a");
                            Console.WriteLine("POLAZI ISPIT B -> b");
                            Console.WriteLine("PRIKAZI SVOJE REZULTATE -> c");
                            Console.WriteLine("ODJAVI SE -> d");
                            string k = Console.ReadLine();

                            


                            if (k == "a")
                            {
                                Console.Clear();
                                if (osnovno.Studenti[redni].PolozenB == true)
                                {
                                    int tacno = 0;
                                    int netacno = 0;
                                    int dvazaredom = 0;

                                    try
                                    {
                                        
                                        osnovno.RadiIspitA(redni, ref tacno, ref netacno, ref dvazaredom);

                                        Console.Clear();
                                        Console.WriteLine("TACNO: {0} ", tacno);
                                        Console.WriteLine("NETACNO: {0}", netacno);



                                        if (netacno > tacno || dvazaredom == 2)
                                        {
                                            Console.WriteLine("\nNISTE POLOZILI!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nPOLOZILI STE");
                                            osnovno.Studenti[redni].PolozenA = true;
                                        }


                                        Console.WriteLine("\nAKO ZELITE DETALJNIJI UVID U ISPIT UKUCAJTE 5, AKO NE ONDA 6");
                                        int l;
                                        Int32.TryParse(Console.ReadLine(), out l);
                                        if (l == 5)
                                        {
                                            Console.Clear();
                                            osnovno.Studenti[redni].IspisiRezultateA();
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Voditelj nije kreirao ispit A!");
                                    }

                                }
                                else Console.WriteLine("Nemate polozen ispit B! Prvo polozite ispit B!");

                            }
                            if (k == "b")
                            {
                                Console.Clear();
                                int tacno = 0;
                                int netacno = 0;
                                int dvazaredom = 0;
                                try
                                {

                                    osnovno.RadiIspitB(redni, ref tacno, ref netacno, ref dvazaredom);
                                    Console.Clear();
                                    Console.WriteLine("TACNO: {0} ", tacno);
                                    Console.WriteLine("NETACNO: {0}", netacno);



                                    if (netacno > tacno || dvazaredom == 2)
                                    {
                                        Console.WriteLine("\nNISTE POLOZILI!");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nPOLOZILI STE");
                                        osnovno.Studenti[redni].PolozenB = true;
                                    }

                                    Console.WriteLine("\nAKO ZELITE DETALJNIJI UVID U ISPIT UKUCAJTE 5, AKO NE ONDA 6");
                                    int l;
                                    Int32.TryParse(Console.ReadLine(), out l);
                                    if (l == 5)
                                    {

                                        Console.Clear();
                                        osnovno.Studenti[redni].IspisiRezultateB();
                                    }
                                }
                                catch(Exception e)
                                {
                                    
                                        Console.WriteLine("Voditelj nije kreirao ispit B!");
                                    
                                }

                            }

                            if (k == "c")
                            {
                                Console.Clear();
                                osnovno.Studenti[redni].IspisiPodatke();

                            }

                            if (k == "d") break;
                        }

                    }
                    else Console.WriteLine("Nepostojeci kljuc!\n");
                }
                if (n == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Unesite svoj kljuc: ");
                    int kljuc2;
                    bool postoji2 = false;
                    int redni2=0;
                    Int32.TryParse(Console.ReadLine(), out kljuc2);
                    foreach (Voditelj pom in osnovno.Voditelji)
                    {
                        redni2++;
                        if (pom.Kljuc == kljuc2)
                        {
                            postoji2 = true;
                            break;
                        }
                    }
                        if (postoji2 == true)
                        {
                            for (; ; )
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("KREIRAJ ISPIT A -> a");
                                Console.WriteLine("KREIRAJ ISPIT B -> b");
                                Console.WriteLine("PRIKAZI REZULTATE -> c");
                                Console.WriteLine("STATISTIKA PROLAZNOSTI -> d");
                                Console.WriteLine("ODJAVI SE -> e");
                                string k2 = Console.ReadLine();
                                if (k2 == "a")
                                {
                                    Console.Clear();
                                    List<string> questions = new List<string>();
                                    IspitA a = new IspitA();
                                    Console.WriteLine("Kao tacan odgovor za svako pitanje cuva se redni broj odgovora!");
                                    for (int i = 0; i < 6; i++)
                                    {
                                        Console.WriteLine("\nUnesite pitanje br{0}", i + 1);
                                        string pitanje = Console.ReadLine();
                                        if (osnovno.jelManjeOd10rijeci(pitanje) == false)
                                        {
                                            Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                            pitanje = Console.ReadLine();
                                        }
                                        if (osnovno.jelImaTriIste(pitanje) == true)
                                        {
                                            Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                            pitanje = Console.ReadLine();
                                        }
                                        for (int j = 0; j < questions.Count; j++)
                                        {
                                            if (questions[j] == pitanje)
                                            {
                                                Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                                pitanje = Console.ReadLine();
                                                break;
                                            }

                                        }
                                        foreach (Tuple<string, string, string, string> pit in osnovno.B.Pitanja.Keys)
                                        {
                                            if (pit.Item1 == pitanje)
                                            {
                                                Console.WriteLine("Isto pitanje vec postoji u ispitu B! Ponovite unos!");
                                                pitanje = Console.ReadLine();
                                            }
                                        }

                                        questions.Add(pitanje);
                                        Console.WriteLine("odgovor pod a) ");
                                        string poda = Console.ReadLine();
                                        Console.WriteLine("odgovor pod b) ");
                                        string podb = Console.ReadLine();
                                        Console.WriteLine("odgovor pod c) ");
                                        string podc = Console.ReadLine();
                                        Console.WriteLine("tacan odgovor ");
                                        int k;
                                        Int32.TryParse(Console.ReadLine(), out k);

                                        Tuple<string, string, string, string> p1 = Tuple.Create<string, string, string, string>(pitanje, poda, podb, podc);

                                        a.Pitanja.Add(p1, k);
                                    }
                                    Console.WriteLine("\n1) Za dopuniti: ");
                                    string dopunii = Console.ReadLine();
                                    if (osnovno.jelManjeOd10rijeci(dopunii) == false)
                                    {
                                        Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                        dopunii = Console.ReadLine();
                                    }
                                    if (osnovno.jelImaTriIste(dopunii) == true)
                                    {
                                        Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                        dopunii = Console.ReadLine();
                                    }
                                    for (int j = 0; j < questions.Count; j++)
                                    {
                                        if (questions[j] == dopunii)
                                        {
                                            Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                            dopunii = Console.ReadLine();
                                            break;
                                        }
                                    }

                                    Console.WriteLine("Tacan odg:  ");
                                    string dopuniii = Console.ReadLine();

                                    Console.WriteLine("\n2) Za dopuniti: ");
                                    string dopuni1 = Console.ReadLine();
                                    if (osnovno.jelManjeOd10rijeci(dopuni1) == false)
                                    {
                                        Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                        dopuni1 = Console.ReadLine();
                                    }
                                    if (osnovno.jelImaTriIste(dopuni1) == true)
                                    {
                                        Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                        dopuni1 = Console.ReadLine();
                                    }

                                    for (int j = 0; j < questions.Count; j++)
                                    {
                                        if (questions[j] == dopuni1)
                                        {
                                            Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                            dopuni1 = Console.ReadLine();
                                            break;
                                        }
                                    }
                                    Console.WriteLine("Tacan odg:  ");
                                    string dopunii2 = Console.ReadLine();

                                    Tuple<string, string> prvo = Tuple.Create<string, string>(dopunii, dopuniii);
                                    a.Dopuni1 = prvo;
                                    Tuple<string, string> drugo = Tuple.Create<string, string>(dopuni1, dopunii2);
                                    a.Dopuni2 = drugo;


                                    osnovno.DodajIspitA(a);
                                }

                                if (k2 == "b")
                                {
                                    Console.Clear();
                                    IspitB b = new IspitB();
                                    Console.WriteLine("Kao tacan odgovor za svako pitanje cuva se redni broj odgovora!");
                                    List<string> questionsB = new List<string>();
                                    for (int i = 0; i < 6; i++)
                                    {
                                        Console.WriteLine("\nUnesite pitanje br{0}", i + 1);
                                        string pitanje = Console.ReadLine();
                                        if (osnovno.jelManjeOd10rijeci(pitanje) == false)
                                        {
                                            Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                            pitanje = Console.ReadLine();
                                        }
                                        if(osnovno.jelImaTriIste(pitanje)==true)
                                        {
                                            Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                            pitanje = Console.ReadLine();
                                        }
                                        for (int j = 0; j < questionsB.Count; j++)
                                        {
                                            if (questionsB[j] == pitanje)
                                            {
                                                Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                                pitanje = Console.ReadLine();

                                            }
                                        }
                                        foreach (Tuple<string, string, string, string> pit in osnovno.A.Pitanja.Keys)
                                        {
                                            if (pit.Item1 == pitanje)
                                            {
                                                Console.WriteLine("Isto pitanje vec postoji u ispitu A! Ponovite unos!");
                                                pitanje = Console.ReadLine();
                                            }

                                        }

                                        Console.WriteLine("odgovor pod a) ");
                                        string poda = Console.ReadLine();
                                        Console.WriteLine("odgovor pod b) ");
                                        string podb = Console.ReadLine();
                                        Console.WriteLine("odgovor pod c) ");
                                        string podc = Console.ReadLine();
                                        Console.WriteLine("tacan odgovor ");
                                        int w;
                                        Int32.TryParse(Console.ReadLine(), out w);
                                        Tuple<string, string, string, string> p1 = Tuple.Create<string, string, string, string>(pitanje, poda, podb, podc);

                                        b.Pitanja.Add(p1, w);
                                    }
                                    Console.WriteLine("\n1) Dodatno: ");
                                    string dopuni1 = Console.ReadLine();
                                    if (osnovno.jelManjeOd10rijeci(dopuni1) == false)
                                    {
                                        Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                        dopuni1 = Console.ReadLine();
                                    }
                                    if (osnovno.jelImaTriIste(dopuni1) == true)
                                    {
                                        Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                        dopuni1 = Console.ReadLine();
                                    }
                                    for (int j = 0; j < questionsB.Count; j++)
                                    {
                                        if (questionsB[j] == dopuni1)
                                        {
                                            Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                            dopuni1 = Console.ReadLine();
                                            break;
                                        }
                                    }
                                    Console.WriteLine("a)");
                                    string poda1 = Console.ReadLine();
                                    Console.WriteLine("b)");
                                    string podb1 = Console.ReadLine();
                                    Console.WriteLine("c)");
                                    string podc1 = Console.ReadLine();
                                    Console.WriteLine("d)");
                                    string podd1 = Console.ReadLine();
                                    Console.WriteLine("e)");
                                    string pode1 = Console.ReadLine();
                                    Console.WriteLine("Tacan odg:  ");
                                    string tacno1 = Console.ReadLine();

                                    Console.WriteLine("\n2) Dodatno: ");
                                    string dopuni2 = Console.ReadLine();
                                    if (osnovno.jelManjeOd10rijeci(dopuni2) == false)
                                    {
                                        Console.WriteLine("Pitanje ne smije biti duze od 10 rijeci! Ponovite unos!");
                                        dopuni2 = Console.ReadLine();
                                    }
                                    if (osnovno.jelImaTriIste(dopuni2) == true)
                                    {
                                        Console.WriteLine("Pitanje ne smije sadrzavati vise od 3 iste rijeci! Ponovite unos!");
                                        dopuni2 = Console.ReadLine();
                                    }
                                    for (int j = 0; j < questionsB.Count; j++)
                                    {
                                        if (questionsB[j] == dopuni2)
                                        {
                                            Console.WriteLine("Isto pitanje vec postoji u ispitu! Ponovite unos!");
                                            dopuni2 = Console.ReadLine();
                                            break;
                                        }
                                    }
                                    Console.WriteLine("a)");
                                    string poda2 = Console.ReadLine();
                                    Console.WriteLine("b)");
                                    string podb2 = Console.ReadLine();
                                    Console.WriteLine("c)");
                                    string podc2 = Console.ReadLine();
                                    Console.WriteLine("d)");
                                    string podd2 = Console.ReadLine();
                                    Console.WriteLine("e)");
                                    string pode2 = Console.ReadLine();
                                    Console.WriteLine("Tacan odg:  ");
                                    string tacno2 = Console.ReadLine();

                                    Tuple<string, string, string, string, string, string, string> prvo = Tuple.Create<string, string, string, string, string, string, string>(dopuni1, poda1, podb1, podc1, podd1, pode1, tacno1);
                                    b.Dodatno1 = prvo;
                                    Tuple<string, string, string, string, string, string, string> drugo = Tuple.Create<string, string, string, string, string, string, string>(dopuni2, poda2, podb2, podc2, podd2, pode2, tacno2);
                                    b.Dodatno2 = drugo;
                                    osnovno.DodajIspitB(b);
                                }
                                if (k2 == "c")
                                {
                                    Console.Clear();
                                    osnovno.PrikaziRezultateVoditelju();

                                }
                                if (k2 == "d")
                                {
                                    Console.Clear();
                                    osnovno.Statistika();
                                }

                                if (k2 == "e") break;

                            }
                        }
                        else Console.WriteLine("Nepostojeci kljuc!\n");
                    
                }

                if (n == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Unesite ime: ");
                    string i = Console.ReadLine();
                    Console.WriteLine("Unesite prezime: ");
                    string p = Console.ReadLine();
                    Console.WriteLine("Unesite godinu rodjenja: ");
                    int godina;
                    Int32.TryParse(Console.ReadLine(), out godina);
                    Console.WriteLine("Unesite mjesec rodjenja: ");
                    int mjesec;
                    Int32.TryParse(Console.ReadLine(), out mjesec);
                    Console.WriteLine("Unesite dan rodjenja: ");
                    int dan;
                    Int32.TryParse(Console.ReadLine(), out dan);
                    DateTime dr = new DateTime(godina, mjesec, dan);
                    Console.WriteLine("Unesite naziv fakulteta: ");
                    string fax = Console.ReadLine();
                    Console.WriteLine("Unesite studijsku godinu: ");
                    int sg;
                    Int32.TryParse(Console.ReadLine(), out sg);

                    osnovno.DodajStudenta(i, p, dr, fax, sg);

                }
                if (n == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Unesite ime: ");
                    string i = Console.ReadLine();
                    Console.WriteLine("Unesite prezime: ");
                    string p = Console.ReadLine();

                    osnovno.DodajVoditelja(i, p);
                }

                
            }
        
        }
    }
}
