Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i+ " " , N);
	}
	if (N<=i )
	{
		break;
	}
	i++;
}