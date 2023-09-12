// Пр которая перевернет массив, первый на последнем, последний на первом месте

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

void ReverseAr(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int size = ImputNum("Введите размер массива: ");
int min = ImputNum("Введите минимальное значение диапазона: ");
int max = ImputNum("Введите максимальное значение диапазона: ");
int[] arr = CreateAr(size);
FillArray(arr, min, max);
PrintAr(arr);
ReverseAr(arr);
PrintAr(arr);
