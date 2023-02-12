// программа заполняет спирально массив 4 на 4
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
int[,]Array(int size)
{
    int[,]array=new int[size,size];
    int row=0;
    int col=0;
    int naprav=0;
    int max=size*size;
    for(int i=1; i<=max;i++)
    {
        array[row,col]=i;
        if(naprav==0)
        {
            col++;
            if(col==size || array[row,col]!=0)
            {
                naprav=1;
                col--;
                row++;
            }
        }
        else if(naprav==1)
        {
            row++;
            if(row==size || array[row,col]!=0)
            {
                naprav=2;
                row--;
                col--;
            }
        }
        else if(naprav==2)
        {
            col--;
            if(col<0 || array[row,col]!=0)
            {
                naprav=3;
                col++;
                row--;
            }
        }
        else if(naprav==3)
        {
            row--;
            if(row<0 || array[row,col]!=0)
            {
                naprav=0;
                row++;
                col++;
            }
        }
    }
    return array;
}

Console.WriteLine("введи размер");
int s=int.Parse(Console.ReadLine());
int[,] arr=Array(s);
PrintArray(arr);
