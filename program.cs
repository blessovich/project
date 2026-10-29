using System;
using System.IO;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== УНИВЕРСАЛЬНЫЙ ТЕРМИНАЛ ЗАДАЧ ПО ПЕРЕГРУЗКЕ МЕТОДОВ ===");
            Console.WriteLine("Выберите номер задачи (от 1 до 25) или 0 для выхода:");
            Console.WriteLine(" 1. Автомобиль (ShowInfo)");
            Console.WriteLine(" 2. Студент (CalculateGrade)");
            Console.WriteLine(" 3. Система скидок (CalculateDiscount)");
            Console.WriteLine(" 4. Доставка товара (CalculateDelivery)");
            Console.WriteLine(" 5. Книга (DisplayBook)");
            Console.WriteLine(" 6. Игровые очки (AddScore)");
            Console.WriteLine(" 7. Файлы (SaveFile)");
            Console.WriteLine(" 8. Геометрия (CalculateVolume)");
            Console.WriteLine(" 9. Такси (CalculateFare)");
            Console.WriteLine("10. Библиотека (SearchBook)");
            Console.WriteLine("11. Массивы (Sort)");
            Console.WriteLine("12. Статистика массива (Analyze)");
            Console.WriteLine("13. Проверка пароля (ValidatePassword)");
            Console.WriteLine("14. Конвертер валют (ConvertCurrency)");
            Console.WriteLine("15. Дата и время (FormatDate)");
            Console.WriteLine("16. Система уведомлений (SendNotification)");
            Console.WriteLine("17. Управление сотрудниками (CreateEmployee)");
            Console.WriteLine("18. Товары на складе (UpdateStock)");
            Console.WriteLine("19. Математическая библиотека (Calculate)");
            Console.WriteLine("20. Система авторизации (Login)");
            Console.WriteLine("21. Обработка изображений (ResizeImage)");
            Console.WriteLine("22. Транспортная система (CalculateFuelCost)");
            Console.WriteLine("23. Магазин электроники (CalculateFinalPrice)");
            Console.WriteLine("24. Система оценивания (EvaluateStudent)");
            Console.WriteLine("25. Мини-проект «Универсальный помощник» (Helper)");
            Console.Write("\nВаш выбор: ");

            string input = Console.ReadLine();
            if (input == "0") break;

            Console.WriteLine("\n--- ВЫПОЛНЕНИЕ ЗАДАЧИ ---\n");

            switch (input)
            {
                case "1": RunCar(); break;
                case "2": RunStudent(); break;
                case "3": RunDiscount(); break;
                case "4": RunDelivery(); break;
                case "5": RunBook(); break;
                case "6": RunPlayer(); break;
                case "7": RunFiles(); break;
                case "8": RunGeometry(); break;
                case "9": RunTaxi(); break;
                case "10": RunLibrary(); break;
                case "11": RunArraySorter(); break;
                case "12": RunArrayAnalyzer(); break;
                case "13": RunPasswordValidator(); break;
                case "14": RunCurrencyConverter(); break;
                case "15": RunDateFormatter(); break;
                case "16": RunNotifier(); break;
                case "17": RunEmployee(); break;
                case "18": RunStockManager(); break;
                case "19": RunMathLibrary(); break;
                case "20": RunAuthService(); break;
                case "21": RunImageProcessor(); break;
                case "22": RunFuelCalculator(); break;
                case "23": RunPriceCalculator(); break;
                case "24": RunEvaluationSystem(); break;
                case "25": RunHelperProject(); break;
                default: Console.WriteLine("Неверный выбор. Попробуйте снова."); break;
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }


    static void RunCar() {
        var car = new Car { Brand = "Toyota" };
        car.ShowInfo();
        car.ShowInfo(2022);
        car.ShowInfo(2023, 35000m);
    }

    static void RunStudent() {
        var s = new StudentGrades();
        Console.WriteLine($"Оценка 1 балл (85): {s.CalculateGrade(85)}");
        Console.WriteLine($"Оценка 2 балла (80, 90): {s.CalculateGrade(80, 90)}");
        Console.WriteLine($"Оценка 3 балла (70, 80, 90): {s.CalculateGrade(70, 80, 90)}");
    }

    static void RunDiscount() {
        var d = new DiscountSystem();
        Console.WriteLine($"Скидка 15%: {d.CalculateDiscount(1000m, 15.0)}");
        Console.WriteLine($"Фиксированная скидка 500: {d.CalculateDiscount(1000m, 500)}");
    }

    static void RunDelivery() {
        var del = new Delivery();
        Console.WriteLine($"Обычная: {del.CalculateDelivery("обычная")}");
        Console.WriteLine($"Срочная: {del.CalculateDelivery("срочная", true)}");
        Console.WriteLine($"По весу (5.5 кг): {del.CalculateDelivery(5.5, 120m)}");
    }

    static void RunBook() {
        var book = new Book { Title = "Война и мир" };
        book.DisplayBook();
        book.DisplayBook("Л. Толстой");
        book.DisplayBook("Л. Толстой", 1869);
    }

    static void RunPlayer() {
        var p = new Player();
        p.AddScore(50);
        Console.WriteLine($"Очки после +50: {p.Score}");
        p.AddScore(20, 10);
        Console.WriteLine($"Очки после бонуса: {p.Score}");
        p.AddScore(10, 1.5);
        Console.WriteLine($"Очки после множителя: {p.Score}");
    }

    static void RunFiles() {
        var fm = new FileManager();
        string path = "test.txt";
        fm.SaveFile(path, "Привет мир!");
        Console.WriteLine("Файл успешно сохранен с текстом.");
        if (File.Exists(path)) File.Delete(path);
    }

    static void RunGeometry() {
        var g = new Geometry();
        Console.WriteLine($"Объем куба (сторона 3): {g.CalculateVolume(3)}");
        Console.WriteLine($"Объем параллелепипеда (2,3,4): {g.CalculateVolume(2, 3, 4)}");
        Console.WriteLine($"Объем цилиндра (r=2, h=5): {g.CalculateVolume(2, 5, true)}");
    }

    static void RunTaxi() {
        var t = new TaxiService();
        Console.WriteLine($"По расстоянию (10 км): {t.CalculateFare(10)}");
        Console.WriteLine($"С ожиданием (10 км, 5 мин): {t.CalculateFare(10, 5)}");
        Console.WriteLine($"С классом авто (10 км, VIP): {t.CalculateFare(10, "VIP")}");
    }

    static void RunLibrary() {
        var lib = new LibraryCatalog();
        lib.SearchBook("Чистый код");
        lib.SearchBook("Роберт Мартин", true);
        lib.SearchBook("Чистый код", "Роберт Мартин");
    }

    static void RunArraySorter() {
        var sorter = new ArraySorter();
        int[] arr = { 5, 2, 9, 1 };
        sorter.Sort(arr);
        Console.WriteLine("Отсортированный int[]: " + string.Join(", ", arr));
    }

    static void RunArrayAnalyzer() {
        var analyzer = new ArrayAnalyzer();
        int[] arr = { 10, 20, 5, 40 };
        analyzer.Analyze(arr, out int min, out int max, out double avg);
        Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg}");
    }

    static void RunPasswordValidator() {
        var v = new PasswordValidator();
        Console.WriteLine($"Пароль '123' длина >= 8: {v.ValidatePassword("123")}");
        Console.WriteLine($"Пароль 'Secret123' (длина + цифры): {v.ValidatePassword("Secret123", true)}");
        Console.WriteLine($"Пароль 'Secret123!' (длина + цифры + спец): {v.ValidatePassword("Secret123!", true, true)}");
    }

    static void RunCurrencyConverter() {
        var c = new CurrencyConverter();
        Console.WriteLine($"По курсу (100 * 480): {c.ConvertCurrency(100m, 480m)}");
        Console.WriteLine($"С комиссией (100 * 480 + 50): {c.ConvertCurrency(100m, 480m, 50m)}");
    }

    static void RunDateFormatter() {
        var df = new DateFormatter();
        Console.WriteLine($"DateTime: {df.FormatDate(DateTime.Now)}");
        Console.WriteLine($"Строка: {df.FormatDate("2026-10-29")}");
        Console.WriteLine($"С временем: {df.FormatDate(DateTime.Now, true)}");
    }

    static void RunNotifier() {
        var n = new Notifier();
        n.SendNotification("Простое сообщение");
        n.SendNotification("Внимание", "Системное предупреждение");
        n.SendNotification("Срочно", "Проверка связи", "Алексей");
    }

    static void RunEmployee() {
        var ec = new EmployeeCreator();
        var e = ec.CreateEmployee("Иван", "Менеджер", 75000m);
        Console.WriteLine($"Сотрудник: {e.Name}, Должность: {e.Position}, Зарплата: {e.Salary}");
    }

    static void RunStockManager() {
        var sm = new StockManager();
        int stock = 100;
        stock = sm.IncreaseStock(stock, 50);
        Console.WriteLine($"После увеличения: {stock}");
        stock = sm.DecreaseStock(stock, 30);
        Console.WriteLine($"После уменьшения: {stock}");
        stock = sm.SetStock(500);
        Console.WriteLine($"После установки нового значения: {stock}");
    }

    static void RunMathLibrary() {
        var ml = new MathLibrary();
        Console.WriteLine($"Сумма (int): {ml.Calculate(5, 10)}");
        Console.WriteLine($"Разность (double): {ml.Calculate(10.5, 4.2)}");
        Console.WriteLine($"Произведение (decimal): {ml.Calculate(10m, 5m, true)}");
    }

    static void RunAuthService() {
        var auth = new AuthService();
        Console.WriteLine($"Логин и пароль: {auth.Login("admin", "12345")}");
        Console.WriteLine($"Email и пароль: {auth.Login("test@mail.ru", "12345", true)}");
        Console.WriteLine($"С кодом 2FA: {auth.Login("admin", "12345", "9999")}");
    }

    static void RunImageProcessor() {
        var ip = new ImageProcessor();
        ip.ResizeImage(800, 600);
        ip.ResizeImage(1.5);
        ip.ResizeImage(1024, 768, true);
    }

    static void RunFuelCalculator() {
        var fc = new FuelCalculator();
        Console.WriteLine($"Расход топлива (л): {fc.CalculateFuelCost(500, 8.5)}");
        Console.WriteLine($"Стоимость топлива: {fc.CalculateFuelCost(500, 8.5, 230.50m):C}");
    }

    static void RunPriceCalculator() {
        var pc = new PriceCalculator();
        Console.WriteLine($"Цена со скидкой: {pc.CalculateFinalPrice(10000m, 10m)}");
        Console.WriteLine($"С налогами и скидкой: {pc.CalculateFinalPrice(10000m, 10m, 500m)}");
        Console.WriteLine($"Полная цена (с доставкой): {pc.CalculateFinalPrice(10000m, 10m, 500m, 1500m)}");
    }

    static void RunEvaluationSystem() {
        var es = new EvaluationSystem();
        Console.WriteLine($"Один экзамен: {es.EvaluateStudent(85)}");
        Console.WriteLine($"Экзамен + Курсовая: {es.EvaluateStudent(80, 90)}");
        Console.WriteLine($"Несколько экзаменов (params): {es.EvaluateStudent(70, 85, 90, 95)}");
    }

    static void RunHelperProject() {
        var helper = new Helper();
        Console.WriteLine($"Calculate(int): {helper.Calculate(10, 20)}");
        Console.WriteLine($"Format(string): {helper.Format("  привет мир  ")}");
        Console.WriteLine($"Format(DateTime): {helper.Format(DateTime.Now)}");
        helper.Display("Тест универсального помощника");
    }
}


