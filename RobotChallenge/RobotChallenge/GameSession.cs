using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotChallenge
{
    public class GameSession
    {
        private Game _game;
        public GameSession()
        {
            int[] grid = { 0, 0, 0, 0 };
            _game = new Game(grid);
        }
        

        public void PlayGame(string input)
        {
            if (int.TryParse(input, out int newPosition) && newPosition >= 1 && newPosition <= 4)
            {
                Console.WriteLine($"{newPosition} is a valid move.");
                _game.MoveRobot(newPosition - 1);
           
            }
            else
            {
                Console.WriteLine($"{input} is an invalid move. Enter a number between 1 and 4.");
            }
            Console.WriteLine();

            _game.ReportPosition();
            _game.DisplayGrid();
        }

   

    }
}
