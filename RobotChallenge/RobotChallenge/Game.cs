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
        private int _currentPosition;
        public Game(int[] grid, int currentPosition)
        {
            _grid = grid;
            _currentPosition = currentPosition;
        }

        public void MoveRobot(int newPosition)
        {
            if (_currentPosition != -1)
            {
                _grid[_currentPosition] = 0;
            }

            _grid[newPosition] = 1;
            _currentPosition = newPosition;
        }

        public void DisplayGrid()
        {
            Console.WriteLine("Current Grid:");

            for (int i = 0; i < _grid.Length; i++)
            {
                string displayValue = _grid[i] == 1 ? "X" : (i + 1).ToString();
                Console.Write(displayValue + " ");

                if (i % 2 == 1)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        public void ReportPosition()
        {
            int index = Array.IndexOf(_grid, 1);

            if (index == -1)
            {
                Console.WriteLine("The robot is not on the grid.");
            }
            else
            {
                int position = index + 1;

                Console.WriteLine($"The robot is at position: {position}");
            }
            Console.WriteLine();
        }
    }
}
