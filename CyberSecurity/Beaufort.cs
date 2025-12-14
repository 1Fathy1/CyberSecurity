using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class Beaufort
    {
        private string key = ""; 
        public Beaufort(string key)
        {
            this.key = key; 
        }
        public string Operation(string text)
        {
            char[] r = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
                r[i] = (char)(((key[i % key.Length] - 'A') - (text[i] - 'A') + 26) % 26 + 'A');
            return new string(r);
        }
    }
}
