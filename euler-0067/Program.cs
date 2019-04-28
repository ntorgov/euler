using System;
using System.IO;

namespace euler_0067
{
	class Program
	{
		static void Main(string[] args)
		{
			long[,] inputTriangle = new long[100, 100];

			for (var x = 0; x < 100; x++)
			{
				for (var y = 0; y < 100; y++)
				{
					inputTriangle[x, y] = 0;
				}
			}
			string filename = "../../../p067_triangle.txt";

			using (StreamReader sr = new StreamReader(filename))
			{
				// Read the stream to a string, and write the string to the console.
				String line = sr.ReadToEnd().Replace('\n', ' ');
				var values = line.Split(' ');
				var x = 0;
				var y = 0;
				foreach (var value in values)
				{
					if (value != "")
					{
						var intValue = Int64.Parse(value);
						inputTriangle[x, y] = intValue;
						x++;
						if (x > y)
						{
							x = 0;
							y++;
						}
					}
				}
				Console.WriteLine(line);
			}

			int lines = inputTriangle.GetLength(0);
			int yLength = inputTriangle.GetLength(1);

			for (var y = yLength - 1; y >= 0; y--)
			{
				for (var x = 0; x <= (inputTriangle.GetLength(0) - 1); x++)
				{
					if (y - (yLength - 1) == 0)
					{
						continue;
					}

					if (inputTriangle[x, y] == 0)
					{
						continue;
					}

					var nearestRight = x + 1;
					var nearestLeft = x;

					var neightborMax = Math.Max(inputTriangle[nearestLeft, y + 1], inputTriangle[nearestRight, y + 1]);
					inputTriangle[x, y] = inputTriangle[x, y] + neightborMax;

				}
			}

			Console.WriteLine("Result: " + inputTriangle[0, 0]);
			Console.ReadLine();
		}
	}
}
