// task39 Напишите программу, которя на вход принримает 3 числа и проверяет,
// может лис уществовать треугольник с сторонами такой длины. Теорема о 
// неравенсте треугольника: каждая сторона треугольника меньше суммы двух
// других сторон

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число: ");
int b  = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число: ");
int c  = Convert.ToInt32(Console.ReadLine()); 
if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Может");
else
    Console.WriteLine("Не может");
