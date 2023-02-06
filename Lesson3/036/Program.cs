// 36. Написать программу вычисления произведения чисел от 1 до N

int Multiplication (int n)
{
    int mult=1;
    while(n>0)
    {
        mult*=n%10;
        n /= 10;
    }
    return mult;
}
System.Console.WriteLine("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ответ: " +Multiplication(number));