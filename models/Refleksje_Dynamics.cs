using System;

namespace models.Refleksje_Dynamics
{
    public class Reflection
    {
        static public void ShowType<T>(T x) {
            Console.WriteLine($"Zmienna typu {x.GetType()}");
        }
    }
}
