void Method()
{
    Console.WriteLine("Автор ...");
}

// Method();

void Method2(string msg)
{
    Console.WriteLine(msg);
}

// Method2("Текст сообщения")

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("Текст Сообщения", 4);
// Method21(count:4, msg: "Новый текст");

int Method3()
{
    return DateTime.Now.Year;

}

// int year = Method3();
// Console.WriteLine(year);

// string Method4 (int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

// string res = Method4 (10, "da");
// Console.WriteLine(res);

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

// string res = Method4 (10, "da");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

string text = " - Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели бы вас послали вметсо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// string newText = Replace (text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();


// string newText2 = Replace (newText, 'к', 'К');
// Console.WriteLine(newText2);
// Console.WriteLine();

// string newText3 = Replace (newText2, 'с', 'С');
// Console.WriteLine(newText3);
// Console.WriteLine();


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;

    for (i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j= i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }    

        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length ; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }    

        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortMax(arr);

PrintArray(arr);