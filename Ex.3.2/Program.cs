int InputCoor (string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Diapazon (int quater)
{
    if (quater == 1)
        Console.WriteLine ("x > 0, y > 0");

    else if (quater == 2)
        Console.WriteLine ("x < 0, y > 0");

    else if (quater == 3)
        Console.WriteLine ("x < 0, y < 0");

    else if(quater == 4)
        Console.WriteLine ("x > 0, y < 0");

    else
        Console.WriteLine ("Такой четверти не существует"); 
}

int numberQ = InputCoor ("Введите номер четверти: ");
Diapazon(numberQ);
