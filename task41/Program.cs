// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
CountPositive(GetValue("Введите числа через запятую"));

string[] GetValue(string message)
{
  Console.WriteLine(message);
  string input = Console.ReadLine();
  string[] inputArray = input.Split(new char[] { ',' });
  return inputArray;
}

void CountPositive (string[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (CheckNumbers(numbers[i]))
    {
      if (int.Parse(numbers[i]) > 0)
      {
        count++;
      }
    }
  }
  Console.WriteLine("Количество положительных чисел " + count);
}

bool CheckNumbers(string num) //проверка на число
{
  int temp;
  if (int.TryParse(num, out temp))
  {
    return true;
  }
  else
  {
    return false;
  }
}
