using System;

namespace models.Interfejsy
{
    // Interfejs może posiadać zmienne składowe i metody, które nie posiadają ciała {  }
    // Implementacja interfejsu w danej klasie umożliwia stosowanie dodatkowych metod na tej klasie,
    // które są przewidziane dla danego interfejsu np. sortowanie, wywoływanie metod LINQ np. Where(), Find()

    // Deklaracja interfejsu
    interface IInfo
    {
        int Liczba { get; set; }

        void Info();
    }

    interface IWelcome
    {
        void Welcome(string welcome);
    }

    // Implementacja 2 interfejsów w klasie Godzina
    class Godzina : IInfo, IWelcome
    {
        // klasa Godzina musi zawierać zmienną Liczba
        // zmienna w tej postaci nazywana jest najczęściej Propery
        public int Liczba { get; set; }

        public string Notatka { get;  private set; }

        public Godzina(string notatka = "") 
        {
            this.Notatka = notatka;
            Liczba = 0;
        }

        // Implementacja metody Info() interfejsu IInfo
        public void Info() 
        {
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy, HH:mm"));
        }

        public void Welcome(string name) 
        {
            Console.WriteLine($"Witaj {name}");
        }
    }

    class BrakGodziny : IInfo
    {
        public int Liczba { get; set; }

        public void Info()
        {
            Console.WriteLine("Nie mam zegarka...");
        }
    }
    class DataNieGodzina : IInfo
    {
        public int Liczba { get; set; }

        public void Info()
        {
            Console.WriteLine(DateTime.Now.ToString("<< yyyy (-: MM :-) dd >>"));
        }
    }
}
