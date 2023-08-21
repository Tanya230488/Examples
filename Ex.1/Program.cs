Console.Write ("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write ("Введите квадрат числа: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 == number1 * number1) Console.WriteLine($"Число {number2} является квадратом числа {number1}");
else Console.WriteLine($"Число {number2} не является квадратом числа {number1}"); 