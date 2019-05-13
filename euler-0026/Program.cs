using System;
using System.Numerics;
using System.Threading.Tasks;

namespace euler_0026
{
	class Program
	{
		private static string _rightPart;

		private static string _longestPart = "";

		static void Main(string[] args)
		{
			for (var d = 1; d < 1000; d++)
			{
				decimal result = 1 / (decimal)d;
				var numbers = result.ToString().Split('.');
				if (numbers.Length > 1)
				{
					_rightPart = numbers[1];

					Console.WriteLine("Value: " + d);
					Parallel.For(0, _rightPart.Length, Check);

					Console.WriteLine("Right part: " + _rightPart);
				}
			}

			Console.ReadLine();
		}

		private static void Check(int n)
		{
			var localLongest = "";

			for (var t = 0; t < _rightPart.Length - n; t++)
			{
				var substr = _rightPart.Substring(0, t);
				if (_rightPart.Length > (substr.Length * 2) + n)
				{
					var part = _rightPart.Substring(n, substr.Length * 2);
					if (substr + substr == part)
					{
						if (substr.Length > localLongest.Length)
						{
							var needToReplace = true;
							var sintizedString = substr;
							for (var c = 2; c < Math.Floor((decimal)(_rightPart.Length / substr.Length)); c++)
							{
								sintizedString = sintizedString + substr;
								if (localLongest == sintizedString)
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

			if (_longestPart.Length < localLongest.Length)
			{
				_longestPart = localLongest;
			}
		}
	}
}
