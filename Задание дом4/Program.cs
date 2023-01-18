// написать программу где на вход принимаем число n на выходе показываем все четные числа от 1 до n
Console.WriteLine("введи число");
int  n= int.Parse(Console.ReadLine());
 int count=0;
 while(count<n)
 {
    count+=2;
    Console.WriteLine(count );
 }
