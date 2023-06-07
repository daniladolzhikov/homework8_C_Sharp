// Напишите программу, которая заполнит спирально массив 4 на 4. 

void FillArraySpiral(int[,] array)
{
    int size = array.GetLength(0);
    int value = 1;
    int topRow = 0;
    int bottomRow = size - 1;
    int leftCol = 0;
    int rightCol = size - 1;

    while (topRow <= bottomRow && leftCol <= rightCol)
    {
        for (int i = leftCol; i <= rightCol; i++)
            array[topRow, i] = value++;

        topRow++;

        for (int i = topRow; i <= bottomRow; i++)
            array[i, rightCol] = value++;

        rightCol--;

        if (topRow <= bottomRow)
        {
            for (int i = rightCol; i >= leftCol; i--)
                array[bottomRow, i] = value++;

            bottomRow--;
        }

        if (leftCol <= rightCol)
        {
            for (int i = bottomRow; i >= topRow; i--)
                array[i, leftCol] = value++;

            leftCol++;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество строк и столбцов: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[,] array = new int[size, size];
FillArraySpiral(array);
PrintArray(array);
