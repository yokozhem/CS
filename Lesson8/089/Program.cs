// 89. Подсчитать сумму цифр, встречающихся в строке

string str = "Test 123 string 456.";
int sum = 0;

foreach(char c in str)
{
    if(Char.IsDigit(c))
    {
        sum+=(int)Char.GetNumericValue(c);
    }
}
System.Console.WriteLine($"Сумма цифр в строке '{str}' равна {sum}");