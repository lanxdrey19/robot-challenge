using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotChallenge;

namespace Tests
{
    public class DisplayGridTests
    {
        [TestClass]
        public class GameTests
        {
            [TestMethod]
            public void DisplayGrid_ShouldDisplayGrid_WhenRobotIsNotOnTheGrid()
            {
                // Arrange
                int[] initialGrid = { 0, 0, 0, 0 }; 
                Game game = new Game(initialGrid);

                // Act
                string result = game.DisplayGrid();

                // Assert
                string expectedMessage = "Current Grid:\n1 2 \n3 4 \n"; 
                Assert.AreEqual(expectedMessage, result);
            }

            [TestMethod]
            public void DisplayGrid_ShouldDisplayGrid_WhenRobotIsOnTheGrid()
            {
                // Arrange
                int[] initialGrid = { 0, 1, 0, 0 }; 
                Game game = new Game(initialGrid);

                // Act
                string result = game.DisplayGrid();

                // Assert
                string expectedMessage = "Current Grid:\n1 X \n3 4 \n"; 
                Assert.AreEqual(expectedMessage, result);
            }

            [TestMethod]
            public void DisplayGrid_ShouldDisplayGrid_WhenRobotIsAtDifferentPositions()
            {
                // Arrange
                int[] initialGrid = { 0, 0, 1, 0 }; 
                Game game = new Game(initialGrid);

                // Act
                string result = game.DisplayGrid();

                // Assert
                string expectedMessage = "Current Grid:\n1 2 \nX 4 \n";
                Assert.AreEqual(expectedMessage, result);
            }
        }
    }
}
