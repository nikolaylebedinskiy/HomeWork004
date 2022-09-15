System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введиту число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Exponent(int A, int B) {
    int result = 1;
    for(int i = 1; i<= B; i++) {
        result = result * A;
    }
    return result;
}
int exponent = Exponent( A, B);
System.Console.WriteLine($"Число А в степени В равно: {exponent}");


