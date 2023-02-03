
// //Ввести n от 0 до 10 c проверкой ввода
// //1Цикл ДО
// {
//     int n;//область видимости переменных
//     //До тех пора пока
//     do 
//     {
//         n=Convert.ToInt32(Console.ReadLine());    
//     }
//     while(n<0 || n>10);//цикл с постусловием, проверка ввода
// }
//Цикл ДЛЯ(FOR) 
//2вывести на экран числа от 1 до 10
// int i=1;
// while(i<=10)
// {
//     System.Console.WriteLine(i);
//     //i=i+1;
//     i++;
// }

//ЦИКЛ ДЛЯЦикл со счетчиками
// 3for(int i=1,k=100; i<=100 && k>=50; i++,k--)
// {
//     System.Console.WriteLine(i+" "+k);
// }
// 4for(int i=1;i<100 ;i++)
// {
//     System.Console.WriteLine(i);
// }

// string s="ABCDED";
// foreach(char c in s)//работает с коллекциями (реализующими интерфейс IEnumerable)
// {
//     System.Console.WriteLine(c);
//     //c='A';
// }