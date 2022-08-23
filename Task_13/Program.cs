Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string aText = Convert.ToString(a);
if (aText.Length > 2)
{
  Console.WriteLine("третья цифра в этом числе :  " + aText[2]);
}
else
 {
  Console.WriteLine("в это числе третьей цифры нет!");
}
