// 89a. ***В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова (слова не обязательно осмысленные), состоящие из n букв, 
//которые можно построить из букв этого алфавита. Здесь используется рекурсия.




void PrintWords(string currentWord, string[] letters, int n)
 {
        if (currentWord.Length == n) {
            Console.WriteLine(currentWord);
            return;
        }

        for (int i = 0; i < letters.Length; i++) {
            PrintWords(currentWord + letters[i], letters, n);
        }
 }


string[] letters = { "а", "и", "с", "в" };
int n = 4;
Console.WriteLine($"Все слова, состоящие из {n} букв:");
 PrintWords("", letters, n);
