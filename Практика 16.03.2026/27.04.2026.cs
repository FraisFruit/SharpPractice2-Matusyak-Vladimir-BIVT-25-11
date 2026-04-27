using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Movie
        {
            private string _name;
            private int _duration;
            private int[] _review;

            public string Name { get { return _name; } }
            public int Duration { get { return _duration; } }
            public int[] Review => _review.ToArray();

            public Movie(string name, int duration)
            {
                _name = name;
                _duration = duration;
                _review = new int[0];
            }

            public void Add(int num)
            {
                Array.Resize(ref _review, _review.Length + 1);
                _review[_review.Length - 1] = num;
            }
        }
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Harry Potter", 102);
            movie1.Add(5);
            movie1.Add(4);
            movie1.Add(3);

            var temp = new
            {
                MovieType = movie1.GetType().Name,
                movie1.Name,
                movie1.Duration,
                movie1.Review
            };

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "Test", "example.txt");

            string json = JsonConvert.SerializeObject(temp);
            File.WriteAllText(filePath, json);

            // - десериализация
            string content = File.ReadAllText(filePath);
            var contentToJson = JsonConvert.DeserializeObject<dynamic>(content);
            Console.WriteLine(contentToJson.Name);

            Movie movie2 = new Movie((string)newJson.Name, (int)newJson.Duration);
            foreach (var n in newJson.Review)
            {
                movie2.Add((int)n);
            }
            Console.WriteLine(CompareMovies(movie1, movie2));
            // Получение путей к папке

            // Абсолютный путь - путь до файла на вашем компьютере, начиная с корневой папки

            // Относительный путь - путь до файла, относительно чего-то
            // "dataset/data.txt"

            // Console.WriteLine(folderPath);
            //Console.WriteLine(filePath);

            string folderPath1 = Path.Combine(folderPath, "Test");
            string filePath1 = Path.Combine(folderPath1, "example.txt");

            string folderPath1Check = Path.GetDirectoryName(filePath1);
            string fileNameCheck = Path.GetFileName(filePath1);
            string fileExtCheck = Path.GetExtension(filePath1);
            Console.WriteLine(folderPath1Check);
            Console.WriteLine(fileNameCheck);
            Console.WriteLine(fileExtCheck);
            if (Directory.Exists(filePath1))
            {
                Directory.CreateDirectory(folderPath1);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            File.WriteAllText(filePath, "Hey!");
            File.WriteAllLines(filePath, new string[] { "So", "cold", "today" });

            File.WriteAllText(filePath, "");
            File.AppendAllText(filePath, "Wohoo");
            File.AppendAllLines(filePath, new string[] { "No", "idea" });

            // Записывает в файл строку
            // Если файла не было - создаёт и записывает
            // Если файл был - ПЕРЕзаписывает содержимое (удаляет старое и записывает новое)

            //string content = File.ReadAllText(filePath);
            //string[] lines = File.ReadAllLines(filePath);
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //File.Delete(filePath);
        }
            private bool CompareMovies(Moviem1, Moviem2)
            {
                if (m1.Name)
            }
    }
}
