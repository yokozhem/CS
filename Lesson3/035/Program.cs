
// 35. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumOfDigits (int n)
{
    int sum = 0;
    while (n > 0)
    {
    sum += n % 10;
    n /= 10;
    }

           return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ответ: " + SumOfDigits(number));   

