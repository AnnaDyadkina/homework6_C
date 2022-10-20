// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Console.WriteLine("Hello, World!");

int b1Input = GetValue("Введите b1");
int k1Input = GetValue("Введите k1");
int b2Input = GetValue("Введите b2");
int k2Input = GetValue("Введите k2");

double x = CalculateX(b1Input, k1Input, b2Input, k2Input);
double y = CalculateY(x, b1Input, k1Input);

Console.WriteLine($"({x}; {y})");

int GetValue (string message)
{
  Console.WriteLine(message);
  int value = int.Parse(Console.ReadLine());
  return value;
}

double CalculateX(int b1, int k1, int b2, int k2)
{
  double x1 = k1 - k2;
  double x2 = b2 - b1;
  double x = x2 / x1;
  //double x = (b2 - b1) / (k1 - k2); Не понимаю, почему так получается x = 0
  return x;
}

double CalculateY (double x, int b1, int k1)
{
  double y = k1 * x + b1;
  return y;
}
