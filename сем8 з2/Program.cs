// задаем массив и находим строку с наименьшнй суммой элементов
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
int[] PrintSumst(int[,]inArray)
{
    int[] arr=new int[inArray.GetLength(0)];
    for(int i=0;i<inArray.GetLength(0);i++)
    {
        int sum=0;

        for(int j=0;j<inArray.GetLength(1);j++)
        {
             sum=sum+inArray[i,j];
            
         
        }
        arr[i]=sum;
    }
    return arr;            

}

void Print(int[] col)
{
    int count=col.Length;
    int pos=0;
    while(pos<count)
    {
        Console.Write(col[pos] );
        pos++;
    }
    Console.WriteLine( );
}


int Maxx(int[] arr)
{
   int count=0;
   int min=arr[0];
   for(int i=1; i<arr.Length; i++)
   {
     if(arr[i]<min)
     {
       count=i;
        min=arr[i];

     }   

    }  
       return count;
       

}  
   

  
    


int[,]ssd= GetArray(2,2,1,10);
PrintArray(ssd);
int[] arrr =PrintSumst(ssd);
Print(arrr);
int min=Maxx(arrr);
Console.Write(min);


