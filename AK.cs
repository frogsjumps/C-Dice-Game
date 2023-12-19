Random numberGen = new Random();

int roll = 0;
int attempts = 0;

Console.WriteLine("Press enter to roll the die");

while(roll != 6) {
    Console.ReadKey();

    roll = numberGen.Next(1, 7);
    Console.WriteLine("You Rolled: " + roll);
    attempts++;
}   
Console.WriteLine("It took you: " + attempts + " attempts");





Console.ReadLine();