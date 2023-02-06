//31.Вывести на экран кубы чисел от 1 до N

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "    " + (i * i * i));
            }