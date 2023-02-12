// See https://aka.ms/new-console-template for more information
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
int[,] PrintPr(int[,]inArray, int[,] inArr)
{
    int[,] arr=new int[inArray.GetLength(0),inArray.GetLength(1)];
    arr[0,0]=inArray[0,0]*inArr[0,0]+inArray[0,1]*inArr[1,0];
    arr[0,1]=inArray[0,0]*inArr[1,0]+inArray[0,1]*inArr[1,1];
    arr[1,0]=inArray[1,0]*inArr[0,0]+inArray[1,0]*inArr[1,0];
    arr[1,1]=inArray[1,0]*inArr[0,1]+inArray[1,1]*inArr[1,1];
    return arr;

}
int[,]ss=GetArray(2,2,0,10);
int[,]se=GetArray(2,2,0,10);
PrintArray(ss);
PrintArray(se);
int[,]aa =PrintPr(ss,se);
PrintArray(aa); 
  