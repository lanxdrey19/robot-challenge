using RobotChallenge;

namespace Tests

{
    [TestClass]
    public class MoveRobotTests
    {
        [TestMethod]
        public void MoveRobot_ShouldUpdateGridAndReturnNewPosition_WhenMovingToNewPosition()
        {
            // Arrange
            int[] initialGrid = { 0, 0, 0, 0 };
            Game game = new Game(initialGrid);
            int newPosition = 2;

            // Act
            int resultPosition = game.MoveRobot(newPosition);

            // Assert
            Assert.AreEqual(newPosition, resultPosition);
        }

        [TestMethod]
        public void MoveRobot_ShouldUpdateGridAndReturnNewPosition_WhenMovingToNextPosition()
        {
            // Arrange
            int[] initialGrid = { 0, 1, 0, 0 };
            Game game = new Game(initialGrid);
            int newPosition = 3;

            // Act
            int resultPosition = game.MoveRobot(newPosition);

            // Assert
            Assert.AreEqual(newPosition, resultPosition);
        }

        [TestMethod]
        public void MoveRobot_ShouldUpdateGridAndReturnNewPosition_WhenRobotIsMovedToSamePosition()
        {
            // Arrange
            int[] initialGrid = { 0, 1, 0, 0 };
            Game game = new Game(initialGrid);
            int newPosition = 2;

            // Act
            int resultPosition = game.MoveRobot(newPosition);

            // Assert
            Assert.AreEqual(newPosition, resultPosition);
        }

        [TestMethod]
        public void MoveRobot_ThrowException_WhenRobotIsMovedAnInvalidPosition()
        {
            // Arrange
            int[] initialGrid = { 0, 1, 0, 0 };
            Game game = new Game(initialGrid);
            int newPosition = 10;

            // Act
            // Assert 
            var exception = Assert.ThrowsException<IndexOutOfRangeException>(() => game.MoveRobot(newPosition));

        }
    }
}