int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string GetQuater(int axisX, int axisY)
{
    string answer = "";
    if (axisX > 0 && axisY > 0)
        answer = "1 четверть";

    else if (axisX < 0 && axisY > 0)
        answer = "2 четверть";

    else if (axisX < 0 && axisY < 0)
        answer = "3 четверть";

    else if (axisX > 0 && axisY < 0)
        answer = "4 четверть";

    else
        answer = "Точка находится на границе четвертей";

    return answer;
}

// int coorX = InputNum ("Введите координаты X: ");
// int coorY = InputNum ("Введите координаты Y: ");

// string result = GetQuater(coorX, coorY);
// Console.WriteLine(result);

int[] GetCoor(string message)
{
    int[] coordinates = new int[2];
    Console.WriteLine($"{message} X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"{message} Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);

    return coordinates;
}

void GetQuater2(int[] coor)
{
    if (coor[0] > 0 && coor[1] > 0)
        Console.WriteLine("1 четверть");

    else if (coor[0] < 0 && coor[1] > 0)
        Console.WriteLine("2 четверть");

    else if (coor[0] < 0 && coor[1] < 0)
        Console.WriteLine("3 четверть");

    else if (coor[0] < 0 && coor[1] < 0)
        Console.WriteLine("4 четверть");

    else
        Console.WriteLine("Точка находится на границе четвертей");
}

int[] coors = GetCoor ("Введите значение координаты");
GetQuater2(coors);
