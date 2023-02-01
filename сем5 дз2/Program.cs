// задайте массив. найдите сумму элементов на нечетных позициях
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for(int i=0;i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}
 


 int Sumchetn(int[]arr )
 {
    int sum=0;
    for (int i=1; i<arr.Length; i+=2 )
    {
        sum+= arr[i];
    }
    return sum;
 }

int[]array=GetArray(4,10,20);
Console.WriteLine(String.Join(" ",array));

 int summa=Sumchetn(array);
 Console.WriteLine(summa);
