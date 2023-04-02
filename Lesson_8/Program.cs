/* Task 1 */ 

int print_nums (int N) {
    Console.Write(N);
    if (N == 1) {
        Console.Write(Environment.NewLine);
        return 1;
    }
    Console.Write(", ");
    return print_nums(N - 1);
}
int NN = int.Parse(Console.ReadLine());
print_nums(NN);
/* Task 2 */ 
int sum(int M, int N){
    if (M == N) {
        return M;
    }
    return M + sum(M + 1, N);
}
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int summ = sum(M, N);
Console.Write(summ + Environment.NewLine);
/* Task 3 */
int akkerman(int n, int m){
    if (n == 0) {
        return m + 1;
    }
    if (m == 0) {
        return akkerman(n - 1, 1);
    } else {
        return akkerman(n - 1, akkerman(n, m - 1));
    }
}
int m1 = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
Console.Write(akkerman(m1, n1) + Environment.NewLine);