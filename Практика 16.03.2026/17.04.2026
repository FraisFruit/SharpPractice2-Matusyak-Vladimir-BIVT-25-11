using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Link запросы

            // Sum, Count, Max/Min
            int[] numbers = { 1, 2, 3, 4, 5, };
            int result = numbers.Sum(); // Результат: 15

            string[] words = { "hello", "my", "friend" };
            result = words.Sum(x => x.Length);
            int result2 = words.Count(x => x.Length % 2 == 0);

            Example[] examples = new Example[3];
            for (int i = 0; i < 3; i++)
            {
                examples[i] = new Example(i);
            }
            result = examples.Sum(x => x.Num);


            // Any, All
            bool f1 = words.Any(x => x.Length % 3 == 0);
            bool f2 = words.All(x => x.Length > 1);
            Console.WriteLine(f1); // Результат True
            Console.WriteLine(f2); // Результат True


            // Select, Where, Distinct, GroupBy
            int[] wordsLength = words.Select(x => x.Length).ToArray();
            string[] LongWords = words.Where(x => x.Length > 2).ToArray();

            int[] wordsResult = words.Select(x => x.Length).
                                        Where(x => x > 2).
                                        ToArray();

            string word = "hello123";
            char[] wordChars = word.ToCharArray();
            bool f = wordChars.Any(x => char.IsDigit(x));
        }
        public struct Example
        {
            private int _num;
            public int Num => _num;
            public Example(int num)
            {
                _num = num;
            }
        }
    }
}
