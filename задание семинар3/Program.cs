// программа принимает пятизнаяное число и проверяет является ли оно палиндромом
Console.WriteLine("введи пятизначное число");
int n= int.Parse(Console.ReadLine());
int a=n/10000;
int b=n/1000%10;
int c=n/10%10;
int d=n%10;
if(a==d&&b==c)
{
    Console.WriteLine("является полиндромом");
}
else
{
        Console.WriteLine(" не является полиндромом");

}
