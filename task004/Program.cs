  // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int numder = int.Parse(Console.ReadLine());

int num = 2;
while (num <= numder)
{
  if (num <= numder - 2)
  {
  Console.Write(num + ", ");
  } 
  else
  {
    Console.Write(num + ". ");
  }
  num = num + 2;
}