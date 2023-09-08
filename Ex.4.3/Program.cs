int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int Factorial(int num)
{
    int fact = 1;
    for (int i = 2; i <= num; i++)
        fact *= i;
    return fact;
}


int num = ImputNum("Введите число: ");
int res = Factorial(num);
Console.WriteLine($"Факториал числа {num} равно {res}");