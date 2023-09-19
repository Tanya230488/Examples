// пр принимает на вход число и выдает сумму его числел

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SumOfNumbers (int num)
{
    if(num == 0) return 0;
    return num % 10 + SumOfNumbers(num / 10);
}

int number = ImputNum("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number} равна {SumOfNumbers(number)} ");