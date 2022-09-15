System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Summa(int N) {
    int count = Convert.ToString(N).Length;
    int variable = 0;
    int result = 0;

    for (int i = 0; i < count; i++) {
        variable = N - N % 10;
        result = result + (N - variable);
        N = N / 10;
    }
    return result;
}

int sum = Summa(N);
System.Console.WriteLine($"Сумма цифр числа N: {sum}");

