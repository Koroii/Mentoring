using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Teoria
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

            //int dzien = int.Parse(Console.ReadLine());

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

            //switch (dzien)
            //{
            //    case 1:
            //        Console.WriteLine("Poniedzialek");
            //        break;
            //    case 2:
            //        Console.WriteLine("Wtorek");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sroda");
            //        break;
            //    case 4:
            //        Console.WriteLine("Czwartek");
            //        break;
            //    default: 
            //        Console.WriteLine("Nie ma takiego dnia");
            //        break;
            //}

            //bool prawda = 1 > 0;
            //int niewiadomoCo = prawda ? 1 : 0;

            //Console.WriteLine(niewiadomoCo);
            #endregion

            #region Zadania
            // Program ktory dla podanej liczny calkowitej sprawdza czy jest parzysta
            //int liczba = int.Parse(Console.ReadLine());

            //if (liczba % 2 == 0)
            //{
            //    Console.WriteLine("Liczba jest parzysta");
            //}
            //else
            //{
            //    Console.WriteLine("Liczba jest nieparzysta");
            //}


            // Program ktory sprawdza czy podany rok jest rokienm przestepnym. Rok przestepny dzieli sie bez reszty przez 4, nie dzieli sie orzez 100 (za wyjatkiem lat podzielnych przez 400)
            //int rok = int.Parse(Console.ReadLine());

            //bool czyPrzestepny = rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0);

            //string wiadomosc = "Rok " + rok + " jest " + (czyPrzestepny ? "przestepny" : "nieprzestny");
            //Console.WriteLine(wiadomosc);

            // Program pobiera dwie liczby i sprawdza czy liczba druga jest dzielnikiem pierwszej
            // 24, 6 
            //Console.WriteLine("Podaj dzielna: ");
            //int dzielna = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj dzielnik: ");
            //int dzielnik = int.Parse(Console.ReadLine());

            //if (dzielna % dzielnik == 0)
            //{
            //    Console.WriteLine("Liczba "+ dzielnik + " jest dzielnikiem liczby "+dzielna);
            //}
            //else
            //{
            //    Console.WriteLine("Liczba " + dzielnik + " nie jest dzielnikiem liczby " + dzielna);
            //}

            // program obliczajacy liczbe pierwiastkow rownania kwadratowego.
            // y = ax^2 + bx + c
            //Console.WriteLine("Podaj a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj b:");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj c:");
            //int c = int.Parse(Console.ReadLine());

            //int delta = (int)Math.Pow(b, 2) - 4 * a * c;
            //// b^2 to nie jest potega!

            //if(delta > 0)
            //{
            //    int x1 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
            //    int x2 = (-b + (int)Math.Sqrt(delta)) / (2 * a);
            //    Console.WriteLine("Pierwiastkami sa x1=" + x1 + " oraz x2=" + x2);
            //}
            //else if(delta == 0)
            //{
            //    int x0 = -b / 2 * a;

            //    Console.WriteLine("Pierwiastkiem jest x0 = "+ x0);
            //}
            //else
            //{
            //    Console.WriteLine("Brak pierwiastkow");
            //}

            // Program obliczajacy BMI

            // masa / wzrost^2

            Console.WriteLine("Podaj mase");
            int masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach");
            double wzrost = double.Parse(Console.ReadLine()); 

            double bmi = masa / Math.Pow(wzrost, 2);
            
            if (bmi < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("nadwaga");
            }
            else // else if (bmi >= 18.5 && bmi <=5
            {
                Console.WriteLine("Waga prawidlowa");
            }
            #endregion
        }
    }
}