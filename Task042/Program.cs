// Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string resultNumber = "";
while (number > 0)
{
  resultNumber = ((number % 2 == 0) ? "0" : "1") + resultNumber;
  number /= 2;
}
Console.Write(resultNumber);
