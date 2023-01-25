// принимаем число n  и выдаем таблицу кубов от 1 до n
Console.WriteLine("введи числа");
int n= int.Parse(Console.ReadLine());
int count=1;
while (count<=n)
{
    double resalt=Math.Pow(count,3);
    Console.WriteLine($"куб числа {resalt}");
    count++; 
}

