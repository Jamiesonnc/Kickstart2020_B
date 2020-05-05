using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kickstart2020_B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int Ti = 1; Ti <= T; Ti++)
            {
                int N = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                string[] split = input.Split(' ');
                int X = Ti;
                int Y = 0;
                for (int Ni = 1; Ni < N; Ni++)
                {
                    if (Ni > 1 && Ni < N)
                    {
                        int I = int.Parse(split[Ni-1]);
                        int Ip = int.Parse(split[Ni - 2]);
                        int In = int.Parse(split[Ni]);
                        if (I>Ip && I>In)
                        {
                            Y += 1;
                        }
                    }
                }
                Console.WriteLine($"Case #{X}: {Y}");
            }
        }
    }
}
