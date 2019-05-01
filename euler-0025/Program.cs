using System;
using System.Numerics;

namespace euler_0025
{
	class Program
	{
		private static BigInteger currentValue = 1;
		private static BigInteger previousValue = 0;
		private static BigInteger Index = 1;

		static void Main(string[] args)
		{
			var currentLength = currentValue.ToString().Length;
			while (currentLength < 1000)
			{
				var indx = Fib();
				currentLength = currentValue.ToString().Length;
			}
			Console.WriteLine("Result is " + Index);
			Console.WriteLine("Hello World!");
		}

		private static BigInteger Fib()
		{
			var tempValue = currentValue;
			currentValue = currentValue + previousValue;
			previousValue = tempValue;
			Index++;

			return Index;
		}
	}
}
