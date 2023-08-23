// int secondDigit = num % 10;
// int firstDigit = num / 10;
// int max = firstDigit;

// if (firstDigit < secondDigit);
//     max = secondDigit;

// Console.WriteLine($"В числе {num} максимальная цифра {max}"); 

int MaxDigit (int num)
{
    int secondDigit = num % 10;
    int firstDigit = num / 10;
    int max = firstDigit;

    if (firstDigit < secondDigit);
    max = secondDigit;

    return max;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit (number);

Console.WriteLine($"В числе {number} максимальная цифра {maxDigit}"); 