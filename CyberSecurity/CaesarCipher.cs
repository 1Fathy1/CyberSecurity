using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class CaesarCipher
    {
        private int key;
        public CaesarCipher(int key)
        {
            this.key = key; 
        }

        public string Encrypt(string plainText)
        {
            String cipherText = ""; 
            for(int i =0; i < plainText.Length; i++)
            {
                char oldChar = plainText[i];

                if (char.IsLetter(oldChar))
                {
                    char set = char.IsUpper(oldChar) ? 'A' : 'a';

                    int newChar = ((oldChar - set + key) % 26) + set ; 

                    cipherText += (char)newChar;

                }
                else 
                    cipherText += oldChar;

            }
            return cipherText; 
        }
        public string Decrypt(string cipherText) 
        {
            String plainText = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                char oldChar = cipherText[i];
                key = key % 26; 

                if (char.IsLetter(oldChar))
                {
                    char set = char.IsUpper(oldChar) ? 'A' : 'a';

                    int newChar =  (((oldChar - set - key) + 26) % 26) + set ;


                    plainText += (char)newChar;
                }else
                    plainText += oldChar;
            }
            return plainText;

        }
    }
}
