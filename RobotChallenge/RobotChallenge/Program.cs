using RobotChallenge;

bool exit = false;

while (!exit)
{
    RunIntroSession();
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RunGameSession();
            break;
        case "2":
            RunTestScenarioSession();
            break;
        case "3":
            Console.WriteLine("Exiting the robot challenge. Goodbye!");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            break;
    }
}
        

void RunIntroSession()
{
    Console.WriteLine("Welcome to the Robot Challenge!");
    Console.WriteLine("Please choose a session:");
    Console.WriteLine("1. Play Game");
    Console.WriteLine("2. Run Test Scenario");
    Console.WriteLine("3. Exit Robot Challenge");
    Console.Write("Enter your choice: ");
}

void RunGameSession()
{

    Console.WriteLine("Game Session - Type 'q' to exit the game.");

    Game game = new Game();

    bool playing = true;

    game.ReportPosition();
    game.DisplayGrid();

    while (playing)
    {
        Console.WriteLine("Choose a position (1-4) to move the robot to, or type 'q' to exit:");
        string input = Console.ReadLine();

        if (input?.ToLower() == "q")
        {
            Console.WriteLine("exiting game...");
            playing = false;
        }
        else
        {
            game.PlayGame(input);
        }
    }
}

void RunTestScenarioSession()
{
    Console.WriteLine("Test Scenario");
    Console.WriteLine("Running test scenario...");

    Game game = new Game();

    game.ReportPosition();
    game.DisplayGrid();

    Console.WriteLine("Moving robot to position 2...");
    game.PlayGame("2");

    Console.WriteLine("Moving robot to position 3...");
    game.PlayGame("3");

    Console.WriteLine("Attempting an invalid move to position 5...");
    game.PlayGame("5");

    Console.WriteLine("Attempting an invalid move to position hello...");
    game.PlayGame("hello");

    Console.WriteLine("Moving robot to position 1...");
    game.PlayGame("1");

    Console.WriteLine("Moving robot to position 4...");
    game.PlayGame("4");

    Console.WriteLine("Test scenario completed.");
    Console.WriteLine("Press any key to return to the main menu.");

    Console.ReadKey();
    Console.WriteLine("");
}


