using System;

namespace Alapok1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Deklarálás
			int a, b = 2; //Változók deklarációja egész típusban
			string szoveg = "Saját név";
			string szoveg2 = "Valami {0}";
			a = 10; //értékadás
			char betu = 'q'; //char típusú változó értékadás
			var valt = 12; //A var kulcsszóval a programra bízzuk a típusválasztást, az értékadás kötelező
			var valt2 = "12";
			var serte = "Béla";
			#endregion
			#region Kiírás
			Console.WriteLine("Egyszerű szöveg kiírása a képernyőre"); //szöveg kiírása majd sortörés
			Console.Write("Nincs sortörés "); // nincs sortörés
			Console.WriteLine(a); //változó értékének kiírása és sortörés
			Console.WriteLine("Változó értéke: {0} Másik változó értéke {1}", b, szoveg);
			Console.WriteLine(szoveg, szoveg2);//csak az első szöveget írja ki, mert egy argomentuma van a WriteLine-nak
			Console.WriteLine(szoveg + szoveg2); //szövegek összefűzése
			Console.WriteLine(szoveg2, betu);
			#endregion
			var s = string.Format("Az első valt értéke {0} valt2 értéke {1}", valt, valt2);
			Console.WriteLine(s);
			Console.WriteLine($"Kiírás egy kicsit másként: {szoveg}");
			string szoveg3;
			Console.WriteLine("Kérem a nevedet: ");
			szoveg3=Console.ReadLine();
			Console.WriteLine("A neved:"+szoveg3);
			int szam1;
			Console.WriteLine("Kérem a születési évedet számokkal megadva!"+szoveg3);
			szam1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"A születési éved: {szam1} {12344444}");
			Console.WriteLine("Add meg számokkal, hogy hány éves vagy!");
			int szam2=Int32.Parse(Console.ReadLine());
			Console.WriteLine("Az életkorod: " + szam2);
			//szöveggé konvertálás:
			string szoveg4 = Convert.ToString(szam2);
			Console.WriteLine($"A kiírt érték már string: {szoveg4}");

			Console.ReadKey(); // várakozás egy billentyű lenyomására


        }
    }
}
