string input(string words) {
    Console.Write(words);
    return Console.ReadLine();
}
void print_array (int[] array, int length) {
    Console.Write("[");
    for (int i = 0; i < length - 1; i++) {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[length - 1] + "]" + Environment.NewLine);
    return;
}

/* 41 */
int M = int.Parse(input("Введите число M: "));
int[] array = new int[M];
int count = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = int.Parse(input($"Введите {i + 1}-е число: "));
    if (array[i] > 0) {
        count++;
    }
}
print_array(array, array.Length);
Console.Write("Кол-во положительных чисел: " + count + Environment.NewLine);

/* 43 */
Tuple<double, double> crossing(double k1, double b1, double k2, double b2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return Tuple.Create(x, y);
}
double k1 = double.Parse(input("Введите число k1: "));
double b1 = double.Parse(input("Введите число b1: "));
double k2 = double.Parse(input("Введите число k2: "));
double b2 = double.Parse(input("Введите число b2: "));
if (k1 - k2 == 0) {
    if (b1 == b2) {
        Console.Write("Функции совпадают" + Environment.NewLine);
    } else {
        Console.Write("Функции не пересекаются" + Environment.NewLine);
    }
} else {
    Console.Write($"Функции пересекаются в точке {crossing(k1, b1, k2, b2)}" + Environment.NewLine);
}