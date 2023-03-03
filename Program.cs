using System;
/* Task 4 */
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2) {
    if (num1 > num3) {
        Console.Write(num1);
    }
    else {
        Console.Write(num3);
    }
}
else {
    if (num2 > num3) {
        Console.Write(num2);
    }
    else {
        Console.Write(num3);
    }
}
/* Task 6 */
int num4 = int.Parse(Console.ReadLine());
if (num4 < 0) {
    num4 = num4 * -1;
}
if (num4 % 2 == 1) {
    Console.Write("Нет");
}
else {
    Console.Write("Да");
}
/* Task 8 */
int num5 = int.Parse(Console.ReadLine());
for (int i = 2; i < num5 + 1; i++) {
    if (i % 2 == 0) {
        Console.Write(i + " ");
    }
}
/* Task 7 */
int num6 = int.Parse(Console.ReadLine());
Console.Write(num6 % 10);