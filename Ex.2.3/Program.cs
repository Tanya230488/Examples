// System.Console.WriteLine("Введите первое число");
// int firstNum = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Введите второе число");
// int secondNum = int.Parse(Console.ReadLine())!;

bool Multiplicity(int num1, int num2)
{
    if (num1 % num2 == 0)
        return true;
    return false;
}

int InputNum(string message)
{
    Console.Write(message);
    // int num = int.Parse(Console.ReadLine();
    // result num;
    return int.Parse(Console.ReadLine()!);
}

void CheckResult(bool mult, int firstNum, int secondNum)
{
    if (mult == true)
    {
        System.Console.WriteLine("Первое число кратно второму");
    }
    else
        System.Console.WriteLine($"Первое число некратно второму, остаток от деления равен {firstNum % secondNum}");
}

int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool result = Multiplicity(firstNum, secondNum);
CheckResult(result, firstNum, secondNum);