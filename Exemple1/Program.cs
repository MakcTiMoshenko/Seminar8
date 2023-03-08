// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix()
{
    int[,] matrix = new int[5, 5];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
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
void ChangeMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                if (matrix[i, x] < matrix[i, x + 1])
                {
                    int temp = matrix[i, x + 1];
                    matrix[i, x + 1] = matrix[i, x];
                    matrix[i, x] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
System.Console.WriteLine("");
ChangeMatrix(matrix);
PrintMatrix(matrix);
