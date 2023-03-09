// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
// Вычислить сумму цифр введенного числа

System.Console.WriteLine("Введите целое число: ");

string input=Console.ReadLine();
int number;
bool isNumber = int.TryParse(input, out number);
if (isNumber) 
{
    Console.WriteLine("Введенное значение является целым числом");
    int sum = 0;
    foreach (char c in input) 
    {
        if (Char.IsDigit(c)) 
        {
            sum += int.Parse(c.ToString());
        }
    }
    Console.WriteLine($"Сумма цифр введенного числа: {sum}");
} else 
{   
    Console.WriteLine("Введенное значение не является целым числом");
}