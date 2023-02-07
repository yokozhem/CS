//43. Написать подпрограмму замены элементов целочисленного массива типа int на противоположные по значению. 
//Подпрограмма принимает на вход массив и в нем же и меняет значения.

int[] a=new int[10];               // Инициализация массива
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} "); // Вывод массива

void ReplaceWithOpposite(int [] a) //Создание метода замены
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i]=-a[i];
    }
    
}
System.Console.WriteLine();
ReplaceWithOpposite(a);
Console.WriteLine(string.Join(" ", a)); //Вывод замены

