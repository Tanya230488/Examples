int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool SquareCheck (int num1, int num2)
{
    if (num1 == num2 * num2)
        return true;
    else
        return false;
}

void PrintResult (bool res)
{
    if (res == true)
        Console.WriteLine ("Первое число является квадратом второго числа ");
    else 
        Console.WriteLine ("Первое число не является квадратом второго числа");
}

int number1 = InputNum("Введите первое число: ");
int number2 = InputNum("Введите второе число: ");

bool check = SquareCheck(number1, number2);

PrintResult(check);