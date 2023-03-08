// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrix()
{
    int[,] matrix = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {

            matrix[i, j] = new Random().Next(1, 5);
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

int[,] Proizvod(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[2, 2];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                matrix3[i,j] = matrix3[i,j] + (matrix1[i,x]*matrix2[x,j]);    
            }    
        }
   }
   return matrix3;
}


int[,] matrix1 = CreateMatrix();
int[,] matrix2 = CreateMatrix();
PrintMatrix(matrix1);
System.Console.WriteLine("");
PrintMatrix(matrix2);
System.Console.WriteLine("");
int[,] matrix3 = Proizvod(matrix1, matrix2);
PrintMatrix(matrix3);