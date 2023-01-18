// напишите программу которая принимает трехзначное число и вывоит на выходе вторую цифру
Console.WriteLine("введи трехзначное число");
int num=int.Parse(Console.ReadLine());
int a=num/100;
int b=num%10;
int x=(num-(a*100+b))/10;
Console.WriteLine($"вторая цифра числа {x}");