class Car {
    public string Brand { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public void ShowInfo() => Console.WriteLine($"Марка: {Brand}");
    public void ShowInfo(int year) { Year = year; Console.WriteLine($"Марка: {Brand}, Год: {Year}"); }
    public void ShowInfo(int year, decimal price) { Year = year; Price = price; Console.WriteLine($"Марка: {Brand}, Год: {Year}, Цена: {Price:C}"); }
}

class StudentGrades {
    public double CalculateGrade(int score1) => score1;
    public double CalculateGrade(int score1, int score2) => (score1 + score2) / 2.0;
    public double CalculateGrade(int score1, int score2, int score3) => (score1 + score2 + score3) / 3.0;
}

class DiscountSystem {
    public decimal CalculateDiscount(decimal price, double percent) => price * (decimal)(percent / 100);
    public decimal CalculateDiscount(decimal price, int fixedAmount) => fixedAmount;
}

class Delivery {
    public decimal CalculateDelivery(string type) => 300m;
    public decimal CalculateDelivery(string type, bool isUrgent) => isUrgent ? 700m : 300m;
    public decimal CalculateDelivery(double weight, decimal ratePerKg) => (decimal)weight * ratePerKg;
}

class Book {
    public string Title { get; set; }
    public void DisplayBook() => Console.WriteLine($"Название: {Title}");
    public void DisplayBook(string author) => Console.WriteLine($"Название: {Title}, Автор: {author}");
    public void DisplayBook(string author, int year) => Console.WriteLine($"Название: {Title}, Автор: {author}, Год: {year}");
}

class Player {
    public int Score { get; private set; }
    public void AddScore(int points) => Score += points;
    public void AddScore(int points, int bonus) => Score += points + bonus;
    public void AddScore(int points, double multiplier) => Score += (int)(points * multiplier);
}

class FileManager {
    public void SaveFile(string path, string text) => File.WriteAllText(path, text);
    public void SaveFile(string path, string[] lines) => File.WriteAllLines(path, lines);
    public void SaveFile(string path, string text, Encoding encoding) => File.WriteAllText(path, text, encoding);
}

class Geometry {
    public double CalculateVolume(double a) => Math.Pow(a, 3);
    public double CalculateVolume(double a, double b, double c) => a * b * c;
    public double CalculateVolume(double r, double h, bool isCylinder) => Math.PI * Math.Pow(r, 2) * h;
}

class TaxiService {
    public decimal CalculateFare(double km) => (decimal)(km * 50);
    public decimal CalculateFare(double km, int waitMinutes) => (decimal)(km * 50 + waitMinutes * 5);
    public decimal CalculateFare(double km, string carClass) {
        decimal rate = carClass.ToLower() == "vip" ? 120m : 50m;
        return (decimal)km * rate;
    }
}

class LibraryCatalog {
    public void SearchBook(string title) => Console.WriteLine($"Поиск по названию: {title}");
    public void SearchBook(string title, bool isAuthor) => Console.WriteLine($"Поиск по автору: {title}");
    public void SearchBook(string title, string author) => Console.WriteLine($"Поиск: {title} - {author}");
}

class ArraySorter {
    public void Sort(int[] array) => Array.Sort(array);
    public void Sort(double[] array) => Array.Sort(array);
    public void Sort(string[] array) => Array.Sort(array);
}

class ArrayAnalyzer {
    public void Analyze(int[] arr, out int min, out int max, out double avg) {
        min = arr.Min(); max = arr.Max(); avg = arr.Average();
    }
    public void Analyze(double[] arr, out double min, out double max, out double avg) {
        min = arr.Min(); max = arr.Max(); avg = arr.Average();
    }
}

class PasswordValidator {
    public bool ValidatePassword(string pwd) => pwd.Length >= 8;
    public bool ValidatePassword(string pwd, bool checkDigits) => pwd.Length >= 8 && pwd.Any(char.IsDigit);
    public bool ValidatePassword(string pwd, bool checkDigits, bool checkSpecial) => 
        pwd.Length >= 8 && pwd.Any(char.IsDigit) && pwd.Any(ch => !char.IsLetterOrDigit(ch));
}

class CurrencyConverter {
    public decimal ConvertCurrency(decimal amount, decimal fixedRate) => amount * fixedRate;
    public decimal ConvertCurrency(decimal amount, decimal rate, decimal commission) => (amount * rate) + commission;
}

class DateFormatter {
    public string FormatDate(DateTime dt) => dt.ToShortDateString();
    public string FormatDate(string dateStr) => DateTime.Parse(dateStr).ToShortDateString();
    public string FormatDate(DateTime dt, bool includeTime) => includeTime ? dt.ToString() : dt.ToShortDateString();
}

class Notifier {
    public void SendNotification(string message) => Console.WriteLine($"Сообщение: {message}");
    public void SendNotification(string title, string message) => Console.WriteLine($"[{title}] {message}");
    public void SendNotification(string title, string message, string recipient) => Console.WriteLine($"Кому: {recipient} | [{title}] {message}");
}

class Employee {
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public Employee(string name) { Name = name; }
    public Employee(string name, string position) { Name = name; Position = position; }
    public Employee(string name, string position, decimal salary) { Name = name; Position = position; Salary = salary; }
}

class EmployeeCreator {
    public Employee CreateEmployee(string name) => new Employee(name);
    public Employee CreateEmployee(string name, string pos) => new Employee(name, pos);
    public Employee CreateEmployee(string name, string pos, decimal sal) => new Employee(name, pos, sal);
}

class StockManager {
    public int IncreaseStock(int current, int amount) => current + amount;
    public int DecreaseStock(int current, int amount) => Math.Max(0, current - amount);
    public int SetStock(int newAmount) => newAmount;
}

class MathLibrary {
    public int Calculate(int a, int b) => a + b;
    public double Calculate(double a, double b) => a - b;
    public decimal Calculate(decimal a, decimal b, bool multiply) => a * b;
}

class AuthService {
    public bool Login(string login, string password) => true;
    public bool Login(string email, string password, bool isEmail) => true;
    public bool Login(string login, string password, string twoFactorCode) => true;
}

class ImageProcessor {
    public void ResizeImage(int width, int height) => Console.WriteLine($"Изменение размера до {width}x{height}");
    public void ResizeImage(double scale) => Console.WriteLine($"Масштабирование с коэффициентом {scale}");
    public void ResizeImage(int maxWidth, int maxHeight, bool keepAspectRatio) => Console.WriteLine($"Изменение в границах {maxWidth}x{maxHeight} (пропорции: {keepAspectRatio})");
}

class FuelCalculator {
    public double CalculateFuelCost(double distance, double consumptionPer100Km) => (distance / 100.0) * consumptionPer100Km;
    public decimal CalculateFuelCost(double distance, double consumption, decimal fuelPrice) => (decimal)((distance / 100.0) * consumption) * fuelPrice;
}

class PriceCalculator {
    public decimal CalculateFinalPrice(decimal price, decimal discountPercent) => price * (1 - discountPercent / 100);
    public decimal CalculateFinalPrice(decimal price, decimal discount, decimal tax) => (price * (1 - discount / 100)) + tax;
    public decimal CalculateFinalPrice(decimal price, decimal discount, decimal tax, decimal delivery) => (price * (1 - discount / 100)) + tax + delivery;
}

class EvaluationSystem {
    public double EvaluateStudent(int exam) => exam;
    public double EvaluateStudent(int exam, int coursework) => (exam + coursework) / 2.0;
    public double EvaluateStudent(params int[] exams) => exams.Average();
}

class Helper {
    public int Calculate(int a, int b) => a + b;
    public string Format(string text) => text.Trim().ToUpper();
    public string Format(DateTime date) => date.ToString("yyyy-MM-dd");
    public void Display(string item) => Console.WriteLine($"Объект: {item}");
}