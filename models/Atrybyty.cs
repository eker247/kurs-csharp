using System;

namespace models.Atrybuty
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UserPasswordAttribute : System.Attribute
    {
        public int passwordLength { get; }

        public UserPasswordAttribute(int passwordLength = 4) 
        {
             this.passwordLength = passwordLength;
        }
    }

    [AttributeUsage(AttributeTargets.Property)] // | AttributeTargets.Field)]
    public class LengthAttribute : Attribute
    {
        public int length;
        public LengthAttribute(int length) 
        {
            if (length < 1)
            {
                throw new Exception("Błąd: hasło nie może być puste");
            }
            this.length = length;
        }
    }
}