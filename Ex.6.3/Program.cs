// ПР кот преобразует число из 10чной системы в двоичную

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

string DecToBin (int decNum)
{
    string bin = "";
    while (decNum != 0)
    {
        int rem = decNum % 2;
        bin = $"{rem}" + bin;
        decNum = decNum / 2;
    }
    return bin;
}

int num = ImputNum("Введите число: ");
Console.WriteLine("Число " + num + " в двоичной системе равно " + DecToBin(num));
