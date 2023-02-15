// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1


Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine());
int first = 0, second = 1, next;

Console.WriteLine(first);
Console.WriteLine(second);

for (int i = 2; i < N; i++)
{
    next = first + second;
    Console.WriteLine(next);
    first = second;
    second = next;
}
