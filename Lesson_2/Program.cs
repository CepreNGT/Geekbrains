/* Task 10 */
int num1 = int.Parse(Console.ReadLine());
if (num1 > 99 & num1 < 1000) {
    Console.Write((num1 / 10) % 10 + Environment.NewLine);
} else {
    Console.Write("Неверный ввод" + Environment.NewLine);
}
/* Task 13 */
int num2 = int.Parse(Console.ReadLine());
if (num2 < 100) {
    Console.Write("Третьей цифры нет" + Environment.NewLine);
} else {
    while (num2 > 999) {
        num2 /= 10;
    }
    Console.Write(num2 % 10 + Environment.NewLine);
}
/* Task 15 */
int num3 = int.Parse(Console.ReadLine());
if (num3 < 8 & num3 > 0) {
    if (num3 == 7 | num3 == 6) {
        Console.Write("Выходной)" + Environment.NewLine);
    } else {
        Console.Write("Будний(" + Environment.NewLine);
    }
} else {
    Console.Write($"Нет {num3} дня недели!" + Environment.NewLine);
}