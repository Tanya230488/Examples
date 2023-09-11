// произведение пар чисел первого и последнего и проч и записать в новый массив


int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAr(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintAr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] SumOfDig(int[] inputArray)
{
    int newSize = inputArray.Length / 2 + inputArray.Length % 2;
    int[] outputArray = new int[newSize];

    for (int i = 0; i < inputArray.Length / 2; i++)
    {
        outputArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
    }

    if (inputArray.Length % 2 > 0)
        outputArray[newSize - 1] = inputArray[inputArray.Length / 2];

    return outputArray;
}

int size = ImputNum("Введите размер массива: ");
int[] arr = CreateAr(size);
FillArray(arr);
PrintAr(arr);
int[] newArray = SumOfDig(arr);
PrintAr(newArray);
