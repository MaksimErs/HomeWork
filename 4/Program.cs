// программма принимает на вход цифру обозначающую день недели и проверят выходной ли этот день
Console.WriteLine("введи цифру дня недели");
int a=int.Parse(Console.ReadLine());
if(a==6 || a==7)
{
    Console.WriteLine("выходной день" );
}
else
{
    Console.WriteLine("рабочий день" );
}
