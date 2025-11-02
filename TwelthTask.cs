Random random = new Random();
int DamageDone = 0;
int MonsterHealth = 10;
int HumanHealth = 10;


do
{

   
    if (HumanHealth > 0)
    {
        DamageDone = random.Next(1, 12);
        MonsterHealth -= DamageDone;

        Console.WriteLine($"Monster was damaged and lost {DamageDone} health and now has {MonsterHealth} health.");
    }
 

   if(MonsterHealth > 0)
    {
        DamageDone = random.Next(1, 12);
        HumanHealth -= DamageDone;

        Console.WriteLine($"Human was damaged and lost {DamageDone} health and now has {HumanHealth} health.");
    }



} while (MonsterHealth > 1 && HumanHealth > 1);

if (MonsterHealth < 1)
{
    Console.WriteLine("There hero won!");
}
else
{
    Console.WriteLine("The Monster Won!");
}
