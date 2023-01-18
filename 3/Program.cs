// написать программу которая выводит третью цифру заданного числа
Console.WriteLine("введи число");
int  n= int.Parse(Console.ReadLine());
 int k=1000;
 int b=10;
 if(n/10==0 || n/100==0)
{
   Console.WriteLine("третьего числа нет");
}
else if (n/100>0)
{
while(n/k>0)
 {
    k=k*10;
    b=b*10;
 }
int x=n%b/(b/10);
Console.WriteLine(x);
}
