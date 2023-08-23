bool Multiplicity (int number)
{
    return number % 7 == 0 && number % 21 == 0;
}

int InputNum(string message)
{
    Console.Write(message);
    // int num = int.Parse(Console.ReadLine();
    // result num;
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum ("Ведите число: ");
bool result = Multiplicity (num);

if (result)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
