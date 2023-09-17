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

void FillArray(int[,] array, int minVlue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(minVlue, maxValue -1);

}

int[] Array1D (int[,] array)
{
   int[] newarray = new int[array.Length];
   int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        newarray[index] = array[i,j];
        index++;
    }
}
return newarray;
}

void SortArray (int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
void Frequency (int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] == array[i+1])
        {
            count++;
        }    
        else
        {
        Console.WriteLine($"Число {array[i]} встречается {count} раз");
        count = 1;
        }
    }   
Console.WriteLine($"Число {array[array.Length-1]} встречается {count} раз");
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


int min = ImputNum("Введите минимальное значение диапазона: ");
int max = ImputNum("Введите максимальное значение диапазона: ");
FillArray (array2D, min, max);
Print2DAr(array2D);

System.Console.WriteLine();

int[] newArray = Array1D(array2D);
SortArray(newArray);
Frequency(newArray);