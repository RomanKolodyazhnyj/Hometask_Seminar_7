// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.​
// Например, задан массив:
// 1 4 7 2 ​
// 5 9 2 3​
// 8 4 2 4​
// 1 7 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите строку: ");
int positionRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int positionColumn = Convert.ToInt32(Console.ReadLine()) - 1;

Random random = new Random();
int[,] matrix = new int[rows, columns];
Console.WriteLine("Заданный массив: ");
PrintMatrix(matrix);
PositionMatrix(matrix);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 101);
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}

void PositionMatrix(int[,] matrix)
{
    if (positionRow < 0 | positionRow > matrix.GetLength(0) - 1 | positionColumn < 0 | positionColumn  > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Значение выбранного элемента в массиве нет.");
    }
    else
    {
        Console.WriteLine("Значение выбранного элемента массива: {0}", matrix[positionRow, positionColumn]);
    }
}