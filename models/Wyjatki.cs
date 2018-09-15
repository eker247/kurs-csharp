using System;

namespace models.Wyjatki
{
    class Matemat
    {
        static public double Pierwiastek(double liczba) {
            if (liczba < 0) {
                throw new ArgumentOutOfRangeException("Liczba musi być większa lub równa 0!");
            }
            return Math.Sqrt(liczba);
        }
    }
}
