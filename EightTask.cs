string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") == true && level > 55)
{
    Console.WriteLine("Super Admin");
} else if (permission.Contains("Admin") == true && level <= 55)
{
    Console.WriteLine("Admin only");
} else if (permission.Contains("Manager") == true && level > 19)
{
    Console.WriteLine("Contact an Admin for permission");   
} else if (permission.Contains("Manager") == true && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
} else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
