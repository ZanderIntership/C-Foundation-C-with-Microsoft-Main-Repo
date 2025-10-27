using System.Runtime.InteropServices;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your Membership has expired");
    
}else if (daysUntilExpiration <= 1)
{
    Console.WriteLine("Your Membership expires in a day");
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}");
}else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your Membership expires in five days");
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}");
}else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your Membership expires in ten days");

}

Console.WriteLine($"{daysUntilExpiration}");
