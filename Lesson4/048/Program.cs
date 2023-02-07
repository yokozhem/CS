//48.Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N=10;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");

int [] result=new int[N/2];
for (int i = 0; i < N/2; i++)
{
    result[i]=a[i]*a[N-1-i];
}
System.Console.WriteLine();
System.Console.WriteLine(string.Join(" ", result));