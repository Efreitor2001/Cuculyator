Console.ForegroundColor = ConsoleColor.Green;
do
{
    Console.WriteLine("Вас приветсвует кукулятор...");
    Console.WriteLine("Введите первое число:");
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
        Console.WriteLine("Ошибка, введите корректные данные...");
        Console.ForegroundColor = ConsoleColor.Green;
        num = Console.ReadLine();
    }
    double x = Num;
    Console.WriteLine("Введите действие (+, -, *, / или ^): ");
    var act = Console.ReadLine();
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
            default:
                return false;
        }
    }
    while (Act() == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка, введите корректное действие...");
        Console.ForegroundColor = ConsoleColor.Green;
        act = Console.ReadLine();
    }
    Console.WriteLine("Введите второе число:");
    num = Console.ReadLine();
    while (isNum() == false)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка, введите корректные данные...");
        Console.ForegroundColor = ConsoleColor.Green;
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
        case "/":
            result = x / y;
            break;
        case "^":
            result = Math.Pow(x, y);
            break;
        default:
            result = 0;
            break;
    }
    if (act == "/" & y == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("На 0 делить нельзя!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ответ:");
        Console.WriteLine(x + " " + act + " " + y + " = " + result);
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
    Console.WriteLine("или нажмите Esc шобы остановить это безумие...");
    Console.ForegroundColor = ConsoleColor.Green;
}
while (Console.ReadKey(true).Key != ConsoleKey.Escape);
Console.WriteLine("Пока-пока");