using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class Vigenere
    {
        private readonly string key;
        public Vigenere(string key)
        {
            this.key = key; 
        }
        public string Encrypt(string text)
        {
            char[] r = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
                r[i] = (char)(((text[i] - 'A') + (key[i % key.Length] - 'A')) % 26 + 'A');
            return new string(r);
        }

        public string Decrypt(string text)
        {
            char[] r = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
                r[i] = (char)(((text[i] - 'A') - (key[i % key.Length] - 'A') + 26) % 26 + 'A');
            return new string(r);
        }


    }

}
