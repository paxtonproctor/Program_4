using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    internal class ClassGameMechanics
    {
        char [,] map;
        byte srow = 0;
        byte scol = 0;
        int guessesCount = 0;
        string printmap = "";

        public ClassGameMechanics(int row, int column)
        {
            map = new char[row, column];

            Random rand = new Random();
            srow = (byte)rand.Next(0, map.GetLength(0) - 1);
            scol = (byte)rand.Next(0, map.GetLength(1) - 1);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = '~';
                }
            }
            guessesCount = 0;
        }

        public string PrintMap()
        {
            byte count = 0;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (count == 15)
                {
                    count = 0;
                }
                printmap += count.ToString() + " ";
                count++;
            }

            printmap += "\n";
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    printmap += map[j, k].ToString();
                    printmap += " ";
                }
                printmap += (j + ((j < 15) ? " " : " ")).ToString() + "\n";
            }
            return printmap;
        }

        public bool EvaluateGuess(int rowGuess, int columnGuess)
        {
            if ((rowGuess == srow) && (columnGuess == scol))
            {
                map[rowGuess, columnGuess] = 'I';
            }
            else if (guessesCount % 2 == 0)
            {
                if (rowGuess < srow)
                {
                    map[rowGuess, columnGuess] = 'S';
                }
                else if (rowGuess > srow)
                {
                    map[rowGuess, columnGuess] = 'N';
                }
                else
                {
                    map[rowGuess, columnGuess] = 'R';
                }
            }
            else
            {
                if (columnGuess < scol)
                {
                    map[rowGuess, columnGuess] = 'E';
                }
                else if (columnGuess > scol)
                {
                    map[rowGuess, columnGuess] = 'W';
                }
                else
                {
                    map[rowGuess, columnGuess] = 'C';
                }

            }
        }
    }
}
