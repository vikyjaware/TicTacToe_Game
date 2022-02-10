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
                Console.WriteLine("Enter your letter X/O \n Enter 1 for X \n Enter 2 for O \n Enter 0 to exit ");
                int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Player choosen charecter is : X \n");
                    Console.WriteLine("Computer choice is : O " );
                    break;

                case 2:
                    Console.WriteLine("Player choosen charecter is : O \n");
                    Console.WriteLine("Computer choice is : X ");
                    break;

                default:
                    Console.WriteLine("Please select correct option");
                    break;
            }
        }
    }
}
