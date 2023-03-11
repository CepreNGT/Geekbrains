void array_init (int[] array, int length, int a, int b) {
    for (int i = 0; i < length; i++) {
        array[i] = new Random().Next(a, b);
    }
    return;
}
void print_array (int[] array, int length) {
    Console.Write("[");
    for (int i = 0; i < length - 1; i++) {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[length - 1] + "]" + Environment.NewLine);
    return;
}
/* 34 */
int evens (int[] array, int length){
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}
int length = new Random().Next(5, 20);
int[] array = new int[length];
array_init(array, length, 100, 999);
print_array(array, length);
Console.Write("Чётных чисел: " + evens(array, length) + Environment.NewLine);
/* 36 */
int sum_odd (int[] array, int length) {
    int summ = 0;
    for (int i = 1; i < length; i += 2) {
        summ += array[i];
    }
    return summ;
}
int length1 = new Random().Next(5, 20);
int[] array1 = new int[length1];
array_init(array1, length1, -100, 100);
print_array(array1, length1);
Console.Write("Сумма нечетных элементов = " + sum_odd(array1, length1) + Environment.NewLine);
/* 38 */
int max (int a, int b) {
    if (a > b) {
        return a;
    }
    return b;
}
int min (int a, int b) {
    if (a > b) {
        return b;
    }
    return a;
}
int length2 = new Random().Next(5, 20);
int[] array2 = new int[length2];
/* Для простоты работы создал массив целых чисел */
array_init(array2, length2, 1, 100);
print_array(array2, length2);
int maxx = 0;
int minn = array2[0];
for (int i = 0; i < length2; i++) {
    maxx = max(maxx, array2[i]);
    minn = min(minn, array2[i]);
}
Console.Write($"Разность между максимальным({maxx}) и минимальным({minn}) = " + (maxx - minn));
