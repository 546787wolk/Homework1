 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] arrayNumbers = new double[8];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(0, 8);
    Console.Write(arrayNumbers[i] + " ");
  }
double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];
  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double difference = maxNumber - minNumber;
  Console.WriteLine($"Разница  между максимальным элементом  ({maxNumber}) и минимальным элементом ({minNumber}) равна: {difference}");
