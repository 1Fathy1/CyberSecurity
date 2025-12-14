using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace CyberSecurity
{
    internal class PlayFair
    {
        private char[,] matrix = new char[5, 5];
        private string key; 

        public PlayFair(string key)
        {
            this.key = key; 
            BuildMatrix(key);
        }

        public string Encrypt(string text)
        {
            text = text.ToUpper();
            char[] r = new char[text.Length];

            int k = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]))
                {
                    r[i] = text[i];
                    continue;
                }
                int p = text[i] - 'A';

                int kk;
                if (k < key.Length)
                    kk = key[k] - 'A';
                else
                    kk = text[k - key.Length] - 'A';

                r[i] = (char)((p + kk) % 26 + 'A');
                k++;
            }

            return new string(r);
        }

        public string Decrypt(string text)
        {
            text = text.ToUpper();
            char[] r = new char[text.Length];

            List<char> dynamicKey = new List<char>(key);
            int k = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]))
                {
                    r[i] = text[i];
                    continue;
                }

                int c = text[i] - 'A';
                int kk = dynamicKey[k] - 'A';

                char p = (char)((c - kk + 26) % 26 + 'A');
                r[i] = p;

                dynamicKey.Add(p);
                k++;
            }

            return new string(r);
        }

        private void BuildMatrix(string key)
        {
            bool[] used = new bool[26];
            key = key.ToUpper().Replace("J", "I");

            int idx = 0;

            foreach (char c in key)
            {
                if (char.IsLetter(c) && !used[c - 'A'])
                {
                    matrix[idx / 5, idx % 5] = c;
                    used[c - 'A'] = true;
                    idx++;
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (c == 'J') continue;
                if (!used[c - 'A'])
                {
                    matrix[idx / 5, idx % 5] = c;
                    idx++;
                }
            }
        }

        private string PrepareText(string text)
        {
            text = text.ToUpper().Replace("J", "I");
            text = new string(text.Where(char.IsLetter).ToArray());

            List<char> result = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                result.Add(text[i]);

                if (i + 1 < text.Length && text[i] == text[i + 1])
                    result.Add('X');
            }

            if (result.Count % 2 != 0)
                result.Add('X');

            return new string(result.ToArray());
        }

        private (int, int) Find(char c)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] == c)
                        return (i, j);

            throw new Exception("Char not found");
        }
    }

}
