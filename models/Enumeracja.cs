using System.Collections.Generic;
using System.Linq;
using System;

namespace models.Enumeracja
{
    public class Enumeratek
    {
        public void Run()
        {
            // Interfejs IEnumerable umożliwia korzystanie z metod klasy Linq
            // Zwraca uporządkowany zbiór elementów, które można iterować
            IEnumerable<int> numbers = Enumerable.Range(10, 5);
            // IEnumerable jest interfejsem i nie można stworzyć zmiennej takiego typu
            // numbers jest typu Enumerable
            Console.WriteLine(numbers.GetType());
            Console.WriteLine();
            // Użycie zachłannego operatora "greedy operator" ToList
            // pozwala to zapisać 
            var numberList = Enumerable.Range(20, 5).ToList();
            var num1 = MyRange();
            var num2 = GetRange(0, 30, 3);
            foreach (var num in num2) {
                Console.WriteLine(num);
            }

            var podzbior = num2.Where(x => x < 10);
            var enmumerator = podzbior.GetEnumerator();
            while (enmumerator.MoveNext()) {
                Console.WriteLine(enmumerator.Current);
            }

            List<MinUser> users = new List<MinUser>();
            users.Add(new MinUser("Jan", "Kowalski", "Lwowska 4", 42));
            users.Add(new MinUser("Andrzej", "Nowak", "Nawojowska 12", 35));
            users.Add(new MinUser("Michał", "Lipa", "Węgiersa 63", 20));
            users.Add(new MinUser("Zygmunt", "Krzak", "Tarnowska 33", 57));

            var someusers = users.Where(user => user.age < 40);
            foreach (var user in someusers) {
                Console.WriteLine($"{user.name} {user.surname} mieszkający {user.address} wiek {user.age}lat");
            }
        }

        public IEnumerable<int> MyRange()
        {
            yield return 1;
            yield return 3;
            yield return 5;
            yield return 7;
        }

        public IEnumerable<int> GetRange(int less, int greater, int step = 1)
        {
            if (less > greater) {
                throw new Exception("less number can not be greater then greater number");
            }
            else if (step < 1) {
                throw new Exception("step can not be less then 1");
            };
            for (int i = less; i <= greater; i += step) {
                yield return i;
            }
        }
    }

    public class MinUser
    {
        public string name;
        public string surname;
        public string address;
        public int age;
        public MinUser(string n, string s, string a, int ag) {
            name = n;
            surname = s;
            address = a;
            age = ag;
        }
    }
}
