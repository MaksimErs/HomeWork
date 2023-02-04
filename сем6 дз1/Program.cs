// вводим восемь чисел, получаем сколько чисел больше нуля ввели
int[] Mas()
{
    int[] res=new int[8];
    for(int i=0; i<8; i++)
    {
        res[i]=int.Parse(Console.ReadLine());
    } 
    return res;
}

void Print(int[] col)
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

int Big(int []frry)
{
    int count=0;
    foreach ( int item in frry)
    {
        if( item>0) count++;
    }
    return count;
}

int[]ddd=Mas();
Print(ddd);
int result= Big(ddd);
Console.WriteLine($"количество чисел больше нуля {result}");
