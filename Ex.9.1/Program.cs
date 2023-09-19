// пр кот выведет все натуральные числа от 1 до н

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

// void PrintNumbers(int num, int start)
// {
//     if (start > num) return;
//     Console.Write($"{start} ");
//     PrintNumbers(num, start +1);
// }

void PrintNumbers2 (int num)
{
    if (num==0) return;
    PrintNumbers2(num-1);
    Console.Write($"{num} ");
}

int number = ImputNum("Введите число n: ");
PrintNumbers2 (number);