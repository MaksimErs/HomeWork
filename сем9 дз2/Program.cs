// программа выводит сумму натуральных чисел в промежутке от n до m
int NUM(int m, int n)
{
    if(m==n) return n;
    else
    {
        return n+NUM(m, n-1);
    }
}
int S= NUM(1,2);

Console.WriteLine(S);

