using System;

/* 25 */
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++) {
    result *= A;
}
Console.Write(result + Environment.NewLine);
/* 27 */
int num = int.Parse(Console.ReadLine());
int summ = 0;
while (num != 0) {
    summ += num % 10;
    num /= 10;
}
Console.Write(summ + Environment.NewLine);
/* 29 */
int length = 8;
int[] array = new int[length];
Console.Write("[");
for (int i = 0; i < length - 1; i++) {
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + ", ");
}
array[length - 1] = new Random().Next(1, 100);
Console.Write(array[length - 1] + "]");