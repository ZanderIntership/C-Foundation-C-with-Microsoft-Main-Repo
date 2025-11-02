Random random = new Random();

int HeadOrTails = 0;

HeadOrTails = random.Next(0, 2);

if (HeadOrTails == 0)
{
    Console.WriteLine("You have landed on tails");
} else if (HeadOrTails == 1)
{
    Console.WriteLine("You have landed on heads");
}

Console.WriteLine($"{HeadOrTails}");
