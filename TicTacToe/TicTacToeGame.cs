using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public void Board()
        {
            char[] board = new char[9];

            for (int i = 1; i <= 9; i++)
            {
                board[i] = ' ';
            }
        }
    }
}
