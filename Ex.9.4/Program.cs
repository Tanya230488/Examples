// пр кот принимает на вход 2 числа и возводит одно в степень второго


int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

// int NumDegree (int num1, int num2)
// {
//     if(num2 == 0) return 1;
//     return num1 * NumDegree(num1,num2-1);
// }

// int number = ImputNum("Введите число: ");
// int degree = ImputNum("Введите степень: ");
// Console.WriteLine($"Число {number} в степени {degree} равно {NumDegree(number, degree)} ");

double NumDegree2 (int num1, int degree)
{
    if(degree == 0) return 1;
    if(degree > 0) return num1 * NumDegree2(num1,--degree);
    return 1.0 / num1 * NumDegree2(num1,++degree);
}

int number = ImputNum("Введите число: ");
int degree = ImputNum("Введите степень: ");
Console.WriteLine($"Число {number} в степени {degree} равно {NumDegree2(number, degree):f3} ");
