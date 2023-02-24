// 98. Показать треугольник Паскаля
 // *Сделать вывод в виде равнобедренного треугольника

        int numRows = 10; // количество строк в треугольнике
        int[][] triangle = new int[numRows][]; // создаем двумерный массив

        // Заполняем массив значениями треугольника Паскаля
        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;
            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        // Выводим треугольник
        for (int i = 0; i < numRows; i++)
        {
            // Добавляем отступы слева для создания равнобедренного треугольника
            for (int k = numRows - i; k > 0; k--)
            {
                Console.Write("  ");
            }

            // Выводим значения в строке
            for (int j = 0; j <= i; j++)
            {
                Console.Write("{0,4}", triangle[i][j]);
            }

            Console.WriteLine();
        }

        Console.ReadKey();
