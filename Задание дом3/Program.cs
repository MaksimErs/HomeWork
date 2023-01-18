// напишите программу, которая принимает на вход число и выдает четное ли оно
Console.WriteLine("введи число");
int number=int.Parse(Console.ReadLine());
if(number%2==0)
{
    Console.WriteLine($"число {number} четное");
}
else
{
    Console.WriteLine($"число {number} не четное");
}
