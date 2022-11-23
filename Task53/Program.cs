// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] matrix = new int[5, 5];

int[,] filledMatrix = FillMatrix(matrix);
PrintMatrix(filledMatrix);
ChangeFirstAndLastNumber(filledMatrix);
Console.WriteLine();
PrintMatrix(filledMatrix);



int[,] FillMatrix(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 10);
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
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void ChangeFirstAndLastNumber(int[,] matrix)
{
    int temp = matrix[0, 0];
    matrix[0, 0] = matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    matrix[matrix.GetLength(0)-1, matrix.GetLength(1)-1] = temp;
}