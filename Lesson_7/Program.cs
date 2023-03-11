string input(string words) {
    Console.Write(words);
    return Console.ReadLine();
}
void print_double_array (int[,] array, int length1, int length2) {
    Console.Write("[");
    for (int i = 0; i < length1 - 1; i++) {
        Console.Write("[");
        for (int j = 0; j < length2 - 1; j++) {
            Console.Write(array[i, j] + ", ");
        }
        Console.Write(array[i, length2 - 1] + "]," + Environment.NewLine);
    }
    Console.Write("[");
    for (int j = 0; j < length2 - 1; j++) {
            Console.Write(array[length1 - 1, j] + ", ");
        }
        Console.Write(array[length1 - 1, length2 - 1] + "]]" + Environment.NewLine);
    return;
}
void array_init (int[,] array, int length1, int length2, int a, int b) {
    for (int i = 0; i < length1; i++) {
        for (int j = 0; j < length2; j++) {
            array[i, j] = new Random().Next(a, b);
        }  
    }
    return;
}
/* 47 */
int m = int.Parse(input("Введите число m: "));
int n = int.Parse(input("Введите число n: "));
int[,] array = new int[m, n];
array_init(array, array.GetLength(0), array.GetLength(1), 1, 100);
/* Для удобства заполняю массив целыми числами */
print_double_array(array, array.GetLength(0), array.GetLength(1));
/* 50 */
/* Дополнение к 47 */
int x = int.Parse(input("Введите число x: ")) - 1;
int y = int.Parse(input("Введите число y: ")) - 1;
if (x < 0 | x >= array.GetLength(0) | y < 0 | y >= array.GetLength(1)) {
    Console.Write("Точка находится за пределами массива!" + Environment.NewLine);
} else {
    Console.Write($"Значение точки ({x + 1}, {y + 1}) = " + array[x, y] + Environment.NewLine);
}
/* 52 */
/* Дополнение к 47 */
double avgg;
double avg (int[,] array, int length, int col) {
    avgg = 0;
    for (int i = 0; i < length; i++) {
        avgg += array[i, col];
    }
    return avgg / length;
}
for (int i = 0; i < array.GetLength(1); i++) {
    Console.Write($"Среднее арифметическое {i + 1}-го столбца = " + avg(array, array.GetLength(0), i) + Environment.NewLine);
}