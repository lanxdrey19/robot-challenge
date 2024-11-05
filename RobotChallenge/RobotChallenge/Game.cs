using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotChallenge
{
    public class Game
    {
        private int[] _grid = { 0, 0, 0, 0 };
        private int _currentPosition = -1;

        public void PlaceRobot()
        {
            int position;
            bool validPlacement = false;

            while (!validPlacement)
            {
                Console.WriteLine("Choose a starting position (1-4) to place the robot:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out position) && position >= 1 && position <= 4)
                {
                    position--;
                    _grid[position] = 1;
                    _currentPosition = position;
                    validPlacement = true;
                }
                else
                {
                    Console.WriteLine("Invalid position. Please enter a number between 1 and 4.");
                }
                Console.WriteLine();
            }
        }

        public void PlayGame(string input)
        {
            if (int.TryParse(input, out int newPosition) && newPosition >= 1 && newPosition <= 4)
            {
                Console.WriteLine($"{newPosition} is a valid move.");
                MoveRobot(newPosition - 1);
           
            }
            else
            {
                Console.WriteLine($"{input} is an invalid move. Enter a number between 1 and 4.");
            }
            Console.WriteLine();

            ReportPosition();
            DisplayGrid();
        }

        private void MoveRobot(int newPosition)
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
