// 96. 96. В двумерном массиве целых чисел. Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.


int[,] arr = {
            { 5, 8, 2, 9 },
            { 1, 4, 6, 7 },
            { 3, 2, 9, 8 },
            { 4, 7, 5, 3 }
        };

        int min = int.MaxValue;
        int minRow = 0, minCol = 0;

        // Находим строку и столбец, содержащие наименьший элемент
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(arr);

        // Удаляем строку с наименьшим элементом
        int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1)];
        for (int i = 0, k = 0; i < arr.GetLength(0); i++)
        {
            if (i != minRow)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[k, j] = arr[i, j];
                }
                k++;
            }
        }

        // Удаляем столбец с наименьшим элементом
        arr = new int[newArr.GetLength(0), newArr.GetLength(1) - 1];
        for (int i = 0; i < newArr.GetLength(0); i++)
        {
            for (int j = 0, k = 0; j < newArr.GetLength(1); j++)
            {
                if (j != minCol)
                {
                    arr[i, k] = newArr[i, j];
                    k++;
                }
            }
        }

        Console.WriteLine("Массив после удаления строки и столбца с наименьшим элементом:");
        PrintArray(arr);

        Console.ReadKey();
    

     void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

