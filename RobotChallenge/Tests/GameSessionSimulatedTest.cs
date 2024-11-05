using RobotChallenge;

namespace Tests

{
    [TestClass]
    public class GameSessionSimulatedTest
    {
        [TestMethod]
        public void PlayGame_SimulatedPlayWithVariousInputs_ShouldDisplayCorrectOutput()
        {
            // Arrange
            GameSession gameSession = new GameSession();
            using StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            gameSession.PlayGame("hello");
            gameSession.PlayGame("2");      
            gameSession.PlayGame("5");      
            gameSession.PlayGame("3");      
            gameSession.PlayGame("0");      
            gameSession.PlayGame("1");      
            gameSession.PlayGame("4");      

            // Assert
            string expectedOutput =
                // First input "hello" 
                "hello is an invalid move. Enter a number between 1 and 4.\n\n" +
                "The robot is not on the grid.\n\n" +
                "Current Grid:\n1 2 \n3 4 \n\n" +

                // Second input "2" 
                "2 is a valid move.\n\n" +
                "The robot is at position: 2\n\n" +
                "Current Grid:\n1 X \n3 4 \n\n" +

                // Third input "5" 
                "5 is an invalid move. Enter a number between 1 and 4.\n\n" +
                "The robot is at position: 2\n\n" +
                "Current Grid:\n1 X \n3 4 \n\n" +

                // Fourth input "3" 
                "3 is a valid move.\n\n" +
                "The robot is at position: 3\n\n" +
                "Current Grid:\n1 2 \nX 4 \n\n" +

                // Fifth input "0" 
                "0 is an invalid move. Enter a number between 1 and 4.\n\n" +
                "The robot is at position: 3\n\n" +
                "Current Grid:\n1 2 \nX 4 \n\n" +

                // Sixth input "1" 
                "1 is a valid move.\n\n" +
                "The robot is at position: 1\n\n" +
                "Current Grid:\nX 2 \n3 4 \n\n" +

                // Seventh input "4" 
                "4 is a valid move.\n\n" +
                "The robot is at position: 4\n\n" +
                "Current Grid:\n1 2 \n3 X \n\n";

            Assert.AreEqual(expectedOutput.Replace("\r\n", "\n").Trim(), stringWriter.ToString().Replace("\r\n", "\n").Trim());
        }
    }
}