using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class PasswordStrength
    {

        public PasswordInformation CharacterRange(string password)
        {
            int digit = 0;
            int lower = 0;
            int upper = 0;
            int symble = 0;

            foreach (char c in password) {
                if (c >= 'a' && c <= 'z')
                    lower = 26;
                else if (c >= 'A' && c <= 'Z')
                    upper = 26;
                else if (c >= '0' && c <= '9')
                    digit = 10;
                else
                    symble = 32;
                
                if (digit != 0 && lower !=0 && upper != 0 && symble != 0)
                    break;

            }


            return new PasswordInformation
            {
                HaveDigit = digit,
                HaveLower = lower,
                HaveSymble = symble,
                HaveUpper = upper 
            };
        }
        
        public int CalcEntropy(int len, int TotalCaracter)
        {
            return (int)(len * Math.Log2(TotalCaracter)); 
        }

        public StringLevel PasswordLevel(int Bit)
        {
            if (Bit < 40) return StringLevel.Weak; 
            if (Bit < 70) return StringLevel.Moderate;
            if (Bit < 90) return StringLevel.Strong;
            return StringLevel.VeryStrong; 
        }
    }
}
