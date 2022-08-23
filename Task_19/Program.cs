//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? a = Console.ReadLine();
void NumberA(string a)
{
 if (a[0]==a[4] || a[1]==a[3])
 {
 Console.WriteLine("Палиндром");
  }
 else Console.WriteLine("Не палиндром");
}
if (a!.Length == 5)
{
NumberA(a);
}
else 
Console.WriteLine("Вы ввели неправильное число");