using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotChallenge
{
    public class Game
    {
        private int[] _grid;
        public Game(int[] grid)
        {
            _grid = grid;
        }

        public int MoveRobot(int newPosition)
        {

            int index = Array.IndexOf(_grid, 1);
            if (index != -1)
            {
                _grid[index] = 0;
            }

            _grid[newPosition] = 1;

            return newPosition;
        }

        public string DisplayGrid()
        {
            StringBuilder gridDisplay = new StringBuilder("Current Grid:\n");

            for (int i = 0; i < _grid.Length; i++)
            {
                string displayValue = _grid[i] == 1 ? "X" : (i + 1).ToString();
                gridDisplay.Append(displayValue + " ");

                if (i % 2 == 1)
                {
                    gridDisplay.Append("\n");
                }
            }

            Console.WriteLine(gridDisplay.ToString());
            return gridDisplay.ToString(); 
        }

        public string ReportPosition()
        {
            int index = Array.IndexOf(_grid, 1);
            string finalMessage = "The robot is not on the grid.\n";

            if (index == -1)
            {
                Console.WriteLine(finalMessage);
                return finalMessage;
            }

            int position = index + 1;
            finalMessage = $"The robot is at position: {position}\n";
            Console.WriteLine(finalMessage);
            return finalMessage;

        }
    }
}
