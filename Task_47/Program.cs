//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] a = new double [m , n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
