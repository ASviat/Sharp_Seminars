// Задайте двумерный массив. Напишите прогу, которая заменит строки на столбцы. В случае, 
// если это невозможно, прога должна вывести сообщение об ошибке для пользователя.

Console.WriteLine("Введите количество строк: ");
bool isParsedLine = int.TryParse(Console.ReadLine(), out int lines);
Console.WriteLine("Введите количество столбцов: ");
bool isParsedColumn = int.TryParse(Console.ReadLine(), out int columns);

if (!isParsedLine || !isParsedColumn || lines != columns)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] matr = new int[lines, columns];

int[,] filledMatrix = FillMatrix(matr);
PrintMatrix(filledMatrix);
Console.WriteLine();
int[,] changedMatrix = ChangeLinesToColumns(filledMatrix);
PrintMatrix(changedMatrix);
//PrintMatrix(ChangeLinesToColumns(filledMatrix));


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

int[,] ChangeLinesToColumns(int[,] matrix)
{

    int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            changedMatrix[j, i] = matrix[i, j];
        }
    }
    return changedMatrix;
}