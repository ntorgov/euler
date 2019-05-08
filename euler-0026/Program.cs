using System;
using System.Numerics;
using System.Threading.Tasks;

namespace euler_0026
{
	class Program
	{
		private static string rightPart;

		private static string longestPart = "";

		static void Main(string[] args)
		{
			for (var d = 1; d < 1000; d++)
			{
				decimal result = 1 / (decimal)d;
				var numbers = result.ToString().Split('.');
				if (numbers.Length > 1)
				{
					rightPart = numbers[1];

					Console.WriteLine("Value: " + d);
					Parallel.For(0, rightPart.Length, Check);

					Console.WriteLine("Right part: " + rightPart);
				}
			}

			Console.ReadLine();
		}

		private static void Check(int n)
		{
			var localLongest = "";

			for (var t = 0; t < rightPart.Length - n; t++)
			{
				var substr = rightPart.Substring(0, t);
				if (rightPart.Length > (substr.Length * 2) + n)
				{
					var part = rightPart.Substring(n, substr.Length * 2);
					if (substr + substr == part)
					{
						if (substr.Length > localLongest.Length)
						{
							var needToReplace = true;
							var syntizedString = substr;
							for (var c = 2; c < Math.Floor((decimal)(rightPart.Length / substr.Length)); c++)
							{
								syntizedString = syntizedString + substr;
								if (localLongest == syntizedString)
								{
									needToReplace = false;
								}
							}
							if (needToReplace == true)
							{
								localLongest = substr;
							}
						}
					}
				}
			}

			if (longestPart.Length < localLongest.Length)
			{
				longestPart = localLongest;
			}
		}
	}
}
