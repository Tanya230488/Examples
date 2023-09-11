// создать массив из 123 эл и посчитать количество элементов от 10 до 99
void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 201);
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Count (int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= 10 || array[i] >= 99)
        {   
            res ++;
        }
    }
    return res;    
}

int[] arr = new int[10];
FillArray(arr);
PrintAr(arr);
int res = Count(arr);
Console.WriteLine("Количество элементов от 10 до 99 равно " +  res);