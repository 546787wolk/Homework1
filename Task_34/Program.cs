// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] numbers = new int [10];

void Array1(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void Array2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int evenInt(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            amount++;
            
        }
    }
    return amount;
}

Array1(numbers, 100, 1000);
Array2(numbers);
Console.WriteLine();

int amount = evenInt(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: { amount}");