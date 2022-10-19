//Jovann Contreras
//Date 10/19/2022
//Having the user choose a level of difficulty, Guess the number and keep track of how many times they guessed

Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")

{
    Console.WriteLine("Welcome to the Guess It Game!!");

    bool numGuess = false;
    int guess = 0;
    int num;
    int numOfGuesses = 0;
    bool validLvlPick = false;

    while (!validLvlPick)
    {
        Console.Write("Choose Easy, Medium or Hard to start: ");
        String lvlPick = Console.ReadLine().ToLower();

        if (lvlPick == "easy")
        {

            int min = 1;
            int max = 10;
            Random rnd = new Random();
            num = rnd.Next(min, max + 1);


            while (guess != num)
            {
                Console.WriteLine("Guess a number between 1-10");

                numGuess = Int32.TryParse(Console.ReadLine(), out guess);
                Console.WriteLine($"Guess: {guess}");

                if (guess > num)
                {
                    Console.WriteLine($"{guess} is too high");
                }
                else if (guess < num)
                {
                    Console.WriteLine($"{guess} is too low");
                }

                numOfGuesses++;

            }

            validLvlPick = true;
            Console.WriteLine($"Number: {num}");
            Console.WriteLine($"Guesses: {numOfGuesses}");
        }

        else if (lvlPick == "medium")
        {
            int min = 1;
            int max = 50;
            Random rnd = new Random();
            num = rnd.Next(min, max + 1);

            while (guess != num)
            {
                Console.WriteLine("Guess a number between 1-50");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Guess: {guess}");
                if (guess > num)
                {
                    Console.WriteLine($"{guess} is too high");
                }
                else if (guess < num)
                {
                    Console.WriteLine($"{guess} is too low");
                }
                numOfGuesses++;
            }

            validLvlPick = true;
            Console.WriteLine($"Number: {num}");
            Console.WriteLine($"Guesses: {numOfGuesses}");
        }
        else if (lvlPick == "hard")
        {
            int min = 1;
            int max = 100;
            Random rnd = new Random();
            num = rnd.Next(min, max + 1);



            while (guess != num)
            {
                Console.WriteLine("Guess a number between 1-100");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Guess: {guess}");

                if (guess > num)
                {
                    Console.WriteLine($"{guess} is too high");
                }
                else if (guess < num)
                {
                    Console.WriteLine($"{guess} is too low");
                }
                numOfGuesses++;
            }

            validLvlPick = true;
            Console.WriteLine($"Number: {num}");
            Console.WriteLine($"Guesses: {numOfGuesses}");
        }
        else
        {
            Console.WriteLine("Not a valid pick");
            validLvlPick = false;
        }


    }

    Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == playAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid Input");
            playAgainInput = "invalid";
        }


    }

}
