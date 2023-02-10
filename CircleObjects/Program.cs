using CircleObjects;

Console.WriteLine("Welcome to the Circle Tester");
int counter = 1;
for (int i = 0; i < counter; i++)
{
    bool playagain = true;
    while (playagain)
    {
        Console.Write("Enter radius: ");
        try
        {
            double userRadius = double.Parse(Console.ReadLine());
            Circle userCircle = new(userRadius);

            Console.WriteLine($" Circumference: {userCircle.CalculateCircumference()}");
            Console.WriteLine($" Area: {userCircle.CalculateArea()}");
            Console.Write("Continue? (y/n): ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                counter = counter + 1;
            }
            else
            {
                playagain = false;
                Console.WriteLine($"Goodbye. You created {counter} Circle object(s).");
                counter = 0;
            }
        }
        catch
        {
            Console.Write("Invalid data, try again? (y/n): ");
            string answer = Console.ReadLine();
            if (answer == "y") { } else { playagain = false; }
        }
    }
}