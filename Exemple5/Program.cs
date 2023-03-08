// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix()
{
    int[,] matrix = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = new Random().Next(0,1);
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
int[,] Spiral(int[,] matrix, int i, int j)
{   
    int count = 1;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
        {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
        else
        i--;
        }
    return matrix;
}
    

//     int count = 1;                    - пробовал через рекурсию
//     if(matrix[row, col]==0)
//     {
//         matrix[row, col]=count;
//         count++;
//     }
//     Spiral(row+1, col);
//     Spiral(row, col+1);
//     Spiral(row-1, col);
//     Spiral(row, col-1);
// }

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
System.Console.WriteLine("");
int[,] matrixNew = Spiral(matrix, 0, 0);
PrintMatrix(matrixNew);
