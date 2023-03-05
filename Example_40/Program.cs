// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();

Console.WriteLine("Введите размеры трёх сторон возможного треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

CheckTriangles(a, b, c);


void CheckTriangles(int FirstSide, int SecondSide, int ThirdSide)
{
    if(FirstSide + SecondSide > ThirdSide && FirstSide + ThirdSide > SecondSide && SecondSide + ThirdSide > FirstSide)
    Console.WriteLine("Такой треугольник может существовать");
    else
    Console.WriteLine("Таких треугольников не бывает");
}