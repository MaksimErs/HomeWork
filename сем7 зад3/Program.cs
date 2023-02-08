// задаем массив и ищем среднее арифметическое элементов в столбцах
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
    for(int i=0;i<inArray.GetLength(1);i++)
    {
        double sum=0;

        for(int j=0;j<inArray.GetLength(0);j++)
        {
             sum=sum+inArray[j,i];
            
         
        }
        double sumsr=sum/inArray.GetLength(0);
        Console.WriteLine($" среднее арифметическое {sumsr},");
    }
            

}

int[,]ssd= GetArray(2,2,1,10);
PrintArray(ssd);
PrintSumst(ssd);

 