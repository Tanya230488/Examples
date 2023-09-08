int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int SumFrom1ToNum (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int num = ImputNum ("Введите число: ");
int sum = SumFrom1ToNum(num);
Console.WriteLine($"Сумма чиселот 1 до {num} равна {sum}.");
