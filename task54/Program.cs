// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] tempRow = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempRow[j] = array[i, j];
        }

        Array.Sort(tempRow);
        Array.Reverse(tempRow);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = tempRow[j];
        }
    }
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
Console.WriteLine("Упорядоченный массив:");
System.Console.WriteLine();
SortRows(array);
PrintArray(array);
