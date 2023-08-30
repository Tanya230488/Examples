int ImputNum (string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

void Squares(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int res = (int) Math.Pow(i, 2);
        System.Console.WriteLine($"{i} * {i} = {res}");
    }    
}

int digit = ImputNum("Введите число: ");
Squares(digit);
