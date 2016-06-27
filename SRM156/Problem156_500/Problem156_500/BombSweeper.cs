using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem156_500
{
    public class BombSweeper
    {
        public double winPercentage(string[] board)
        {
            double bCount = 0;
            double safeCount = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.First().Length; j++)
                {
                    if (board[i][j] == 'B')
                        bCount++;

                    else
                    {
                        if(IsInBBorder(i,j, board.Length, board.First().Length, board))
                        {
                            safeCount++;
                        }
                    }
                }
            }
            return safeCount*100.0/(safeCount + bCount);

        }
        private bool IsInBBorder(int i, int j, int height, int witdh, string[] board)
        {
            return GetIsInBBorder(i - 1, j - 1, height, witdh, board) &&
                   GetIsInBBorder(i - 1, j, height, witdh, board) &&
                   GetIsInBBorder(i - 1, j + 1, height, witdh, board) &&
                   GetIsInBBorder(i, j - 1, height, witdh, board) &&
                   GetIsInBBorder(i, j + 1, height, witdh, board) &&
                   GetIsInBBorder(i + 1, j - 1, height, witdh, board) &&
                   GetIsInBBorder(i + 1, j, height, witdh, board) &&
                   GetIsInBBorder(i + 1, j + 1, height, witdh, board);
        }
        private bool GetIsInBBorder(int i, int j, int height, int witdh, string[] board)
        {
            if (i >= 0 && i <= height - 1)
            {
                if (j >= 0 && j <= witdh - 1)
                {
                    return board[i][j] != 'B';
                }
            }

            return true;
        }
    }
}
