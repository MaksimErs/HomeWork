// напишите программу, которая на вход принимает два числа и выдает какое  число большее какое меньшее
Console.WriteLine("введи первое число");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("введи второе число");
int number2=int.Parse(Console.ReadLine());
if(number1>number2)
{
    Console.WriteLine($"число {number1}больше числа {number2}");
    Console.WriteLine($"число {number2} меньше числа {number1}");
}
else
{
    Console.WriteLine($"число {number2} больше числа {number1}");
    Console.WriteLine($"число {number1} меньше числа {number2}");
}
