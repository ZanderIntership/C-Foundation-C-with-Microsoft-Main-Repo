
void RandomNum()
{
    Random random = new Random();
    int NewValue = random.Next(1, 101);

    for (int I = 0; I < 10; I++)
    {
        Console.WriteLine(NewValue);
        NewValue = random.Next(1, 101);
    }

}

RandomNum();
