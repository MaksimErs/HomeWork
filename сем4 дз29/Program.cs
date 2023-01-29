// задаем массив из 8 элементов и выводим на экран
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

int[]ddd=Mas();
Print(ddd); 




 












