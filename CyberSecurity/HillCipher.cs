using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class HillCipher
    {
        private readonly int[,] key;

        public HillCipher(int[,] key)
        {
            if (key.GetLength(0) != 2 || key.GetLength(1) != 2)
                throw new ArgumentException("Key must be 2x2");

            if (!IsInvertible(key))
                throw new ArgumentException("Key matrix is not invertible mod 26");

            this.key = key;
        }

        // ======================
        // Encrypt
        // ======================
        public string Encrypt(string text)
        {
            text = text.ToUpper().Replace(" ", "");
            if (text.Length % 2 != 0)
                text += "X"; // padding

            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i += 2)
            {
                int x = text[i] - 'A';
                int y = text[i + 1] - 'A';

                r[i] = (char)((key[0, 0] * x + key[0, 1] * y) % 26 + 'A');
                r[i + 1] = (char)((key[1, 0] * x + key[1, 1] * y) % 26 + 'A');
            }

            return new string(r);
        }

        // ======================
        // Decrypt
        // ======================
        public string Decrypt(string text, int originalLength)
        {
            int[,] inv = InverseKey(key);
            char[] r = new char[text.Length];

            for (int i = 0; i < text.Length; i += 2)
            {
                int x = text[i] - 'A';
                int y = text[i + 1] - 'A';

                int val1 = (inv[0, 0] * x + inv[0, 1] * y) % 26;
                if (val1 < 0) val1 += 26;

                int val2 = (inv[1, 0] * x + inv[1, 1] * y) % 26;
                if (val2 < 0) val2 += 26;

                r[i] = (char)(val1 + 'A');
                r[i + 1] = (char)(val2 + 'A');
            }

            return new string(r, 0, originalLength); // إزالة أي X padding
        }


        // ======================
        // Helpers
        // ======================
        private bool IsInvertible(int[,] m)
        {
            int det = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) % 26;
            if (det < 0) det += 26;
            return GCD(det, 26) == 1;
        }

        private int[,] InverseKey(int[,] m)
        {
            int det = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) % 26;
            if (det < 0) det += 26;

            int detInv = ModInverse(det, 26);

            return new int[,]
            {
            { ( m[1,1] * detInv) % 26, (-m[0,1] * detInv + 26) % 26 },
            { (-m[1,0] * detInv + 26) % 26, ( m[0,0] * detInv) % 26 }
            };
        }

        private int ModInverse(int a, int m)
        {
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            throw new Exception("No modular inverse");
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
    }

}
