using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class AffineCipher
    {
        private int a; 
        private int b;

        public AffineCipher(int a, int b)
        {
            this.a = a; 
            this.b = b;
        }
        private int ModInverse(int a)
        {
            for (int i = 1; i < 26; i++)
                if ((a * i) % 26 == 1)
                    return i;
            return 1;
        }

        public string Encrypt(string text)
        {
            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
                r[i] = (char)((a * (text[i] - 'A') + b) % 26 + 'A');

            return new string(r);
        }

        public string Decrypt(string text)
        {
            int aInv = ModInverse(a);
            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
                r[i] = (char)((aInv * ((text[i] - 'A') - b + 26)) % 26 + 'A');

            return new string(r);
        }
    }

}
