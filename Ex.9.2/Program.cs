// нат числа от м до н

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    return start + " " + PrintNumbers(++start, end);
}

int first = ImputNum("Введите начальное число: ");
int second = ImputNum("Введите конечное число: ");
string result = PrintNumbers(first, second);
Console.WriteLine(result);