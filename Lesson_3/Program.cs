using System;

/* Task 19 */
int number = int.Parse(Console.ReadLine());
if (number < 10000 | number > 99999) {
    Console.Write($"Число {number} не пятизначное!" + Environment.NewLine);
} else {
    if (number / 10000 == number % 10 & (number % 10000) / 1000 == (number % 100) / 10) {
        Console.Write($"Число {number} - палиндром" + Environment.NewLine);
    } else {
        Console.Write($"Число {number} - не палиндром" + Environment.NewLine);
    }
}
/* Task 21 */
Console.Write("Введите координаты точки A:"  + Environment.NewLine + "x: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("y: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("z: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B:"  + Environment.NewLine + "x: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("z: ");
double z2 = double.Parse(Console.ReadLine());
double AB = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2), 0.5);
Console.Write($"AB = {AB}"  + Environment.NewLine);
/* Task 23 */
int N = int.Parse(Console.ReadLine());
for (int i = 1; i < N; i++) {
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.Write(Math.Pow(N, 3));