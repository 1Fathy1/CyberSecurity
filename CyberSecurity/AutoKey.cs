using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class AutoKey
    {
        private string key; 
        static string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        static int N = 62;

        public AutoKey(string key)
        {
            this.key = key; 
        }

        static int CharToIndex(char c)
        {
            for (int i = 0; i < N; i++)
                if (ALPHABET[i] == c)
                    return i;
            return -1;
        }

        static char IndexToChar(int i)
        {
            return ALPHABET[(i % N + N) % N];
        }
        
        public string Encrypt(string text)
        {
            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                int x = CharToIndex(text[i]);
                int k = (i < key.Length)
                    ? CharToIndex(key[i])
                    : CharToIndex(text[i - key.Length]);

                r[i] = (x == -1) ? text[i] : IndexToChar(x + k);
            }
            return new string(r);
        }

        public string Decrypt(string text)
        {
            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                int x = CharToIndex(text[i]);
                int k = (i < key.Length)
                    ? CharToIndex(key[i])
                    : CharToIndex(r[i - key.Length]);

                r[i] = (x == -1) ? text[i] : IndexToChar(x - k);
            }
            return new string(r);
        }
    }
}
