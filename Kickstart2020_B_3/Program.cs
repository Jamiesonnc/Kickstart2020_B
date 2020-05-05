using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kickstart2020_B_3
{
    class Program
    {

        const int Rows = 1000000000;
        const int Columnds = 1000000000;

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int Ti = 1; Ti <= T; Ti++)
            {
                int x = Ti;
                int[] coords = { 1, 1 };
                string line = Console.ReadLine();
                line = line.Replace(" ", "");
                char[] chars = line.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    switch (chars[i])
                    {
                        case 'S':
                            coords[1] += 1;
                            break;
                        case 'W':
                            coords[0] -= 1;
                            break;
                        case 'E':
                            coords[0] += 1;
                            break;
                        case 'N':
                            coords[1] -= 1;
                            break;
                        case '2':
                            coords = MultiMove(2, MultiBuild(chars, i, out i), coords);
                            break;
                        case '3':
                            coords = MultiMove(3, MultiBuild(chars, i, out i), coords);
                            break;
                        case '4':
                            coords = MultiMove(4, MultiBuild(chars, i, out i), coords);
                            break;
                        case '5':
                            coords = MultiMove(5, MultiBuild(chars, i, out i), coords);
                            break;
                        case '6':
                            coords = MultiMove(6, MultiBuild(chars, i, out i), coords);
                            break;
                        case '7':
                            coords = MultiMove(7, MultiBuild(chars, i, out i), coords);
                            break;
                        case '8':
                            coords = MultiMove(8, MultiBuild(chars, i, out i), coords);
                            break;
                        case '9':
                            coords = MultiMove(9, MultiBuild(chars, i, out i), coords);
                            break;
                        default:
                            break;
                    }
                    if (coords[1] >= Rows)
                    {
                        coords[1] = 0;
                    }
                    else if (coords[1] <= 0)
                    {
                        coords[1] = Rows;
                    }
                    if (coords[0] >= Columnds)
                    {
                        coords[0] = 0;
                    }
                    else if (coords[0] <= 0)
                    {
                        coords[0] = Columnds;
                    }
                }
                Console.WriteLine($"Case #{x}: {coords[0]} {coords[1]}");
            }
        }
        public static char[] MultiBuild(char[] chars, int iPos, out int pos)
        {
            List<char> ret = new List<char>();
            int outi = iPos;
            for (int i = iPos; i < chars.Length; i++)
            {
                outi = i;
                if (chars[i].Equals(')'))
                {
                    break;
                }
                else if (chars[i].Equals('('))
                {

                }
                else
                {
                    ret.Add(chars[i]);
                }

            }
            pos = outi;
            return ret.ToArray();
        }
        public static int[] MultiMove(int X, char[] chars, int[] coords)
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    switch (chars[j])
                    {
                        case 'S':
                            coords[1] += 1;
                            break;
                        case 'W':
                            coords[0] -= 1;
                            break;
                        case 'E':
                            coords[0] += 1;
                            break;
                        case 'N':
                            coords[1] -= 1;
                            break;
                        default:
                            break;
                    }
                    if (coords[1] >= Rows)
                    {
                        coords[1] = 0;
                    }
                    else if (coords[1] <= 0)
                    {
                        coords[1] = Rows;
                    }
                    if (coords[0] >= Columnds)
                    {
                        coords[0] = 0;
                    }
                    else if (coords[0] <= 0)
                    {
                        coords[0] = Columnds;
                    }
                }
            }
            return coords;
            
        }
    }
            
}
