using System;
using System.Collections.Generic;
using models.User;
using models.Dziedziczenie;
using models.Interfejsy;
using models.Uogolnione;
using models.Wyjatki;
using models.Funkcje;
using models.MetodyRozszerzajace;
using models.Enumeracja;
using models.Refleksje_Dynamics;
using models.Atrybuty;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using models.Kontenery;

namespace models.Jezyk
{
    class Jezyk
    {
        /** Testing method. Nothing special. */
        static public void Test()
        {
            DateTime startTime = DateTime.Now;
            // const int MAX = 1000000000;
            // int[] tablica = new int[] {2, 4, 6, 6};
            // byte liczba = 0;
            // int liczba = 0;
            // long liczba = 0;
            // decimal liczba = 0;
            // float liczba = 0;
            // double liczba = 0;
            // for (int i = 0; i < MAX; ++i)
            // {
            //     greaters[i] = i * 2;
            // }
            // var rand = new Random();
            // var tablica = new byte[10000];
            // for (int i = 0; i < 10000; ++i)
            // {
            //     tablica[i] = (byte) rand.Next(0, 7);
            //     Console.WriteLine($"{tablica[i]} {tablica[i]*2} {tablica[i]+7} {tablica[i]+2} {tablica[i]*3} {tablica[i]+1}");
            // }
            Console.WriteLine($"Czas obliczeń wynosi {DateTime.Now - startTime}");
            Console.WriteLine("Aby zamknąć wciśnij enter");
            Console.ReadLine();
        }
        static public void TypyDanych()
        {
            Console.WriteLine($"sbyte.MaxValue = {sbyte.MaxValue}");
            Console.WriteLine($"byte.MaxValue = {byte.MaxValue}");
            Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            Console.WriteLine($"ushort.MaxValue = {ushort.MaxValue}");
            Console.WriteLine($"int32.MaxValue = {int.MaxValue}");
            Console.WriteLine($"uint32.MaxValue = {uint.MaxValue}");
            Console.WriteLine($"long.MaxValue = {long.MaxValue}");
            Console.WriteLine($"ulong.MaxValue = {ulong.MaxValue}");
            Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            bool porownaj = 2 > 1;
            Console.WriteLine($"porownaj = {porownaj}");
            porownaj = 2 == -2;
            Console.WriteLine($"porownaj = {porownaj}");

            Console.WriteLine($"string.MaxValue = {$"maksymalna długość łańcucha string to {int.MaxValue} bajtów, przy czym niektóre litery (w tym polskie znaki ąęćś) zajmują 2 bajty"}");
            char litera = 'Ż';
            Console.WriteLine($"litera = {litera}");
            Console.WriteLine($"litera = {(int)litera}");

            
        }

        static public void KonteneryPetle()
        {
            // using to nie #include



            // Kontener.Tablice();
            // Kontener.KontenerList();
            // Kontener.KontenerDictionary();
            // Kontener.KontenerQueue();
            Kontener.KontenerStack();
        }

        
        static public void Klasy()
        {
            // Obiektowo.Struktury();
            Obiektowo.Klasy();
            // Obiektowo.DziedziczenieWielokrotne();
        }

