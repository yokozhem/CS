// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку


 string st = "This is a test string.";
        string w = "test";
        string v = "example";

        Console.WriteLine($"Исходная строка: {st}");

        string newString = st.Replace(w, v);

        Console.WriteLine($"Конечная строка: {newString}");
