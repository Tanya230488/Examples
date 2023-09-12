//   Пр кот принимает на вход три числа и проверяет может ли сущ треугольник со сторонамитакой длины
// Теорема - каждая сторона треугольника должна быть меньше суммы длин двух других сторон

int ImputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}


bool Triangle(int num1, int num2, int num3)
{
//    if ((num1 + num2) > num3 & (num1 + num3) > num2 & (num3 + num2) > num1)
//     return true;
//    else
//     return false;
    return (num1 + num2) > num3 & (num1 + num3) > num2 & (num3 + num2) > num1;
}

int side1 = ImputNum("Введите значение стороны 1: ");
int side2 = ImputNum("Введите значение стороны 2: ");
int side3 = ImputNum("Введите значение стороны 3: ");
bool res = Triangle(side1, side2, side3);
Console.WriteLine(res == true?"Да":"Нет");


