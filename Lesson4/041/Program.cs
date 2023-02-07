// 41.З адать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] a=new int[8];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,2);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");