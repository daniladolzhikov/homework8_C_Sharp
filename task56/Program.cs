// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(0,10);
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
        System.Console.WriteLine();
}

int MinSumRow(int[,] array)
{
    int minSum = int.MaxValue;
    int rowIndex = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            rowIndex = i;
        }
    }

    return rowIndex;
}


Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);

int rowWithMinSum = MinSumRow(array);
Console.WriteLine("Строка с наименьшей суммой элементов: " + rowWithMinSum);



