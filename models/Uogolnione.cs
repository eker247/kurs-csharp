// using System;
// using System.Collections.Generic;

namespace models.Uogolnione
{
    // Tworzenie klasy generycznej (programowanie uogólnione)
    // opcjonalne ograniczenie 
    // where T : class oznacza, że za T mogą być podstawione tylko obiekty w tym string
    // where T : struct - za T mogą być podstawowe tylko typy wbudowne int, float, decimal, char
    // osoby znające temat wpisują w google: generic constraints c#
    // pierwsze 2 odnośniki
    // więcej na temat ograniczeń https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint
    public class Liczba<T>  // where T : class // struct
    {
        public T Value;
        public Liczba(T l) 
        {
            Value = l;
        }
        // ćwiczenie napisać metodę zwracającą Wartosc tak, aby dało się ją wyświetlić
        // przez Console.WriteLine(obiekt.GetValue())
    }
}
