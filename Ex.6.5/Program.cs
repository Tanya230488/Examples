// ПР кот создает копию заданного массива с пом поэлементного копирования

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAr(int size)
{
    return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintAr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] CopyArray (int[] arr)
{
    int[] res = CreateAr(arr.Length);

    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

int size = ImputNum("Введите размер массива: ");
int min = ImputNum("Введите минимальное значение диапазона: ");
int max = ImputNum("Введите максимальное значение диапазона: ");

int[] arr = CreateAr(size);
FillArray(arr, min, max);
PrintAr(arr);
arr [arr.Length - 2] = 1000;

int[] newArray = CopyArray(arr);
PrintAr(newArray);



