//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите 5и значное число");
int n = int.Parse(Console.ReadLine());
int x = n;

if (x > 9999 && x < 100000)
{
   x = x % 100; 
   n = n / 1000;
   int last = x % 10;
   int first = n / 10;
   x = x / 10;
   n = n % 10;
 
  if(x == n && last == first)
    {
     Console.WriteLine("Данное число является палиндромом");
    }
  
   else
   {
     Console.WriteLine("Данное число не является палиндромом");
   }
} 
else
    Console.WriteLine("Ошибка! Вы ввели неверное число! Нужно 5и значное!");


