using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class MonoAlphabetic
    {
        public string key ;
        private char[] alphabeticEncrypt = new char[26];
        private char[] alphabeticDecrypt = new char[300]; 
        private char ch = 'A';
        public bool validKey = false; 
        public MonoAlphabetic(string key )
        {
           this.key = key;
            //string res = ""; 
            for (int i = 0; i < 26; i++, ch++)
            {
                alphabeticEncrypt[ch - 'A'] = key[i];
                alphabeticDecrypt[key[i]] = ch;
                //res += $"{key[i]} : {alphabeticDecrypt[key[i]]} \n";
            }
            //MessageBox.Show(res);
        }
        //public  string? Validation(string key)
        //{

        //}
        
        public string Encrypt(string plainText)
        {
            String cipherText = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                if (char.IsLower(plainText[i])){
                    char latter = char.ToUpper(plainText[i]);
                    cipherText += char.ToLower(alphabeticEncrypt[latter - 'A']);
                }
                else
                    cipherText += alphabeticEncrypt[plainText[i] - 'A']; 
            }
            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            String plainText = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                if (char.IsLower(cipherText[i]))
                {
                    char latter = char.ToUpper(cipherText[i]);
                    plainText += char.ToLower(alphabeticDecrypt[latter]);
                }
                else
                    plainText += alphabeticDecrypt[cipherText[i]];
            }
            return plainText;
        }
        
    
    }
}
