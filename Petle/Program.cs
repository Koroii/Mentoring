using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while (warunek logiczny)
            // {
            //   blok kodu;
            // }
            //Console.WriteLine("Ile razy wyswietlic Hello world");
            //int counter = int.Parse(Console.ReadLine());
            //int i = 0;
            //while (i < counter)
            //{
            //    Console.WriteLine("Hello world");
            //    i++;
            //}
            //Console.WriteLine("Czas "+ DateTime.Now);
            //Console.WriteLine("Czy pokazac ponownie czas? (t/n)"); // T 
            //char odpowiedz = Console.ReadLine().ToLower().Trim()[0]; // T -> t //                     t        //tak
            //while(odpowiedz == 't')
            //{
            //    Console.WriteLine("Czas " + DateTime.Now);
            //    Console.WriteLine("Czy pokazac ponownie czas? (t/n)");
            //    odpowiedz = Console.ReadLine().ToLower().Trim()[0];
            //}
            //char odpowiedz;
            //do
            //{
            //    Console.WriteLine("Czas " + DateTime.Now);
            //    Console.WriteLine("Czy pokazac ponownie czas? (t/n)");
            //    odpowiedz = Console.ReadLine().ToLower().Trim()[0];
            //} while (odpowiedz == 't');

            // for (int i=0; i < 10; i++)
            // {
            // blok kodu;
            // }

            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i++)
            //{

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("i: " + i + " j: " + j);
            //    }
            //}

            //int i = 0;
            //for (; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //for(;i<10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (decimal i =0.1m; i <= 1; i+= 0.1m)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0, j=-10, k=1; i > (j+k); i--, j++, k++) 
            //{
            //    Console.WriteLine("i= {0} j={1} k={2}", i, j, k);
            //}

            //for(int i=0; i<20; i++)
            //{
            //    if(i%2==0)
            //        Console.WriteLine(i);
            //}
            //int i = 0;
            //for (; i < 20; i++)
            //   Console.WriteLine(i);

            //while(true)
            //{
            //    Console.WriteLine("Hello world");
            //}

            //for(int i =0; i<10; i--)
            //{
            //    Console.WriteLine(i);   
            //}

            // zadanka
            // pobrac dwie liczby od uzytkownika i wypisac  liczby parzyste pomiedzy nimi
            //Console.WriteLine("pierwsza liczba");
            //int pierwsza = int.Parse(Console.ReadLine());
            //Console.WriteLine("druga liczba");
            //int druga = int.Parse(Console.ReadLine());
            //Console.WriteLine("Liczby parzyste");

            //if(pierwsza<=druga)
            //{
            //    for(int i =pierwsza; i<=druga; i++)
            //    {
            //        if(i%2==0)
            //        {
            //            Console.WriteLine(i + ",");
            //        }
            //    }
            //}

            //if(pierwsza <=druga)
            //{
            //    pierwsza = (pierwsza % 2 == 0) ? pierwsza : pierwsza++;
            //    druga = (druga % 2 == 0) ? druga : druga--;

            //    for(int i = pierwsza; i <= druga; i += 2)
            //    {
            //        Console.WriteLine(i + ",");
            //    }
            //}

            // dwoch kumpli Janek i Karol ktorzy maja dlug w wysokosci 80 zl.  Umowili siue miedzy soba ze kazdy z nich
            // codziennie bedzie odkladal 20% ze swojego dziennego zarobku. Janek zarabia dziennie 50 zl a karol 40
            // napisz program przy p[omocy do while ktory sprawdzi po ilu dniach obaj koledzy uzbieraja kwote potrzebna do splaty dlugu
            // oraz wypisze wartosc uzbieranej kwoty w kazdym dniu
            //int dzien = 1;
            //double dlug = 80, zarobekJanek = 50, zarobekKarol = 40;
            //double splata = 0;


            //do
            //{
            //    splata += 0.2 * zarobekJanek + 0.2 * zarobekKarol;
            //    Console.WriteLine("Dzien {0} splata {1}", dzien++, splata);
            //}
            //while (dlug > splata);

            // napisac program ktory wyswietli na ekranie kwadrat zbudowany ze znaku *

            for(int i =0; i< 5; i++)
            {
                for (int j = 0; j< 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}