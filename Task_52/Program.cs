//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] array = new int [m,n];
int []sum = new int [n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0,100) ; 
        Console.Write( array[i, j] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[i] +=array[j,i];

    }
}
for (int i = 0; i < n; i++)
{
    Console.Write((sum[i]/m) +  " ");
}
Console.ReadLine();
