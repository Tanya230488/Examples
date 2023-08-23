
int TwoDigit (int num)
{
    int firstDigit = num / 100;
     // int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;

    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int number = new Random().Next(100, 1000);
int twoDigit = TwoDigit (number);

Console.WriteLine($"Двузначное число из числа {number} это {twoDigit}"); 