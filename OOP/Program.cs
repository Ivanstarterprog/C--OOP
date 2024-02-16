using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ElectronicFile
    {
        public string FileName { get; set; }
        public string Author { get; set; }
        public string KeyWords {  get; set; }
        public string Theme { get; set; }
        public string FilePath { get; set; }

        public ElectronicFile(string fileName = "Безымянный" , string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан") 
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
        }
        public virtual void GetTypeOfFile()
        {
            Console.WriteLine("Это универсальный электронный файл");
        }
    }

    class MSWord: ElectronicFile
    {
        public string CreateDate { get; set; }
        public MSWord(string fileName = "Безымянный", string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан", string createDate = "Сегодня") : base(fileName, author, keyWords, theme, filePath)
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
            CreateDate = createDate;
        }

        public override void GetTypeOfFile()
        {
            Console.WriteLine("Это файл ворд");
            Console.WriteLine("Название файла {0}; Автор файла {1}", FileName, Author);
            Console.WriteLine("Файл находится по адресу: {0}", FilePath);
            Console.WriteLine("Файл был создан {0}", CreateDate);

        }
    }

    class PDF : ElectronicFile
    {
        public int NumberOfPages { get; set; }
        public PDF(string fileName = "Безымянный", string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан", int numberOfPage = 1) : base(fileName, author, keyWords, theme, filePath)
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
            NumberOfPages = numberOfPage;
        }

        public override void GetTypeOfFile()
        {
            Console.WriteLine("Это файл PDF");
            Console.WriteLine("Название файла {0}; Автор файла {1}", FileName, Author);
            Console.WriteLine("Файл находится по адресу: {0}", FilePath);
            Console.WriteLine("В файле {0} страниц", NumberOfPages);
        }
    }

    class Excel : ElectronicFile
    {
        public int NumberOfCells { get; set; }
        public Excel(string fileName = "Безымянный", string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан", int numberOfCells = 0) : base(fileName, author, keyWords, theme, filePath)
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
            NumberOfCells = numberOfCells;
        }

        public override void GetTypeOfFile()
        {
            Console.WriteLine("Это файл Excel");
            Console.WriteLine("Название файла {0}; Автор файла {1}", FileName, Author);
            Console.WriteLine("Файл находится по адресу: {0}", FilePath);
            Console.WriteLine("В файле {0} клеточек", NumberOfCells);
        }
    }

    class TXT : ElectronicFile
    {
        public int NumberOfSymbols { get; set; }
        public TXT(string fileName = "Безымянный", string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан", int numberOfSymbols = 0) : base(fileName, author, keyWords, theme, filePath)
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
            NumberOfSymbols = numberOfSymbols;
        }

        public override void GetTypeOfFile()
        {
            Console.WriteLine("Это файл TXT");
            Console.WriteLine("Название файла {0}; Автор файла {1}", FileName, Author);
            Console.WriteLine("Файл находится по адресу: {0}", FilePath);
            Console.WriteLine("В файле {0} Символов", NumberOfSymbols);
        }
    }

    class HTML : ElectronicFile
    {
        public string Language { get; set; }
        public HTML(string fileName = "Безымянный" , string author = "Безымянный", string keyWords = "Ключевых слов нет", string theme = "Без тематики", string filePath = "Путь не указан", string language = "Русский") : base(fileName, author, keyWords, theme, filePath)
        {
            FileName = fileName;
            Author = author;
            KeyWords = keyWords;
            Theme = theme;
            FilePath = filePath;
        }

        public override void GetTypeOfFile()
        {
            Console.WriteLine("Это файл HTML");
            Console.WriteLine("Название файла {0}; Автор файла {1}", FileName, Author);
            Console.WriteLine("Файл находится по адресу: {0}", FilePath);
            Console.WriteLine("На странице используется {0} язык", Language);
        }
    }

    public class Menu
    {
        private static Menu instance;
        private static ElectronicFile electronicFile = new ElectronicFile("Электроник", "Терминатор", "Не придумал", "Наука", "Рабочий стол");
        private static PDF pdfFile = new PDF("Книга", "Гениальный автор", "Не придумал", "Саморазвитие", "Рабочий стол");
        private static MSWord wordFile = new MSWord("Отчёт", "Бухгалтер", "Не придумал", "Экономика", "Рабочий стол/Рабочие документы");
        private static Excel excelFile = new Excel("Главный документ экономики", "Тоже бухгалтер", "Не придумал", "Экономика", "Рабочий стол/Сапёр");
        private static TXT txtFile = new TXT("Па приколу", "Приколист", "Не придумал", "Юмор", "Рабочий стол");
        private static HTML htmlFile = new HTML("Index", "Студент ПИ-231", "Не придумал", "Учёба", "Рабочий стол/новая_папка/Новая_Новая_папка 32");
        public static Menu Instance
        {
            get
            {
                if (instance == null) instance = new Menu();
                return instance;
            }
        }
        public void MenuRender() 
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Выберите тип файла. Для этого необходимо ввести номер типа файла в списке ниже:");
            Console.WriteLine("1. Электронный файл");
            Console.WriteLine("2. Word");
            Console.WriteLine("3. PDF");
            Console.WriteLine("4. Excel");
            Console.WriteLine("5. TXT");
            Console.WriteLine("6. HTML");
            int fileChoice = Convert.ToInt32(Console.ReadLine());
            switch (fileChoice)
            {
                case 1:
                    electronicFile.GetTypeOfFile();
                    break;
                case 2:
                    wordFile.GetTypeOfFile();
                    break;
                case 3:
                    pdfFile.GetTypeOfFile();
                    break;
                case 4:
                    excelFile.GetTypeOfFile();
                    break;
                case 5:
                    txtFile.GetTypeOfFile();
                    break;
                case 6:
                    htmlFile.GetTypeOfFile();
                    break;
                default:
                    Console.WriteLine("Ответ не был понят");
                    break;
            }
        }
        public void Method2() { Console.WriteLine("Singleton.Method2"); }
        private Menu() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.Instance.MenuRender();
                Console.WriteLine("Хотите продолжить? Для этого введите символ Y/y. Для того чтобы закрыть меню введите иной символ: ");
                char menuChoice = Convert.ToChar(Console.ReadLine());
                if (menuChoice != 'Y' && menuChoice != 'y')
                {
                    break;
                }
            }
        }

    }
}
