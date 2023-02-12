// задайте трехмерный массив из двузнач чисел размер 2 на 2, напишите программу вывода с индексами
int[,,]array={{{11,22},{12,23}},{{13,24},{14,25}}};
void PrintFrray(int[,,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
            for(int j=0; j<arr.GetLength(1); j++)
            {
                for(int k=0; k<arr.GetLength(2); k++)
                {
                    Console.WriteLine("arr[{0},{1},{2}]={3}",i,j,k, arr[i,j,k]);
                }

            }

    }
}
PrintFrray(array);
