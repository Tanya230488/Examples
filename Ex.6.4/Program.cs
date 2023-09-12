// Не используя рекурсию выведите N Ряда чисел Фибаначи 0 1 1 2 3 (следующее число - сумма двух предыдущих)

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void Fibanachi (int memb)
{
    int first = 0;
    int second = 1;

    if (memb == 1)
        Console.Write(first);

    else
        Console.Write($"{first} {second}");
        for (int i = 3; i <= memb; i++)
        {
            int next = first + second;
            Console.Write($" {next}");
            first = second;
            second = next;
        }
}

int amount = ImputNum("Введите количество чисел ряда: ");
Fibanachi(amount);
