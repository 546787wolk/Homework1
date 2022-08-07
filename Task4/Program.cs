 int a, b, c;
 Console.WriteLine("Введите три числа через Enter: ");
 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());
 c = Convert.ToInt32(Console.ReadLine());
int max = a;
if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
    
    
Console.Write("max = ");
Console.WriteLine(max);
