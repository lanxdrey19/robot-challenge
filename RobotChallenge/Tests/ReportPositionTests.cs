using RobotChallenge;

namespace Tests

{
    [TestClass]
    public class ReportPositionTests
    {
        [TestMethod]
        public void ReportPosition_ShouldReturnMessage_WhenRobotIsNotOnTheGrid()
        {
            // Arrange
            int[] initialGrid = { 0, 0, 0, 0 }; 
            Game game = new Game(initialGrid); 

            // Act
            string result = game.ReportPosition();

            // Assert
            string expectedMessage = "The robot is not on the grid.\n";
            Assert.AreEqual(expectedMessage, result);

        }

        [TestMethod]
        public void ReportPosition_ShouldReturnMessage_WhenRobotIsOnTheGrid()
        {
            // Arrange
            int[] initialGrid = { 0, 1, 0, 0 }; 
            Game game = new Game(initialGrid); 

            // Act
            string result = game.ReportPosition();

            // Assert
            string expectedMessage = "The robot is at position: 2\n"; 
            Assert.AreEqual(expectedMessage, result);

        }
    }
}