// программа на вход принимает позицию элемента в двумерном массиве и выдает значение или что такого элемента нет.
int[,] GetArray(int m, int n, int minA, int maxB)
{
    int[,] res=new int[m,n];
    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
           res[i,j]=new Random().Next(minA, maxB); 
        } 
    }
    return res;
}
 

void PrintArray(int[,]inArray)
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

void Posit(int [,] array)
{
    Console.Write("введи строку элемента: ");
    int str=int.Parse(Console.ReadLine()!);
    Console.Write("введи столбец элемента: ");
    int sto=int.Parse(Console.ReadLine()!);
    if(str>=array.GetLength(0)||sto>=array.GetLength(1))
    {
        Console.Write("такого элемента нет");
    }
    else
    {
        Console.Write(array[str,sto]);

    }

}

int[,]arr=GetArray(4,4,1,10);
PrintArray(arr);
Posit(arr);
