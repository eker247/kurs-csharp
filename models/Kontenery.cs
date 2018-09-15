using System;                       // Podstawowe klasy np. Console
using System.Linq;                  // Rozszerzenia dla kontenerów np. .Count()
using System.Collections.Generic;   // Kontenery np. List
using models.Dziedziczenie;         // Klasa Punkt

namespace models.Kontenery
{
    static public class Kontener
    {
            static public void InstrukcjeWarunkowe()
        {
            // ============================================================
            //                   Instrukcje warunkowe
            // ============================================================

            var zmienna1 = 9;
            var zmienna2 = 6;
            if (zmienna1 < zmienna2)
            {
                Console.WriteLine($"{zmienna1} jest mniejsza niż {zmienna2}");
            }
            else if (zmienna1 % 2 == 0)
            {
                Console.WriteLine($"{zmienna1} jest parzysta");
            }
            else
            {
                Console.WriteLine("nic z tych rzeczy");
            }

            // switch (zmienna1)
            // {
            //     case 1 : Console.WriteLine("1"); break;
            //     case 9 : Console.WriteLine("9"); break;
            //     default: Console.WriteLine("domyślne"); break;
            // }            
        }

        static public void Tablice()
        {
            // ============================================================
            //                      Tablice
            // ============================================================

            string[] tablica = new string[2];
            // var tablica = new string[2];
            tablica[0] = "Jedynka";
            tablica[1] = "Dwójka";

            Console.WriteLine(tablica[1]);

            // tablica[2] = "Trójka";
            // Console.WriteLine(tablica[2]);
            
            // tablica[1] = "Nadal Dwójka";
            // Console.WriteLine(tablica[1]);
        }

        static public void KontenerList()
        {
            // ============================================================
            //                      List<T>
            // ============================================================

            var listInt = new List<string>();
            Console.WriteLine($"długość: {listInt.Count()}");
            listInt.Add("1");
            listInt.Add("3");
            listInt.Add("5");
            listInt.Add("7");
            listInt.Add("9");
            Console.WriteLine($"długość: {listInt.Count()}");
            foreach (var zmienna in listInt)
            {
                Console.WriteLine(zmienna);
            }
            listInt.RemoveAt(3);
            
            Console.WriteLine($"długość: {listInt.Count()}");

            foreach (var zmienna in listInt)
            {
                Console.WriteLine(zmienna);
            }
            // List<string> listString  = new List<string>();
            // listString.Add("Jeden");
            // listString.Add("Dwa");
            // listString.Add("Trzy");
            // listString.Add("Cztery");

            // var hasIt = listString.Where(x => x.Contains("r"));


            // var hasIt = listInt.Find(x=> x == 0 );
            // Console.WriteLine(hasIt);

            // List<int> punkty = new List<int>();
            // punkty.Add(3);
            // punkty.Add(4);
            // punkty.Add(1);

            // var konkretnyPunkt = punkty.Find(p => p.x == 4);
            // konkretnyPunkt.Show();
        }

        static public void KontenerDictionary()
        {
            // ============================================================
            //                   Słownik i Pętle
            // ============================================================

            // Dictionary<int, Punkt> dictPunkt = new Dictionary<int, Punkt>();
            // dictPunkt[2] = 2;
            // dictPunkt[3] = 3;
            // dictPunkt[27] = 72;
            // dictPunkt[2] = 22;

            // dictPunkt.Add(5, new Punkt(6,2));           

            var dictPunkt = new Dictionary<int, string>();
            dictPunkt[2] = "dwa";
            dictPunkt[3] = "trzy";
            dictPunkt[27] = "dwadzieścia siedem";
            dictPunkt[2] = "DWA";
            dictPunkt.Add(7, "siedem");
            
            

            for (int i = 0; i < dictPunkt.Count(); ++i)
            {
                Console.WriteLine($"{dictPunkt.ElementAt(i).Key} => {dictPunkt.ElementAt(i).Value}");
            }
            
            // int i = 0;
            // var klucze = dictPunkt.Keys;
            // while (i < dictPunkt.Count())
            // {
            //     dictPunkt[klucze.ElementAt(i)].Show();
            //     ++i;
            // }

            // do 
            // {
            //     dictPunkt[klucze.ElementAt(i)].Show();
            //     ++i;
            // } while (i < dictPunkt.Count());
            
            // foreach (var p in dictPunkt)
            // {
            //     p.Value.Show();
            // }
        }

        static public void KontenerQueue()
        {
            // ============================================================
            //                         Queue<T>
            // ============================================================

            Queue<int> queuePunkt = new Queue<int>();
            queuePunkt.Enqueue(0);
            queuePunkt.Enqueue(1);
            queuePunkt.Enqueue(2);
            queuePunkt.Enqueue(3);
            queuePunkt.Enqueue(4);
            
            // for (int i = 0; i < queuePunkt.Count(); ++i)
            // {
            //     queuePunkt.ElementAt(i).Show();
            // }

            Console.WriteLine("Metoda Peek()");
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine($"Rozmiar kolejki: {queuePunkt.Count()}");

            Console.WriteLine("Metodda Peek()");
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine(queuePunkt.Peek());
            Console.WriteLine($"Rozmiar kolejki: {queuePunkt.Count()}");
            
            Console.WriteLine("Metoda Dequeue()");
            Console.WriteLine(queuePunkt.Dequeue());
            Console.WriteLine(queuePunkt.Dequeue());
            Console.WriteLine(queuePunkt.Dequeue());
            Console.WriteLine($"Rozmiar kolejki: {queuePunkt.Count()}");
        }

        static public void KontenerStack()
        {
            // ============================================================
            //                         Stack<T>
            // ============================================================


            var stackPunkt = new Stack<string>();
            stackPunkt.Push("jeden");
            stackPunkt.Push("dwa");
            stackPunkt.Push("trzy");
            while (stackPunkt.Count() > 0)
            {   
                Console.WriteLine(stackPunkt.Peek());
                stackPunkt.Pop();
            }
        }
    }
}