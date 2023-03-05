// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray (int size)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    Console.WriteLine($"Введите число: {i+1}");
    string EnterNumber = Console.ReadLine();
    if (int.TryParse(EnterNumber, out array[i]))
    {
      array[i] = Convert.ToInt32(EnterNumber);
    }
    else
    {
      Console.WriteLine("Введено не число");
    }
  }
  return array;
}

int[] resultArray = GetArray (size);
Console.WriteLine($"Массив чисел равен: {String.Join("; ", resultArray)}");

int count = 0;
for (int i = 0; i < size; i++)
{
    if(resultArray[i] > 0)
    {
      count++;
    }
}
Console.WriteLine($"{count} чисел больше 0");