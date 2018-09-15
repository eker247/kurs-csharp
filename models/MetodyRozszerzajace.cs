namespace models.MetodyRozszerzajace
{
    static public class MethodExtensions
    {
        static public bool IsEmpty(this string str) {
            return string.IsNullOrWhiteSpace(str);
           }
        static public bool IsNotEmpty(this string str) {
            return !str.IsEmpty();
        }
        static public bool GreaterThen(this int n, int m) {
            return n > m;
        }
    }
}
