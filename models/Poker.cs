using System;

namespace PokerSpace
{
    class Gracz
    {
        protected int Many;
        public Gracz(int konto)
        {
            Many = konto;
        }
        public int GetMany(int amount)
        {
            if (amount > Many)
                throw new Exception("Brakuje na koncie");
            Many -= amount;
            return amount;
        }
        public void AddMany(int wygrana)
        {
            Many += wygrana;
        }
        public void Show()
        {
            Console.WriteLine($"Na twoim koncie jest {Many}");
        }
    }

    class PokerGame
    {
        static public void PlayGame()
        {
            Console.WriteLine("Witaj Graczu! Z jaką stawką zaczynasz grę? ");
            int many = int.Parse(Console.ReadLine());
            var gracz = new Gracz(many);
            var losuj = new System.Random();
            int stawka = 100;

            while (true)
            {
                gracz.Show();
                Console.WriteLine("Oczywiście grasz dalej?");
                Console.ReadLine();

                if (losuj.Next(10) > 7)
                    gracz.AddMany(2*stawka);
                else
                {
                    try
                    {
                        gracz.GetMany(stawka);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Przykro mi. Przegrałeś. To się zawsze tak kończy...");
                        break;
                    }
                    finally
                    {
                        Console.WriteLine("Wywołałem finally");
                    }
                }
            }
        }
    }
}