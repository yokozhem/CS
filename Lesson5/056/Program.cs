// 56. Написать программу копирования массива


int [] array={1,2,3,4,5,6,7,8,9};
int[]copy = new int[array.Length];
array.CopyTo(copy,0);
PrintArray(array);
PrintCopy(copy);

        


//System.Console.WriteLine(String.Join (", ", array));
// System.Console.WriteLine();
// System.Console.WriteLine("--------------------------");
// Console.WriteLine(String.Join(", ", copy));


void PrintArray(int[]array)
{
    System.Console.WriteLine(String.Join (", ", array));
}
void PrintCopy(int[]copy)
{
    System.Console.WriteLine(String.Join (", ", copy));
}