using System;
using System.Collections.Generic;

namespace TI_lab_3_v_2
{
    public class Logic
    {
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
                int j = p1 / i;
                int currPow = (int)Math.Pow(a, j);
                int curr = currPow % p;
                if (curr == 1)
                    return false;
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
                    if (Gcd(number, p) == 1)
                        return true;
                }
            }

            return false;
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
    }
}