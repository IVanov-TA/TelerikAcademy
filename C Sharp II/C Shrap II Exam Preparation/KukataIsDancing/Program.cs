

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dancing
{
    class Program
    {
        static void Main()
        {
            var colors = new Dictionary<char, string>();
            colors.Add('R', "RED");
            colors.Add('G', "GREEN");
            colors.Add('B', "BLUE");
            char[,] danceFloor = {
                                        {'R', 'B', 'R'},
                                        {'B', 'G', 'B'},
                                        {'R', 'B', 'R'}
                };
            StringBuilder moves = new StringBuilder();
            char current = danceFloor[1, 1];
            int dances = int.Parse(Console.ReadLine());
            for (int i = 0; i < dances; i++)
            {
                string dance = Console.ReadLine();
                int row = 1;
                int col = 1;
                bool left = false;
                bool right = false;
                bool up = true;
                bool down = false;
                for (int j = 0; j < dance.Length; j++)
                {
                    switch (dance[j])
                    {
                        case 'W':
                            {
                                if (left)
                                {
                                    if (col > 0)
                                        col--;
                                    else
                                        col = 2;
                                }
                                if (up)
                                {
                                    if (row > 0)
                                        row--;
                                    else
                                        row = 2;
                                }
                                if (down)
                                {
                                    if (row < 2)
                                        row++;
                                    else
                                        row = 0;
                                }
                                if (right)
                                {
                                    if (col < 2)
                                        col++;
                                    else
                                        col = 0;
                                }
                                break;
                            }
                        case 'L':
                            {
                                if (up)
                                {
                                    left = true;
                                    right = false;
                                    down = false;
                                    up = false;
                                    break;
                                }

                                if (down)
                                {
                                    right = true;
                                    up = false;
                                    left = false;
                                    down = false;
                                    break;
                                }

                                if (left)
                                {
                                    down = true;
                                    up = false;
                                    left = false;
                                    right = false;
                                    break;
                                }

                                if (right)
                                {
                                    up = true;
                                    down = false;
                                    left = false;
                                    right = false;
                                }
                                break;
                            }
                        case 'R':
                            {
                                if (up)
                                {
                                    right = true;
                                    up = false;
                                    left = false;
                                    down = false;
                                    break;
                                }

                                if (down)
                                {
                                    left = true;
                                    right = false;
                                    up = false;
                                    down = false;
                                    break;
                                }

                                if (left)
                                {
                                    up = true;
                                    down = false;
                                    left = false;
                                    right = false;
                                    break;
                                }

                                if (right)
                                {
                                    down = true;
                                    up = false;
                                    left = false;
                                    right = false;
                                    break;
                                }
                                break;
                            }
                    }

                }
                // after every dance
                moves.Append(danceFloor[row, col]);
            }
            // after all dances
            for (int k = 0; k < moves.Length; k++)
            {
                Console.WriteLine(colors[moves[k]]);
            }
        }
    }
}

