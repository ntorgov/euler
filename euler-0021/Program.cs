using System;

namespace euler_0021
{
	class Program
	{
		static void Main(string[] args)
		{
			var final = 0;

			for (var initial = 1; initial < 10000; initial++)
			{

				var result1 = Devisors(initial);
				var result2 = Devisors(result1);

				if (result2 == initial && result1!=result2)
				{
					Console.WriteLine(result1 + " and " + result2);
					final = final + result1 + result2;
				}
			}

			Console.WriteLine("Result: " + (final / 2));
			Console.ReadLine();
		}

		static int Devisors(int Number)
		{
			var result = 0;

			for (var n = 1; n < Number; n++)
			{
				if (Number % n == 0)
				{
					result = result + n;
				}
			}

			return result;
		}
	}
}
