using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace models.Dziedziczenie
{
    static public class Obiektowo
    {
        static public void Struktury()
        {
            Console.WriteLine("Struktury...");
        }
        static public void Klasy()
        {
            // var users = new List<User>();
            // users.Add(new User("Adam", "adam@email.com"));
            // users.Add(new User("Bartek", "bartek@email.com"));
            // users.Add(new User("Czesław", "czesio_nie_lubi_email"));

            // foreach (var u in users) {
            //     var correct = u.checkEmail() ? "" : "nie";
            //     Console.WriteLine($"Użytkownik {u.name} posiada adres {u.email}, który jest {correct}prawidłowy.");
            // }
            
            // var writer = System.IO.File.AppendText("plik.txt");
            // writer.WriteLine("hello file");
            // writer.Close();

            var emails = System.IO.File.ReadLines("plik.txt");
            var userList = new List<User>();
            foreach (var e in emails)
            {
                userList.Add(new User("", e));
            }

            foreach (var u in userList)
            {
                var correct = u.checkEmail() ? "" : "nie";
                Console.WriteLine($"Użytkownik {u.name} posiada adres {u.email}, który jest {correct}prawidłowy.");
            }
            
            
        }

        static public void DziedziczenieWielokrotne()
        {
            Punkt A = new Punkt(1, 2);
            Punkt B = new Punkt(3, 4);
            Punkt C = A + B;
            Console.WriteLine($"Współrzędne punktu C: {C.x}, {C.y}");
            C = B.Clone();
            Console.WriteLine($"Współrzędne punktu C: {C.x}, {C.y}");
            B.x = 100;
            Console.WriteLine($"Współrzędne punktu C: {C.x}, {C.y}");
            D d = new D("obiektD");
            d.Show();
        }
    }

    class User
    {
        public string name { get; private set; }
        public string email { get; private set; }

        public User(string n = "", string e = "")
        {
            name = n;
            email = e;
        }

        public bool checkEmail()
        {
            return email != null && Regex.IsMatch(email, @"[^.@][^@]*@[^.@]+\.[^.@]+");
        }
    }





    class Kalkulator
    {
        // modyfikatory dostępu - private, protected, public - określają 
        // jak można się dostać do zmiennych składowych
        
        // public - można modyfikować zmienną przez odwołanie się do obietku
        // używając kropki:     obiekt.Zmienna = wartość;

        // protected - do zmiennych odwołujemy się przez metody składowe i tylko one
        // mają dostęp do tych pól:     var zmienna = obiekt.GetZmienna();
        //                              obiekt.SetZmienna(nowa_wartość);
        
        // private - tutaj działanie takie same jak protected
        protected double X;
        public double Y;
        public Kalkulator(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double dodawanie()
        {
            return X + Y;
        }
        // Dziedzicząc po klasie bazowej używającej modyfikatorów dostępu
        // dostęp do zmiennych składowych również może być ograniczony
        // W przypadku modyfikatora:

        // public - nadal można odwoływać się do wszystkich zmiennych 
        // wewnątrz metod i spoza nich przez odwołanie obiekt.Zmienna = wartość;

        // protected - do zmiennych można odwoływać się poprzez ich nazwę ale tylko wewnątrz
        // metod klasy dziedziczącej: 
        // public int GetLiczba() { return Liczba; }

        // private - do zmiennych w klasie podrzędnej możemy się odwoływać jedynie
        // jedynie przez metody klasy nadrzędnej:
        // public int GetLiczba() { return base.GetLiczba(); }
        
    }
    class Klasa
    {
        // zmienne Properties posiadają możliwość zdefiniowania, że np pobieranie
        // jest publiczne a ustawianie jest chronione lub prywatne zapobiegając
        // niepowołanym zmianom
        public string Pole; // zmienna składowa

        // dzięki słowom get i set możemy też zmodyfikować wartości zwracane lub
        // zabezpieczyć przed wprowadzaniem błędnych danych
        // takie podejście jest możliwe ale jego użycie zależy od zespołu, który pracuje
        // nad aplikacją
        protected int Atrybut;

        public Klasa(string p = "nic", int a = 2)
        {
            Pole = p;
            Atrybut = a;
        }

        public void setAtrybut(int x) {
            if (x > 0) 
            {
                Atrybut = x;
            }
            else
            {
                Atrybut = 0;
            }
        }

        public int getAtrybut() {
            return Atrybut;
        }

        public void setPole(string s)
        {
            Pole = s;
        }
    }

    class Slowo
    {
        public string Word;
        public Slowo(string s = "")
        {
            Word = s;
        }
        public void Show()
        {
            Console.WriteLine($"Słowo: {Word}");
        }

        static public Slowo operator+(Slowo a, string b) 
        {
            return new Slowo(a.Word + b);
        }

        static public Slowo operator-(Slowo a, string b) 
        {
            return new Slowo(a.Word.Replace(b, ""));
        }

        static public string operator-(string a, Slowo b)
        {
            return a.Replace(b.Word, "");
        }
    }


    class Punkt
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punkt(int x = 0, int y = 0) {
            this.x = x;
            this.y = y;
        }

        public Punkt(Punkt a)
        {
            this.x = a.x;
            this.y = a.y;
        }

        static public Punkt operator+(Punkt a, Punkt b)
        {
            return new Punkt(a.x + b.x, a.y + b.y);
        }
        // Nie zadziała
        // static public Punkt operator=(Punkt a)
        // {
        //     Console.WriteLine("ok");
        // }
        public Punkt Clone()
        {
            return new Punkt(x, y);
        }

        virtual public void Show()
        {
            Console.WriteLine($"Punkt o współrzędnych: {x}, {y}");
        }

    }

    class Kolo : Punkt
    {
        public int srednica { get; private set; }
        public Kolo(int x = 0, int y = 0, int d = 0) : base(x, y) {
            this.srednica = d;
        }
        override public void Show()
        {
            base.Show();
            Console.WriteLine($"Kolo o środku o współrzędnych {x}, {y} i średnicy {srednica}");
        }
    }

    // rzutowanie
    // abstract class A
    class A
    {
        public string name { get; set; }
        // konstruktor
        public A(string s = "")
        {
            name = s;
        }
        // metoda wirtualna
        virtual public void Show() { Console.WriteLine($"class A - void Show(): {name}"); }

        // metody wirtualne umożliwiają nadpisywanie ich w klasach dziedziczących
        // korzystając z dziedziczenia mamy możliwość tworzenia kontenerów zawierających
        // obiekty różnych klas pochodnych od tej samej klasy bazowej np:
        // List<A> lista = new List<A>();
        // lista.Add(new A());
        // lista.Add(new B());
        // lista.Add(new B());
        // lista.Add(new D());
        // następnie można w pętli foreach skorzystać z metody wirtualnej wybierającej 
        // odpowiednią wersję metody Show() dla każdej z klas:
        // foreach (var x in lista) { a.Show(); }
    }

    class B : A
    {
        public B(string s = "") : base(s) { }
        override public void Show() { Console.WriteLine($"class B - void Show(): {name}"); }
    }

    class C : B
    {
        public C(string s = "") : base(s) { }
        override public void Show() { Console.WriteLine($"class C - void Show(): {name}"); }
    }

    class D : C
    {
        public D(string s = "") : base(s) {}
        override public void Show() { Console.WriteLine($"class D - void Show(): {name}"); }
    }
}
