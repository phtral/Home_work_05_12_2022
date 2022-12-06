//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; n >= i; i++)
{
    int result = (int)(Math.Pow(i,3));
    Console.WriteLine($"Куб числа {i} равен {result}");
}
