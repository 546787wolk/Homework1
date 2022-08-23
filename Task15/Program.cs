Console.WriteLine(("Какой сегодня день недели:1)Понедельник, 2)Вторник, 3)Среда, 4)Четверг, 5)Пятница, 6)Суббота, 7)Воскресенье.Впишите соответствующее число "));
int a ;
a = Convert.ToInt32(Console.ReadLine());    
if (a<=5)
 
 {
 Console.WriteLine("Будний день (не выходной).");
}

if (a == 6  )
{

 Console.WriteLine( "выходной.");

}
if (a == 7 )
{

 Console.WriteLine( "выходной.");

}
else if (a< 1 || a > 7) {
    Console.WriteLine("это не день недели!");
  }
