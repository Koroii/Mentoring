using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if (wyrazenie logiczne)
            // polecenie; --> jednolinijkowe

            // if (wyrazenie logiczne) 
            // {
            // blok kodu;
            // }
            //int a = 5, b=3;

            //if (a < b)
            //{
            //    Console.WriteLine("A jest mniejsze od B");
            //}
            //Console.ReadKey();

            // if (wyrazenie logiczne) 
            // {
            // blok kodu
            // }
            //else 
            // {
            // blok kodu
            // }

            //int a = 3, b = 3;
            //// < > <= >=
            //if (a <= b)
            //{
            //    Console.WriteLine("A jest mniejsze od B");
            //}
            //else
            //{
            //    Console.WriteLine("B jest mniejsze od A");
            //}


            //if (a < b)
            //{
            //    Console.WriteLine("A jest mniejsze od B");
            //}
            //Console.WriteLine("B jest mniejsze od A");

            //int a = 1;

            //if (a == 1 || a == -1)
            //{
            //    Console.WriteLine("Podana wartosc jest wartoscia bezwzgledna liczby 1");
            //}

            //int x=2, y=3, z = 5;

            //if(x*y == 6 && 10 % z == 0 && z==5) 
            //{
            //    Console.WriteLine("Super");
            //}

            //string imie, nazwisko;
            //Console.WriteLine("Podaj imie: ");
            //imie = Console.ReadLine();
            //Console.WriteLine("Podaj nazwisko: ");
            //nazwisko = Console.ReadLine();
            //Console.WriteLine(" ".Length);
            //if(imie.Length + 1 + nazwisko.Length > 30)
            //{
            //    Console.WriteLine("Za dlugie imie i nazwisko");
            //}
            //else
            //{
            //    Console.WriteLine("Wszystko ok");
            //}

            //Console.ReadKey();

            //double przychod = 1000.00, koszty = 900.00;

            //double dochod = przychod - koszty;
            //if (dochod == 0)
            //{
            //    Console.WriteLine("Dochod jest zerowy");
            //}
            //if (dochod > 0)
            //{
            //    Console.WriteLine("Mamy zysk");
            //}
            //if (dochod < 0)
            //{
            //    Console.WriteLine("Mamy strate");
            //}

            //if (dochod == 0)
            //{
            //    Console.WriteLine("Dochod jest zerowy");
            //}
            //else
            //{
            //    if (dochod > 0)
            //    {
            //        Console.WriteLine("Mamy zysk");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mamy strate");
            //    }
            //}

            //if (dochod != 0)
            //{
            //    if (dochod > 0)
            //    {
            //        Console.WriteLine("Mamy zysk");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mamy strate");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Dochod jest zerowy");
            //}

            int dzien = int.Parse(Console.ReadLine());

            //if (dzien == 1)
            //{
            //    Console.WriteLine("Poniedzialek");
            //}
            //else if (dzien == 2)
            //{
            //    Console.WriteLine("Wtorek");
            //}
            //else if(dzien == 3)
            //{
            //    Console.WriteLine("Sroda");

            //}
            //else if (dzien == 4) 
            //{
            //    Console.WriteLine("Czwartek");

            //}
            //else
            //{
            //    Console.WriteLine("Nie ma takiego dnia");
            //}

            switch (dzien)
            {
                case 1:
                    Console.WriteLine("Poniedzialek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Sroda");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                default: 
                    Console.WriteLine("Nie ma takiego dnia");
                    break;
            }

            bool prawda = 1 > 0;
            int niewiadomoCo = prawda ? 1 : 0;

            Console.WriteLine(niewiadomoCo);
        }
    }
}