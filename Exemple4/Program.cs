// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая 
// будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix()
{
    int[,,] matrix = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int x = 0; x < 2; x++)
            {
              matrix[i, j, x] = new Random().Next(10, 100);  
            }
        }
    }
    return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(2); x++)
            {
              System.Console.Write(matrix[i, j, x] + "(" + i + "," + j + "," + x + ")" + " ");  
            }
        }
        System.Console.WriteLine();
    }
}

int[,,] matrix = CreateMatrix();
PrintMatrix(matrix);