int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int NumOfDigit (int num)
{
    // int count = 0;
    // while (num > 0)
    // {
    //     num = num / 10;
    //     count ++;
    // }

    int count = (int)Math.Log10(num) + 1;
    return count;
}

int num = ImputNum("Введите число: ");
int res = NumOfDigit(num);
Console.WriteLine($"Количество разрядов числа {num} равно {res}");
