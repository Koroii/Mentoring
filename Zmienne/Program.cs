using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); // wyswietla hello world
            //Console.ReadKey(); // czyta klawisz
            //// komentarz
            ///*
            // * to jest dlugi komentarz
            // */
            //// deklaracjwe zmiennych
            //// C# => [const] TYP NAZWA [= WARTOSC];
            //// Python => NAZWA [: TYP] [= WARTOSC]

            //bool prawda;
            //bool falsz = false;
            //Console.WriteLine(falsz);
            //Console.ReadKey();
            //// int , float , double , decimal, string , bool 

            //int x = 5;
            //int y = x;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //x = 6;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int a = 1, b, c = 5;
            //Console.WriteLine(a);

            ////matematyka
            //int a = 4, b = 1, wynik;
            //wynik = 2 * a - 3 * b; // 2a - 3b
            //Console.WriteLine(wynik);
            //Console.ReadLine();
            //double wynik1 = (double)b / a; // rzutowanie
            //Console.WriteLine(wynik1);
            //double testZmienne = 4d; // d lub D
            //float testFloat = 3.5F; // f F
            //decimal testDec = 2.3m; // m M
            //long testLong = 123l; // l L

            //Console.WriteLine("Podaj liczby wieksze od 0");
            //double x, y;
            //x = Convert.ToDouble(Console.ReadLine());
            //y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            //Console.WriteLine(y);
            //Console.ReadLine();

            //// ++ --
            //int x = 0, y;
            //y = ++x * 2; // y = x + 1;
            //y = x++ * 2; // y = x + 1;
            //Console.WriteLine(y);
            //Console.WriteLine(x);
            //// += -= *= /=
            


             // LOGIKA
            Console.WriteLine("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ile masz pieniendzy");
            double pieniadze = double.Parse(Console.ReadLine());

            //// and -> && or -> || not ->!
            ////bool czyMozeKupic = wiek >= 18 && pieniadze >=3.5;
            bool czyMozeKupic = (wiek >= 18) && pieniadze >= 3.5;
            Console.WriteLine(czyMozeKupic);
            Console.WriteLine("Negacja");
            Console.WriteLine(!czyMozeKupic);

            // Operacje na stringach 
            string imie;
            //Console.WriteLine("Podaj imie: ");
            imie = Console.ReadLine();
            char znak = 'A';
            char liczba = (char)122;
            //Console.WriteLine("10" + 10);
            Console.WriteLine(znak + 'B');
            Console.WriteLine(liczba);
            Console.ReadLine();

            Console.WriteLine("Znak: "  + znak + "Liczba: " + liczba);
            Console.WriteLine("Znak: {0} Liczba {1}", znak, liczba);
        }
    }
}