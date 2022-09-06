//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int temp = M;
if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);

void PrintSumm(int m, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(M, N - 1, summ);
}
