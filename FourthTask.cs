Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    Console.WriteLine("You have rolled a double +2 Bonus to your total");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples");
    total += 6;
}

if (total > 14)
{
    Console.WriteLine("You Win!");
}else
{
    Console.WriteLine("You Lose");
}

