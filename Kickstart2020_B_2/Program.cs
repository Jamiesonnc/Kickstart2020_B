using System;
using System.Linq;
using System.Collections.Generic;

namespace Kickstart2020_B_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int Ti = 1; Ti <= T; Ti++)
            {
                string dataIn = Console.ReadLine();
                string[] splitA = dataIn.Split(' ');
                int N = int.Parse(splitA[0]);
                int D = int.Parse(splitA[1]);
                dataIn = Console.ReadLine();
                string[] splitB = dataIn.Split(' ');
                int[] data = Array.ConvertAll(splitB, s => int.Parse(s));
                int c = data.Max();
                long res = 1;
                int a = 2;
                List<int> indexes = new List<int>();
                while (a < c)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] % a == 0)
                        {
                            indexes.Add(i);
                        }
                    }

                    if (indexes.Count >= 2)
                    {
                        for (int j = 0; j < indexes.Count; j++)
                        {
                            data[(int)indexes[j]] = data[(int)indexes[j]] / a;
                        }
                        res = res * a;
                    }
                    else
                    {
                        a++;
                    }
                }

                for (int k = 0; k < data.Length; k++)
                {
                    res = res * data[k];
                }
                int X = Ti;
                int Y = (int)res;
                decimal Z = Math.Floor(D / Y);

                Console.WriteLine($"Case #{X}: {Y}");
            }
        }
    }
}
