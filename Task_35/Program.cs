// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int N=123;
int[] array=new int[N];
Random random=new Random();

for(int i=0;i<array.Length;i++)
{
array[i]=random.Next(0,123);}

for(int i=0;i<array.Length;i++)
{
System.Console.Write($"{array[i],4}");
}
int count=0;
for(var i=0; i<array.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count );
