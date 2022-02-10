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
            char[] board = new char[10];

            for (int i = 1; i <10; i++)
            {
                board[i] = ' ';
            }
        }
        public void Player()
        {
            Console.WriteLine("Enter your letter X/O ");
            char play=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Player choosen charecter is :\n"+play);

        }
        public void Computer()
        {
            Random comp = new Random();
            int choice=comp.Next(0, 2);
            if (choice < 1)
            {
                Console.WriteLine("Cpmputer choosen charecter is :");
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("Computer choosen charecter is :");
                Console.WriteLine("O");
            }
        }
    }
}
