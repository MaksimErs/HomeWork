// расстояние между двумя точками в 3d
Console.WriteLine("введи x1");
int x1=int.Parse(Console.ReadLine());

Console.WriteLine("введи y1");
int y1=int.Parse(Console.ReadLine());

Console.WriteLine("введи z1");
int z1=int.Parse(Console.ReadLine());

Console.WriteLine("введи x2");
int x2=int.Parse(Console.ReadLine());

Console.WriteLine("введи y2");
int y2=int.Parse(Console.ReadLine());

Console.WriteLine("введи z2");
int z2=int.Parse(Console.ReadLine());

double r = Math.Sqrt((Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2)));

r= Math.Round(r,2);

Console.WriteLine(r);
