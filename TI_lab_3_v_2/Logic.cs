using System;
using System.Collections.Generic;

namespace TI_lab_3_v_2
{
    public class Logic
    {
        private bool outputPow = false;
        private const int KMaxDiff = 10;
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

        public static int[] GetPrimitiveArray(int number)
        {
            int[] primeFactors = GetPrimeFactors(number);
            List<int> result = new List<int>();
            for (int i = 2; i<number; i++)
            {
                if (IsPrimitiveRoot(i, number, primeFactors))
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }
        public static bool CheckX(string str, int p)
        {
            int number;

            if (int.TryParse(str, out number))
            {
                if (number > 1 && number < p - 1)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool CheckK(string str, int p)
        {
            int number;

            if (int.TryParse(str, out number))
            {
                if (number > 1 && number < p - 1)
                {
                    if (Gcd(number, p-1) == 1)
                        return true;
                }
            }

            return false;
        }

        public static short[] EncryptData(byte[] message, int p, int x, int k, int g, int y)
        {
            short[] cipher = new short[message.Length * 2];
            int startK = k;
            for (int i = 0; i < message.Length; i++)
            {
                short a = (short)modPow(g, k, p);
                byte currByte = message[i];
                long curr1 = modPow(y, k, p);
                long curr2 = curr1 * currByte;
                short b = (short)(curr2 % p);
                cipher[i*2] = a;
                cipher[i*2+1] = b;
                int addToK = 1;
                while (!GCD(k + addToK, p - 1))
                {
                    addToK++;
                }
                k = (k + addToK) < p - 1 ? k + addToK : startK;
            }
            return cipher;
        }

        public static byte[] DecryptData(short[] cipher, int p, int x)
        {
            byte[] message = new byte[cipher.Length / 2];
            for (int i = 0; i < message.Length; i++)
            {
                short a = cipher[i * 2];
                short b = cipher[i*2+1];
                int a1 = modPow(a, x, p);
                int s = ModInverse(p, a1);
                byte curr = (byte)(b * s % p);
                message[i] = curr;
            }
            return message;
        }
        
        private static int[] GetPrimeFactors(int number) //Получение делителей числа
        {
            int result = number - 1;
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= result; i++)
            {
                while (result % i == 0)
                {
                    if (!primeFactors.Contains(i))
                    {
                        primeFactors.Add(i);
                    }
                    result /= i;
                }
            }
            return primeFactors.ToArray();
        }
        private static bool IsPrimitiveRoot(int a, int p, int[] delInts)    // Проверка числа на примитивный корень
        {
            int p1 = p - 1;
            if (p <= 1 || a <= 0)
                return false;
            foreach (var i in delInts)
            {
                if (modPow(a, (p - 1) / i, p) == 1)
                {
                    return false;
                }
            }
            return true;
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
        
        private static int ModInverse(int a, int b)
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
        private static bool GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }

        public static byte[] ShortToByte(short[] shorts)
        {
            byte[] bytes = new byte[shorts.Length*2];
            for (int i = 0; i < shorts.Length; i++)
            {
                bytes[i * 2] = (byte)(shorts[i] & 0xFF); // младший байт
                bytes[i * 2 + 1] = (byte)((shorts[i] >> 8) & 0xFF); // старший байт
            }
            return bytes;
        }
        public static short[] ByteToShort(byte[] bytes)
        {
            if (bytes.Length % 2 != 0)
            {
                throw new ArgumentException("Array length must be even to convert to shorts.");
            }

            short[] shorts = new short[bytes.Length / 2];

            for (int i = 0; i < shorts.Length; i++)
            {
                shorts[i] = (short)((bytes[i * 2 + 1] << 8) | bytes[i * 2]);
            }

            return shorts;
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
    }
}