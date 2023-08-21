Console.Write ("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int third = number %10;
int second = number /10 %10;
int first = number /100; 

Console.WriteLine ($"Первая цифра числа {number} равна {first}");
Console.WriteLine ($"Вторая цифра числа {number} равна {second}");
Console.WriteLine ($"Третья цифра числа {number} равна {third}");