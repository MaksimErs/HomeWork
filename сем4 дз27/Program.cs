// принимаем число и выдаем сумму цифр в числе
int Sum(int A)
{
    int suma=0;
    int count=A;
    while(count>0)
    {
        int p= count%10;
        suma=suma+p;
        count=count/10;
    }
    return suma;
}

Console.WriteLine("Введи число   ");
int a=int.Parse(Console.ReadLine());

int s=Sum(a);
Console.WriteLine($"сумма цифр в числе равна {s}");

