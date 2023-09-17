//  пр кот удаляет строку и столбец на пересечении самого маленького эл массива

// составить частотность лавар элементов двумерного массива(сколько раз встречается элемент входных данных)

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
int[,] Create2DAr(int rows, int columns)
{
    return new int[rows,columns];
}
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(0, 5);
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
int[] Minimal (int[,] array)
{
    int min = array[0,0];
    int[] indexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            min = array[i,j];
            indexes[0] = i;
            indexes[1] = j;   
        }
    }
    return indexes;
}

int[,] DeleteRowCol (int[,] array, int[] ind)
{
    int[,] res = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == ind[0])
        {
            continue;
        }  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == ind[1])
            {
                continue;
            }
            res[row,col] = array[i,j];
            col++;
        } 
        row++;
        col = 0;
    }
    return res;
}

int rows = ImputNum("Введите количество строк: ");
int columns = ImputNum("Введите количество столбцов: ");
int[,] array2D = Create2DAr(rows, columns);


FillArray (array2D);
Print2DAr(array2D);

System.Console.WriteLine();

int[] indexesAr = Minimal(array2D);
int[,] resultAr = DeleteRowCol(array2D, indexesAr);
Print2DAr(resultAr);