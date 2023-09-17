// пр кот заменяет строки на столбцы

// пр кот меняет первую и последнюю строчки двум массива

//   задайте 2д массив и найдите сумму эл на главной диагонали с идексами 00, 11, и тд

// 2мерн массив, найти элементы у которых индексы четные и заменить их на их квадраты

// созд двумерный массив зап случайными цел числами

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DAr(int rows, int columns)
{
    return new int[rows,columns];
}

void FillArray(int[,] array, int minVlue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(minVlue, maxValue -1);

}

int[,] SwitchArray(int[,] array)
{
   int[,] resultAr = new int[array.GetLength(0), array.GetLength(1)];
   for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(0); j++)
            resultAr[j,i] = array[i,j];
   return resultAr; 
}

void Print2DAr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j]}\t");
        Console.WriteLine();
    }
}

bool Checking (int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);

}

int rows = ImputNum("Введите количество строк: ");
int columns = ImputNum("Введите количество столбцов: ");
int[,] array2D = Create2DAr(rows, columns);

if (Checking(array2D))
{
int min = ImputNum("Введите минимальное значение диапазона: ");
int max = ImputNum("Введите максимальное значение диапазона: ");
FillArray (array2D, min, max);
Print2DAr(array2D);

System.Console.WriteLine();

int[,] newArray = SwitchArray(array2D);
Print2DAr(newArray);
}
else 
{
    Console.WriteLine("Не возможно развернуть матрицу");
}