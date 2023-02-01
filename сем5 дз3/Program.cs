// задайте массив вещественных чисел, найдите разницу между макс и мин элементами массива
double RandomC(int minA, int maxB)
{
    double d= new Random().NextDouble()*(maxB-minA)+minA;
    return d;
}


double[] GetArray(int size, int minA, int maxB)
{
    double[] res=new double[size];
    for(int i=0;i<size;i++)
    {
        res[i]=RandomC( minA,  maxB);
    }
    return res;
}
 


 double Raznmaxmin(double[]arr )
 {
    double min=arr[0];
    double max=arr[0];
    double razn=0;
    for (int i=1; i<arr.Length; i++ )
    {
        if(arr[i]<min) min=arr[i];
        else if (arr[i]>max) max=arr[i];
    }
    razn=max-min;
    return razn;
 }

double[]array=GetArray(4,10,20);
Console.WriteLine(String.Join(" ",array));

 double raznost=Raznmaxmin(array);
 Console.WriteLine(raznost);

