//33.Возведите число А в натуральную степень B используя цикл
  
int PowerDigits(int a, int b)
{
    int result = 1;
    for (int i = 1; i <=b; i++)
    {
        result*=a;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень будем возводить: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ответ: " +PowerDigits(A,B));










// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("В какую степень будем возводить: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= B; i++)
// {
//     result *= A;
// }

//             Console.WriteLine(A + " в степени " + B + " = " + result);
        