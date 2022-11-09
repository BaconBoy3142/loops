using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static bool gameOver;
        static int xPlayer;
        static int yPlayer;
        static void Main(string[] args)
        {

            gameOver = false;

            xPlayer = 0;
            yPlayer = 0;


            while (gameOver == false)
            {
                PlayerDraw();
                PlayerUpdate();
            }

            Console.WriteLine("GAME OVER!");




        }

        static void PlayerDraw()
        {
            Console.Clear();
            Console.SetCursorPosition(xPlayer, yPlayer);
            Console.Write('0');
        }

        static void PlayerUpdate()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.W)
            {
                yPlayer -= 1;
            }
            if (input.Key == ConsoleKey.S)
            {
                yPlayer += 1;
            }
            if (input.Key == ConsoleKey.A)
            {
                xPlayer -= 1;
            }
            if (input.Key == ConsoleKey.D)
            {
                xPlayer += 1;
            }
            if(input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
        }

    }
}
