namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Link запросы

            // 1. Contains - содержит ли? тип bool
            Console.WriteLine("1. Contains");
            string word = "Hello";
            Console.WriteLine(word.Contains("ll")); // Результат - true
            if (word.Contains("lo"))
                Console.WriteLine("Success");
            else
                Console.WriteLine("Failure");

            char[] example = { 'a', '.', '0' };
            Console.WriteLine(example.Contains(',')); // Результат - false

            char[] punc = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            char x = 'a';
            if (punc.Contains(x))
                Console.WriteLine("The symbol is punc");
            else
                Console.WriteLine("It is punc");
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 2. Replace - заменить
            Console.WriteLine("2. Replace");
            string text = "Cat dog love";
            Console.WriteLine(text.Replace("dog", "more cats"));
            string text1 = "Boys like cars";
            text1 = text1.Replace("like", "buy");
            Console.WriteLine(text1);
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 3. Trim - удаление символов по краям
            Console.WriteLine("3. Trim");
            string word2 = "!?cat,";
            Console.WriteLine(word2);
            word2 = word2.Trim(punc);
            Console.WriteLine(word2);
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 4. Split - разделяет
            Console.WriteLine("4. Split");
            string text2 = "Hello, my dear 2 friends!";
            string[] dirtyWords = text2.Split(punc, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < dirtyWords.Length; i++)
                Console.WriteLine(dirtyWords[i]);
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 5. Join - соединяет 
            Console.WriteLine("5. Join");
            string text3 = String.Join(" ", dirtyWords);
            Console.WriteLine(text3);
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 6. IsDigit/IsLetter - цифра или буква? тип bool
            Console.WriteLine("6. IsDigit/IsLetter");
            char s = 'a';
            Console.WriteLine(Char.IsDigit(s)); // Результат - false
            Console.WriteLine(Char.IsLetter(s)); // Результат - true
            Console.WriteLine(Char.IsPunctuation(s)); // Результат - false
            Console.WriteLine(Char.IsLower(s)); // Результат - true
            Console.WriteLine(Char.IsUpper(s)); // Результат - false
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();


            // 7. ToUpper/ToLower - текст маленькими или большими буквами
            Console.WriteLine("7. ToUpper/ToLower");
            string word3 = "Hello";
            Console.WriteLine(word3.ToLower()); // Результат - hello
            Console.WriteLine(word3.ToUpper()); // Результат - HELLO

            string vowels = "ёуеыаоэяию";
            vowels += vowels.ToUpper();
            Console.WriteLine(vowels);
            Console.WriteLine();
            Console.WriteLine("======");
            Console.WriteLine();

            // Задача. Вынести в массив все слова в тексте (посчитать кол-во)
            string input = "Hello, my dear 2 friends!";
            int count = 0;
            Console.WriteLine(input);
            string[] dirtyWords2 = input.Split(' ');
            string[] cleanWords = new string[0];
            for (int i = 0; i < dirtyWords2.Length; i++)
            {
                string trimWord = dirtyWords2[i].Trim(punc);
                Console.WriteLine(trimWord);

                bool f = true;
                foreach (char symbol in trimWord)
                {
                    if (char.IsDigit(symbol) || punc.Contains(symbol))
                        f = false; break;
                }
                if (trimWord != "" && f == true)
                {
                    count++;
                    Array.Resize(ref cleanWords, cleanWords.Length + 1);
                    cleanWords[cleanWords.Length - 1] = trimWord.ToLower();
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
            foreach (var cw in cleanWords)
                Console.Write($"{cw} ");
        }
    }
}
