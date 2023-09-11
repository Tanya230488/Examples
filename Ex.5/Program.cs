int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAr (int size)
{
    return new int[size];
}

void FillArray (int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void SumPosNegElements (int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sumPos += array[i];
        else 
        sumNeg += array[i];
    }

    Console.WriteLine($"Сумма положительных элементов равна {sumPos} , а сумма отрицательных равна {sumNeg}");
}

int size = ImputNum("Введите размер массива: ");
int min = ImputNum("Введите минимальное значение: ");
int max = ImputNum("Введите максимальное значение: ");
int[] arr = CreateAr(size);
FillArray(arr, min, max);
PrintAr(arr);
SumPosNegElements(arr);