        static public void Interfejsy()
        {
            // Utworzenie obiektu godzina klasy Godzina
            var godzina = new Godzina();

            // Wywołanie metod z zaimplementowanych interfejsów
            godzina.Welcome("Adam");
            godzina.Info();
            Console.WriteLine();

            // Implementacja interfejsów jest bardzo podobna do dziedziczenia.
            // Różnicą jest to, że można zaimplementować wiele interfejsów
            // w jednej klasie. Dziedziczyć zmienne i metody można jedynie po jednej klasie.
            // Interfejsy również umożliwiają tworzenie kontenerów zawierających klasy
            // dziedziczące po takim interfejsie. Różnica między kontenerem interfejsów
            // od kontenera klas bazowych jest taka, że możemy korzystać wyłącznie z metod
            // wchodzących w skład danego interfejsu mimo że klasy mogą implementować wiele 
            // interfejsów np. chociaż klasa Godzina zawiera metodę Info() w tym przykładzie
            // nie mamy możliwości jej użycia


            // ====================================================================
            //   Użycie metody interfejsu IInfo na kolejce dziedziczących go klas
            // ====================================================================
           
            Queue<IInfo> kolejka = new Queue<IInfo>();
            kolejka.Enqueue(new Godzina());
            kolejka.Enqueue(new BrakGodziny());
            kolejka.Enqueue(new Godzina());
            kolejka.Enqueue(new DataNieGodzina());
            while (kolejka.Count() > 0)     // kolejka.Count() sprawdza ilość obiektów w kolejce
            {
                kolejka.Dequeue().Info();
                // kolejka.Dequeue().Welcome();    // zwróci bład kompilacji
            }
        }

        static public void Uogolnione()
        {
            var l = new Liczba<int>(4);
            var m = new Liczba<double>(1.618);
            var n = new Liczba<string>("Slowo");
            Console.WriteLine(l.Value);
            Console.WriteLine(m.Value);
            Console.WriteLine(n.Value);
        }

        static public void Wyjatki()
        {
            // string str = "słowo";
            // Console.WriteLine(nameof(str)); // pomaga w identyfikacji zmiennej


            // try {
            //     Console.WriteLine(Matemat.Pierwiastek(-4));
            // }
            // catch (ArgumentOutOfRangeException ex) {
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine("Wprowadzono błędną wartość! - 1");
            // }
            // catch (Exception ex) {
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine("Wprowadzono błędną wartość! - 2");
            // }
            // finally {
            //     Console.WriteLine("Koniec wyjątków, posprzątane! - 3");
            // }
            PokerSpace.PokerGame.PlayGame();




            // .......
        }

        static public void Polimorfizm() // polymorphism
        {
            List<A> lista = new List<A>();
            lista.Add(new A("imie klasy A"));
            lista.Add(new B("imie klasy B"));
            lista.Add(new C("imie klasy C"));
            foreach(var a in lista) {
                a.Show();
            }
        }

        static public void Delegaty() // delegate
        {
            // Test();
            var delegata = new Delegata();

            // List<int> listaInt = new List<int>();
            // listaInt.Add(1);
            // listaInt.Add(7);
            // listaInt.Add(6);
            // listaInt.Add(3);

            // foreach (var a in listaInt) {
            //     Delegata.ShowAllNumbers(a);
            //     // delegata.Test(a);
            // }
            delegata.Test();
        }

        static public void Lambda()
        {
            Delegata.Lambda();

            // ====================================================================
            //                Zmiana hasła wszystkich użytkowników
            // ====================================================================

            // List<User.User> lista = new List<User.User>()
            // {
            //     new User.User("email@jeden.com", "1111"),
            //     new User.User("email@dwa.pl", "2222"),
            //     new User.User("email@trzy.net", "3333")
            // };
            // Action<User.User> lambda = x => Console.WriteLine
            //     ($"email: {x.Email}, password: {x.Password}") ;


            // lista.ForEach(lambda );


            // lista.ForEach( delegate(User.User s) {
            //     s.Password = s.Email + "_" + s.Email.Length.ToString();
            // } );

            // lista.ForEach( x => Console.WriteLine
            //     ($"email: {x.Email}, password: {x.Password}") );

            // ====================================================================
            //            Sprawdzenie ilości liczb z danego przedziału
            // ====================================================================
            
            int[] liczby = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int ilosc = 0;
            int porownaj = 6;
            liczby.ToList().ForEach(x => {if (x > porownaj) ++ilosc;}); 
            Console.WriteLine($"Ilość liczb większych niż {porownaj} = {ilosc}")      ;
        }

