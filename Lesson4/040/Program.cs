//40. Задать массив из 8 целых элементов и вывести их на экран

int [] array=new int[8];

Random random = new Random(); // описание и создание объекта
for (int i = 0; i < array.Length; i++)
{
    array[i]= random.Next(0,10);

}
for (int i = 0; i<array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();