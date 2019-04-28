using System;
using System.Collections.Generic;
using System.IO;
using euler_0067;

namespace euler_0022
{
    /// <summary>
    /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
    /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
    /// What is the total of all the name scores in the file?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Name> names = new List<Name>();
            string filename = "p022_names.txt";

            long Result = 0;

            using (StreamReader sr = new StreamReader(filename))
            {
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadToEnd().Replace('\n', ' ');
                var Values = line.Split(',');

                var index = 1;

                Array.Sort(Values);

                foreach (var value in Values)
                {
                    names.Add(new Name()
                    {
                        Index = index,
                        Title = value
                    });

                    index++;
                }

                foreach (var n in names)
                {
                    Result = Result + (n.Index * n.Value);
                }
            }

            Console.WriteLine("Result is " + Result);
            Console.ReadLine();
        }
    }
}