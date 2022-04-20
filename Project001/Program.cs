Console.ForegroundColor = ConsoleColor.Green;
do
{
    Console.WriteLine("\n-----------------------------");
    Console.WriteLine("Вас приветсвует кукулятор");
    Console.WriteLine("-----------------------------\n");
    Console.Write("Введите первое число: ");
    var num = Console.ReadLine();
    double Num;
    bool isNum()
    {
        bool IsNum = double.TryParse(num, out Num);
        return IsNum;
    }
    while (isNum() == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nОшибка, введите корректные данные...\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введите первое число: ");
        num = Console.ReadLine();
    }
    double x = Num;
    Console.Write("\nВведите действие: ");
    var act = Console.ReadLine();
    void Help()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Список доступных действий");
        Console.WriteLine("---------------------------");
        Console.WriteLine("+ - сложение");
        Console.WriteLine("- - вычитание");
        Console.WriteLine("* - умножение");
        Console.WriteLine("/ - деление");
        Console.WriteLine("^ - возвести число в степень");
        Console.WriteLine("% - найти остаток от деления на второе число");
        Console.WriteLine("-----------------------------------------------\n");
        Console.Write("Введите действие: ");
        act = Console.ReadLine();
    }
    bool Act()
    {
        switch (act)
        {
            case "+":
                return true;
            case "-":
                return true;
            case "*":
                return true; ;
            case "/":
                return true;
            case "^":
                return true;
            case "%":
                return true;
            default:
                return false;
        }
    }
    while (Act() == false)
    {
        if (act == "/help")
        {
            Help();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nОшибка, введите корректное действие...");
            Console.WriteLine("Чтобы получить список доступных действий введите /help\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите действие: ");
            act = Console.ReadLine();
        }
    }
    Console.Write("\nВведите второе число: ");
    num = Console.ReadLine();
    while (isNum() == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nОшибка, введите корректные данные...\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Введите второе число: ");
        num = Console.ReadLine();
    }
    double y = Num;
    var result = Convert.ToDouble(0);
    switch (act)
    {
        case "+":
            result = x + y;
            break;
        case "-":
            result = x - y;
            break;
        case "*":
            result = x * y;
            break;
        case "/":Math.Pow(x, y);
            result = x / y;
            break;
        case "^":
            result = Math.Pow(x, y);
            break;
        case "%":
            result = x % y;
            break;
        default:
            result = 0;
            break;
    }
    if (act == "/" & y == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nНа 0 делить нельзя!\n");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n---------------------------------------------");
        Console.Write("Ответ: ");
        Console.Write(x + " " + act + " " + y + " = " + result);
        Console.WriteLine("\n---------------------------------------------\n");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
    Console.WriteLine("или нажмите Esc шобы остановить это безумие...");
    Console.ForegroundColor = ConsoleColor.Green;
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);
Console.WriteLine("Пока-пока");