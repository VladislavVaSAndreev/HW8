// Задача: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int firstRows = ReadInt("Введите количество строк первого массива: ");
int firstColumns = ReadInt("Введите количество столбцов первого массива: ");
int secondRows = ReadInt("Введите количество строк второго массива: ");
int secondColumns = ReadInt("Введите количество столбцов второго массива: ");

int[,] firstArray = new int[firstRows, firstColumns];
int[,] secondArray = new int[secondRows, secondColumns];
int[,] resultArray = new int[firstRows, secondColumns];

FillArrayRandom(firstArray);
PrintArray2D(firstArray);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (firstArray.GetLength(1) != secondArray.GetLength(0))
{
    Console.WriteLine(" Нельзя выполнить умножение массивов ");
    return;
}
for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
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

