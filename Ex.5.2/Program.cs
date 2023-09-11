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

void PrintAr (int[] arr)
{
      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write(arr[i] + ", ");
      }
System.Console.WriteLine();
}

void Change (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }    
}

int size = ImputNum("Введите размер массива: ");
int min = ImputNum("Введите минимальное значение: ");
int max = ImputNum("Введите максимальное значение: ");
int[] arr = CreateAr(size);
FillArray(arr, min, max);
PrintAr(arr);
Change(arr);
PrintAr(arr);