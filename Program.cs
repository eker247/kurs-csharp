using System;
using models.Jezyk;
using models.Kontenery;
using models.Dziedziczenie;
using System.Collections.Generic;
using System.Linq;

namespace elektryk
{
    class Program
    {
        public static void Main(string[] args)
        {
            // =============================================================
            //                        Hello World!
            // =============================================================

            
            
            Console.Clear();

            // Console.WriteLine("podaj imię:");
            // string imie = Console.ReadLine();
            // Console.WriteLine($"Witaj {imie}");
            // Console.WriteLine("podaj swój wiek:");
            // int wiek = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Masz {wiek} lat");
            // if (wiek < 18) 
            // {
            //     Console.WriteLine($"Jesteś przed 18");
            // }
            // else if ( wiek >= 18 && wiek < 29 || wiek == 29 )
            // {
            //     Console.WriteLine("Jesteś przed 30"); 
            // }
            // else 
            // {
            //     Console.WriteLine($"Witaj stary");
            // }
            // Console.WriteLine("Koniec");
            
            // =============================================================
            //                      Podstawy języka
            // =============================================================
                        
            // Jezyk.Test();
            // Jezyk.TypyDanych();
            // Jezyk.KonteneryPetle();
            // Kontener.Tablice();
            // Kontener.KontenerList();
            // Kontener.KontenerDictionary();
            // Kontener.KontenerQueue();
            // Kontener.KontenerStack();

            // =============================================================
            //                   Programowanie obiektowe
            // =============================================================
            
            Obiektowo.Klasy();
            // Obiektowo.Polimorfizm();
            // Obiektowo.Interfejsy();

            // =============================================================
            //                        Zaawansowane     
            // =============================================================                   

            // Jezyk.Uogolnione();
            // Jezyk.Delegaty();
            // Jezyk.Lambda();
            // Jezyk.Wyjatki();
            
            // Jezyk.MetodyRozszerzajace();

            // Jezyk.Atrybuty();

            // Jezyk.Zdarzenia();
            // Jezyk.Enumeracja();
            // Jezyk.Refleksje();
            // Jezyk.Dynamics();
            // Jezyk.Watki();

            // Więcej o języku C#
            // https://4programmers.net/C_sharp 
        }
    }
}
