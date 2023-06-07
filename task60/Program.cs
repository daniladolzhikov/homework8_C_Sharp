// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

void FillArray(int[,,] array)
{
    Random random = new Random();
    HashSet<int> usedNumbers = new HashSet<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number;
                do
                {
                    number = random.Next(10, 100);
                } while (usedNumbers.Contains(number));

                array[i, j, k] = number;
                usedNumbers.Add(number);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k],3}    ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArrayWithIndices(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int value = array[i, j, k];
                System.Console.Write($"{value:00}({i},{j},{k})   ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

Console.Clear();
Console.Write("Введите количество слоев: ");
int layers = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,,] array = new int[layers, rows, cols];
FillArray(array);
PrintArrayWithIndices(array);
