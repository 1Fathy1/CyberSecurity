using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity
{
    internal class Algorithms
    {
        public static CaesarCipher Caesar(int key) => new CaesarCipher(key);
        public static MonoAlphabetic Mono(string map) => new MonoAlphabetic(map);
        public static Vigenere Vigenère(string monoKey) => new Vigenere(monoKey); 
        public static Beaufort Beaufort(string key) => new Beaufort(key);
        public static PlayFair Play(string key) => new PlayFair(key);
        //public static HillCipher Hill() => new HillCipher(); 
        public static HillCipher Hill(int[,] hK) => new HillCipher(hK);
        public static AffineCipher Affine(int a, int b) => new AffineCipher(a,b);
        public static AutoKey AutoKey(string key) => new AutoKey(key);  
    }

    /*
        CaesarCipher,         Done
        MonoAlphabetic,       Done
        Vigenère,             Done
        Beaufort,             Done
        PlayFair,             Done
        HillCipher,           
        AffineCipher,         Done
        Autokey               Done
    */
    
}
