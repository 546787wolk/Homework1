//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int [10];
int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");

        if (i % 2 != 0)
        {
            sum += array[i];  
        }
    }
Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях:{sum}");