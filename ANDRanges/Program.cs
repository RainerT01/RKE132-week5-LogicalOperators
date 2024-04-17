Console.WriteLine("Enter the temperature in Celsius:");
int temp = Int32.Parse(Console.ReadLine());
if (temp >= 30)
{
    Console.WriteLine("Boling (haha) hot.");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot.");
}
else if (temp < 20 && temp >= 14)
{
    Console.WriteLine("Warm.");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly.");
}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("Cold.");
}
else
{
    Console.WriteLine("Freezing.");
}