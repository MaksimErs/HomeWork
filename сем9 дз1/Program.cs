// программа которая выводит натуральные числа от n до 1
string PrintNUM(int m, int n)
{
    if(n==m) return m.ToString();
    else
    {
        return PrintNUM(m+1,n)+" "+ m.ToString();
    }
}
Console.WriteLine(PrintNUM(1,4));
