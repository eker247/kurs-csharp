using System;
using System.Threading;

namespace models.Funkcje
{
    public class Delegata
    {
        // jest odpowiednikiem wskaźnika na funkcje w C++
        public delegate void Message(string msg);

        public delegate void Show(int num);

        public void Test()
        {

            Message alert = Welcome;
            alert("Witaj w programie mierzącym temperaturę!");
            // CheckTemperature(TooLowTemp, OptimalTemp, TooHighTemp);
            // Action<string> tooLow = (msg) =>
            // {
            //     Console.WriteLine($"Temperatura jest zbyt niska (zmiana o {msg})");
            // };
            // CheckTemperature(tooLow, (msg) => Console.WriteLine
            //     ($"Temperatura optymalna (zmiana o {msg})"), TooHighTemp);








        }

        public static void Lambda()
        {
            // Action<string> noReturn = (str) => {
            //     Console.WriteLine($"noReturn says: {str}");
            // };
            // noReturn("Słowo");

            Func<string, int> length = (str) => { return str.Length; };
            Console.WriteLine(length("słowo"));

            Action a = () => { Console.WriteLine("aaa"); };
            a();
        }

        public static void ShowAllNumbers(int num)
        {
            Console.WriteLine(num);
        }

        public static void Welcome(string msg)
        {
            Console.WriteLine($"{msg}");
        }

        public static void TooLowTemp(string msg)
        {
            Console.WriteLine($"Temperatura jest zbyt niska (zmiana o {msg})");
        }

        public static void OptimalTemp(string msg)
        {
            Console.WriteLine($"Temperatura jest odpowiednia (zmiana o {msg})");
        }

        public static void TooHighTemp(string msg)
        {
            Console.WriteLine($"Temperatura jest zbyt wysoka (zmiana o {msg})");
        }

        // public static void CheckTemperature(Message tooLowTemp, Message optimalTemp,
        //                                                      Message tooHighTemp)
        public static void CheckTemperature(Action<string> tooLowTemp, Action<string> optimalTemp,
                                                             Message tooHighTemp)
        {
            var random = new Random();
            int temp = 10;
            while (true) {
                int diff = random.Next(-5, 5);
                temp += diff;
                Console.Write($"{temp} C. - ");
                if (temp < 0) {
                    tooLowTemp(diff.ToString());
                }
                else if (temp >= 0 && temp <= 20) {
                    optimalTemp(diff.ToString());
                }
                else {
                    tooHighTemp(diff.ToString());
                }
                Thread.Sleep(500);
            }
        }
    }
    class Events
    {
        public delegate void Update(string stat);
        public event Update StatusUpdated;

        public void StartUpdatingStatus()
        {
            while (true) {
                var message = $"status, tics {DateTime.UtcNow.Ticks}";
                StatusUpdated?.Invoke(message);
                Thread.Sleep(500);
            }
        }
    }
    class EventSandbox
    {
        public void Run()
        {
            var events = new Events();
            events.StatusUpdated += DisplayStatus;
            events.StartUpdatingStatus();
        }

        public void DisplayStatus(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