        static public void Zdarzenia() // event
        {
            var eventSandbox = new EventSandbox();
            eventSandbox.Run();
        }

        static public void MetodyRozszerzajace()
        {
            string slowo = "";
            if (slowo.IsEmpty()) {
                Console.WriteLine("Niby co mam wypisać?");
            }
            else {
                Console.WriteLine(slowo);
            }
            int m = 7, n = 5;
            if (m.GreaterThen(n)) {
                Console.WriteLine($"{m} > {n}");
            }
        }

        static public void Enumeracja()
        {
            Enumeratek e1 = new Enumeratek();
            e1.Run();
        }

       static public void Refleksje()
        {
            var a = 13;
            var b = true;
            var c = 'c';
            var d = 3.14159265;
            var e = "Słowo";
            Reflection.ShowType(a);
            Reflection.ShowType(b);
            Reflection.ShowType(c);
            Reflection.ShowType(d);
            Reflection.ShowType(e);
            Console.WriteLine();

            Type typ = a.GetType();
            Console.WriteLine(typ);
            Console.WriteLine(typ.Name);
            Console.WriteLine(typ.FullName);
            Console.WriteLine(typ.Namespace);
            Console.WriteLine(typ.ToString());
            Console.WriteLine();

            var user = new models.User.User("email@abc.com", "password");
            //  User("name", "surname", "address", 44);
            var type = user.GetType().GetTypeInfo();
            var methods = type.GetMethods();
            foreach (var method in methods) {
                Console.WriteLine(method);
            }
            Console.WriteLine();

            Console.WriteLine(user.Email);
            var newSetEmail = methods.First((x) => x.Name == "SetEmail");
            newSetEmail.Invoke(user, new []{"nowy@email.com"});
            Console.WriteLine(user.Email);

            var email = type.GetProperty("email").GetValue(user);
            Console.WriteLine($"zmioniony adres to: {email}");
        }

        static public void Dynamics()
        {
            // różnica międzi dynamic i var lub jawną deklaracją typu jest taka
            // że kompilator nie sprawdza poprawności wywoływanych metod danej klasy
            // Jest to bardziej podatne na błędy i raczej niezalecane
            // można używać gdy jakaś metoda zwraca obiekty różnych typów i przed
            // uruchomieniem aplikacji nie wiadomo jaki będzie jej przebieg
            dynamic user = new User.User("mail_1", "pass_1");
            Console.WriteLine(user.email);
            Console.WriteLine(user.password);
        }

        static public void Atrybuty()
        {
            // więcej o atrybutach na stronie 
            // http://plukasiewicz.net/Csharp_dla_zaawansowanych/Atrybuty
            Console.WriteLine("Dziala");
            var user = new User.User("login", "");
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Password);

            // var passwordAttribute = /*(UserPasswordAttribute)*/user.GetType();//.GetTypeInfo();
         //       .GetProperty("Password").GetCustomAttribute(typeof(UserPasswordAttribute));
            // Console.WriteLine(user.password.Length == passwordAttribute.passwordLength);
            // Reflection.ShowType(passwordAttribute);
            // for (int i = 0; i < 10; i++) {
            //     Console.Write(".");
            //     Thread.Sleep(100);
            // }

            // user.Password = "aaa";
            // var helpAttribute = (LengthAttribute) user.GetType().GetTypeInfo().GetProperty("password")
            //                         .GetCustomAttribute(typeof(LengthAttribute));
            // Console.WriteLine(helpAttribute.length);


        }

        static public void Watki()
        {
            var numbers = Enumerable.Range(0, 100);
            Parallel.ForEach(numbers, number => {
                Console.WriteLine($"Numer {number} na wątku: {Thread.CurrentThread.ManagedThreadId}.");
                });
            // Rozpoczęcie asynchronicznej metody
            // w oddzielnym wątku
            // Task.Factory.StartNew(x => {...});
        }
    }
}
