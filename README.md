
##Rezultati review-a prema check listi iz priloga <br>


##Kategorija 1 <br>

Klasa: Program. cs<br>
Primjeæeni su slièni nazivi varijabli, te lako može doæi do zabune pri korištenju.<br>
Linija 32: varijabla kljucc<br>
Linija 171: varijable postoji1 i postoji2<br>
##Kategorija 2 <br>
Klasa: Student.cs<br>
Ne vrši se provjera ulaznih parametara u konstruktoru. Npr. za studijsku godinu studenta, korisnik može unijeti bilo koju vrijednost.<br>
Klasa: Zamger.cs<br>
Linija: 146<br>
Prilikom raèunanja statistièkih podataka prolaznosti na ispitima, oèekuju se rezultati tipa float. Meðutim, koristi se dijeljenje sa dva integer tipa. <br>
Postoji i moguænost dijeljenja sa nulom u istom dijelu koda. <br>
##Kategorija 3 <br>
Klasa: Program.cs <br>
Linija: 46<br>
Nije odabrana adekvatna petlja. Korištena je for-petlja i to ogranièena na 1000 iteracija, jer je korištena pretpostavka da neæe biti potrebno više iteracija.Bolje rješenje je neka beskonaèna petlja. I njenom prepravkom, program æe upasti u beskonaènu petlju, jer nema break-a (odnosno ukoliko korisnik unese 0, ne postoji if-uvjet u kojem se program prekida).<br>
Linija: 38 <br>
Korištena for-petlja za prolaz kroz skup objekata (lista studenata). Bolje rješenje je foreach petlja.<br>
Klasa: Zamger.cs <br>
Linija: 180 <br>
U petlji æe se pristupiti elementu van opsega (ogranièenje smanjiti za 1).<br>
##Kategorija 4<br>
Klasa: Program.cs<br>
U ovoj klasi je korištena if struktura, bez else if iskaza. Tako da æe program, iako je neki uvjet odmah ispunjen, bespotrebno ispitivati i ostale if-ove.<br>
Nema uvjeta za izlazak iz petlje.<br>
##Kategorija 6<br>
Klasa: Ispit.cs<br>
Linija: 36 <br>
Nije implementirana apstraktna metoda brojBodova() u naslijeðenim klasama. 

