// создать массив и ответить встречается ли даное число в массиве

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAr (int size)
{
    return new int[size];
}

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintAr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool FindDig (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }    
    return false;        
}

int size = ImputNum("Введите размер массива: ");
int[] arr = CreateAr(size);
FillArray(arr);
PrintAr(arr);
int num = ImputNum("Введите число: ");
bool answer = FindDig(arr,num);
// if (answer)
//     Console.WriteLine("Данное число есть в массиве");
// else
//     Console.WriteLine("Данного числа нет в массиве");

Console.WriteLine(answer == true? "Да":"Нет");