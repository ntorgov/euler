using System;
using System.Collections.Generic;
using System.Numerics;

namespace euler_0023
{
    /// <summary>
    /// <para>Идеальным числом называется число, у которого сумма его делителей равна самому числу. Например, сумма делителей числа 28 равна 1 + 2 + 4 + 7 + 14 = 28, что означает, что число 28 является идеальным числом.</para>
    /// Число n называется недостаточным, если сумма его делителей меньше n, и называется избыточным, если сумма его делителей больше n.
    /// Так как число 12 является наименьшим избыточным числом (1 + 2 + 3 + 4 + 6 = 16), наименьшее число, которое может быть записано как сумма двух избыточных чисел, равно 24. Используя математический анализ, можно показать, что все целые числа больше 28123 могут быть записаны как сумма двух избыточных чисел. Эта граница не может быть уменьшена дальнейшим анализом, даже несмотря на то, что наибольшее число, которое не может быть записано как сумма двух избыточных чисел, меньше этой границы.
    /// Найдите сумму всех положительных чисел, которые не могут быть записаны как сумма двух избыточных чисел.
    /// </summary>
    class Program
    {
        private const int MaxValue = 28123;

        static void Main(string[] args)
        {
            BigInteger Result = 0;
            
            var resultArray = new bool[MaxValue * 2 + 1];
            for (var n = 1; n <= MaxValue; n++)
            {
                resultArray[n] = false;
            }

            var Abundant = new List<BigInteger>();

            for (var n = 1; n <= MaxValue; n++)
            {
                var value = new LocalMath(n);

                if (value.IsAbundant)
                {
                    Abundant.Add(n);
                }
            }

            foreach (var x in Abundant)
            {
                foreach (var y in Abundant)
                {
                    var index = x + y;
                    resultArray[(int)index] = true;
                }
            }
            
            for (var n = 1; n <= MaxValue; n++)
            {
                if (!resultArray[n])
                {
                    Result = Result + n;
                }
            }

            Console.WriteLine("Result: " + Result);
            Console.ReadLine();
        }
    }
}