// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] CreateMatrix()
{
    int[,] matrix = new int[5, 6];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 6; j++)
        {

            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int Summa(int[,] matrix)
{
    int x=0;
    int count =0;
    int sum=0;
    int minsum = Int32.MaxValue;  // - вычитал в инете про эту команду( ставит максимально доступное число), до этого в ручную просто ставил 500
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum=0;
        count++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        if(minsum>sum)
        {
            minsum=sum;
            x= count;
        }
        System.Console.Write(" " + sum + " "); 
    }
     System.Console.WriteLine("");
    System.Console.WriteLine($"Минимальная сумма   {minsum}   В строке    {x} ");
    return sum;
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
System.Console.WriteLine("");
Summa(matrix);
