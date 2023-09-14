// созд двумерный массив со строками м и нб где знач элемента равно сумме его строки и столбца

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DAr(int rows, int columns)
{
    return new int[rows,columns];
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i,j] = i + j;
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


int rows = ImputNum("Введите количество строк: ");
int columns = ImputNum("Введите количество столбцов: ");

int[,] array2D = Create2DAr(rows, columns);
FillArray (array2D);
Print2DAr(array2D);
