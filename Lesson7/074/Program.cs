// 74.Найти сумму цифр числа

int SumDidgits(int number)
{
    if(number<10) return number;
    else
    {
        int lastDigit=number%10;
        int remainingNumber= number/10;
        return lastDigit + SumDidgits(remainingNumber);
    } 
}

System.Console.WriteLine(SumDidgits(1347627623));