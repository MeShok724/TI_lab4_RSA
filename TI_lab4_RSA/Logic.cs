using System;
using System.Collections.Generic;
using System.Linq;

namespace TI_lab_3_v_2
{
    public static class Logic
    {
        public static int H0 = 100;
        public static int topLimit = (int)Math.Round(Math.Sqrt(Int32.MaxValue)); 
        public static int botLimit = 1;
        public class JsonDataClass
        {
            public string text { get; set; }
            public int S { get; set; }
        }
        
        public static int GetHash(int H0, int[] data, int r)
        {
            int H = H0;
            foreach (var M in data)
            {
                H = (int)(((long)(H + (M)) * (H + M)) % r);
            }
            return H;
        }

        public static int GetSignature(int m, int d, int r)
        {
            // int signature = modPow(m, d, r);
            // return signature;
            return modPow(m, d, r);
        }

        public static int GetE(int fR, int d)
        {
            // int e = modInverse(d, fR);
            // return e;
            return modInverse(d, fR);
        }

        public static bool CheckE(int e, int fR)
        {
            if (e >= fR || e <= 1) 
                return false;
            return gcd_bool(e, fR);
        }

        public static bool CheckSignature(JsonDataClass data, int e, int r)
        {
            int hash = GetHash(H0, StringToIntArray(data.text), r);
            int m = modPow(data.S, e, r);
            return hash == m;
        }
        
        public static int CheckPrime(string input)  // Проверка числа на простое и парсинг
        {
            int number;

            if (int.TryParse(input, out number))
            {
                if (IsPrime(number))
                {
                    return number;
                }
            }

            return -1;
        }

        private static bool IsPrime(int number) // Проверка числе на простое без парсинга
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        
        private static int modInverse(int b, int a)
        {
            int d0 = a;
            int d1 = b;
            int x0 = 1, x1 = 0;
            int y0 = 0, y1 = 1;

            while (d1 > 1)
            {
                int q = d0 / d1;
                int d2 = d0 % d1;
                int x2 = x0 - q * x1;
                int y2 = y0 - q * y1;
                
                d0 = d1;
                d1 = d2;
                x0=x1; x1=x2; 
                y0=y1; y1=y2;
            }

            if (y1 < 0)
                y1 += a;

            return y1;
        }
        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private static bool gcd_bool(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }
        public static int modPow(int a, int b, int m)
        {
            int a1 = a;
            int z1 = b;

            int x = 1;

            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 = z1 / 2;
                    a1 = (a1 * a1) % m;
                }

                z1 -= 1;
                x = (x * a1) % m;
            }

            return x;
        }
        public static int[] StringToIntArray(string input)
        {
            return input.Select(c => (int)c).ToArray();
        }
    }
}