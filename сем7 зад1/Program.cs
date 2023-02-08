// задайте двумерный массив, рамером m,n . заполненный случайными вещ.числами
double RandomC(int minA, int maxB)
{
    double d= new Random().NextDouble()*(maxB-minA)+minA;
    return d;
}


double[,] GetArray(int m, int n, int minA, int maxB)
{
    double[,] res=new double[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
           res[i,j]=RandomC( minA,  maxB); 
        } 
    }
    return res;
}
 

void PrintArray(double[,]inArray)
{
    for(int i=0;i<inArray.GetLength(0);i++)
    {
        for(int j=0;j<inArray.GetLength(1);j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
    
}
double[,]arr=GetArray(3,3,1,8);
PrintArray(arr);
