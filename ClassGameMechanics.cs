using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class ClassGameMechanics
    {
        char [,] map;
        byte srow = 0;
        byte scol = 0;
        int guessesCount;

        public ClassGameMechanics()
        {

        }

        public void MapMaker(int row, int column)
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

        public char PrintMap()
        {
            char u = 'u';
            char o = 'o';
            byte count = 0;

            for(int i = 0; i < map.GetLength(1); i++)
            {
                if(count == 10)
                {
                    count = 0;
                }
                u = (char)count;
                count++;
            }

            for(int j = 0; j < map.GetLength(0); j++)
            {
                u = ((char)(j + ((j < 10) ? ' ' : ' ')));
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    u = map[j, k];
                }
            }
            return u;
        }
    }
}
