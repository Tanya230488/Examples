int[] GetCoor(string msg)
{
    int[] coordinates = new int[2];

    Console.Write($"{msg} X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);

    Console.Write($"{msg} Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);

    return coordinates;
}

double Distance(int[] pointA, int[] pointB)
{
    int deltaX = pointB[0] - pointA[0];
    int deltaY = pointB[1] - pointA[1];
    double dist = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return dist;
}

int[] coorA = GetCoor("Введите для точки А координату");
int[] coorB = GetCoor("Введите для точки B координату");

double result = Distance(coorA, coorB);
result = Math.Round(result, 2);

Console.WriteLine(result);