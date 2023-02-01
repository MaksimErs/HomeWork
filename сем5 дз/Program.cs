// задайте массив с положительными трехзначными числами, напишите программу, которая покажет  количество четных чисел в массиве
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for(int i=0;i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}
 


 int chetnArray(int[]arr )
 {
    int count=0;
    for (int i=0; i<arr.Length; i++ )
    {
        if(arr[i]%2==0) count++;
    }
    return count;
 }

int[]array=GetArray(10,100,999);
Console.WriteLine(String.Join(" ",array));

 int chet=chetnArray(array);
 Console.WriteLine($"количество четных чисел {chet}");

