// введите коэффициенты прямых y=k1*x+b1 y=k2*x+b2 в следующем порядке k1 b1 k2 b2  
double[] Mas()
{
    double[] res=new double[4];
    for(int i=0; i<4; i++)
    {
        res[i]=double.Parse(Console.ReadLine());
    } 
    return res;
}

void Print(double[] col)
{
    int count=col.Length;
    int pos=0;
    while(pos<count)
    {
        Console.Write(col[pos]);
        pos++;
    }
    Console.WriteLine();
}

void Resalt(double[] sol)
{
double k1=sol[0];
double b1=sol[1];
double k2=sol[2];
double b2=sol[3];
double x=(b2-b1)/(k1-k2);
double y=k2*x+b2;
Console.WriteLine(x);
Console.WriteLine(y);
}
double[] resy=Mas();
Print(resy);
Resalt(resy);

