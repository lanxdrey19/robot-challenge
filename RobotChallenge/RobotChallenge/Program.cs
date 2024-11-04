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

    bool playing = true;
    while (playing)
    {
        Console.WriteLine("You're playing the game! Type 'q' to return to the main menu.");
        string input = Console.ReadLine();

        if (input?.ToLower() == "q")
        {
            Console.WriteLine("exiting game...");
            playing = false;
        }
        else
        {
            Console.WriteLine("Game being played...");
        }
    }
}

void RunTestScenarioSession()
{
    Console.WriteLine("Test Scenario");
    Console.WriteLine("Running test scenarios...");

    Console.WriteLine("Test scenario completed.");
    Console.WriteLine("Press any key to return to the main menu.");

    Console.ReadKey();
    Console.WriteLine("");
}


