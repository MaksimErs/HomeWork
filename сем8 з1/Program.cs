// задаем массив и и пишем программу упорядочивания по убыванию каждой строки
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
void PrintSumst(int[,]inArray)
{
    for(int i=0;i<inArray.GetLength(0);i++)
    {
        
        for(int j=0;j<inArray.GetLength(1)-1;j++)
        {
            int maxPos=j;
            for(int f=j+1; f<inArray.GetLength(1);f++)
            {
                if(inArray[i,f]>inArray[i,maxPos])
                {
                    maxPos=f;
                }

            }
            int temp=inArray[i,j];
            inArray[i,j]=inArray[i,maxPos];
            inArray[i,maxPos]=temp;          
         
        }
        
    }
            

}

int[,]ssd= GetArray(2,2,1,10);
PrintArray(ssd);
PrintSumst(ssd);
PrintArray(ssd);

