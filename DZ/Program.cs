Console.WriteLine("Введи число");
int number =int.Parse(Console.ReadLine());
int count=1;
while(count<=number)
{
    double resalt=Math.Pow(count, 2);
    Console.WriteLine($"квадрат {resalt}" );
    count++;
}
