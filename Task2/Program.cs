// Задача: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void minSumRows(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GenerateArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

int rows = ReadInt("введите число рядов: ");
int columns = ReadInt("введите число столбцов: ");
int[,] array = new int[rows, columns];
GenerateArray2D(array);
PrintArray(array);
Console.WriteLine();
minSumRows(array);
