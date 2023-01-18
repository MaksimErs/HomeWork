// напишите программу которая принимает три числа и выдает максимальное из них
Console.WriteLine("введи первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("введи второе число");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("введи третье число");
int c=int.Parse(Console.ReadLine());

if((a>b)&&(a>c))
{
    Console.WriteLine($"максимальное число {a}");
}
else 
if(b>c)
    {
      Console.WriteLine($"максимальное число {b}");
    }
else
{
    Console.WriteLine($"максимальное число {c}");
}
