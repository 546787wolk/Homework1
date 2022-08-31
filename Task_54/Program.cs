//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив до изменения");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1])
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
