// принимаем на вод числа А и В и возводим А в степень В
int Step(int A, int B)
{
    int count=1;
    int resalt=1;
    while(count<=B)
    {
        resalt=resalt*A;
        count++;
    }
    return resalt;

}


Console.WriteLine("Введи число a  ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введи число b  ");
int b=int.Parse(Console.ReadLine());
int s=Step(a,b);
Console.WriteLine($"число a в степени b {s}");



