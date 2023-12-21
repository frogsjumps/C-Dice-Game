Random numberGen = new Random();

int rollNumber1 = 0;
int rollNumber2 = 1;
int attempts = 0;

Console.WriteLine("Press enter to roll the dice.\n");

while(rollNumber1 != rollNumber2) {
    Console.ReadKey();

    rollNumber1 = numberGen.Next(1, 7);
    rollNumber2 = numberGen.Next(1, 7);

    Console.WriteLine("You rolled: " + rollNumber1);
    Console.WriteLine("You rolled: " + rollNumber2 +"\n");
    attempts++;
}
Console.WriteLine("You got matching rolls in " + attempts + " attempts");

Console.ReadLine();