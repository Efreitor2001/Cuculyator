Console.ForegroundColor = ConsoleColor.Green;
while(true)
{
    Console.WriteLine("Введите первое число:");
    var num1 = Console.ReadLine();
    double Num1;
    double Num2;
    bool isNum1 = double.TryParse(num1, out Num1);
    while(isNum1 == false)
    if (isNum1 == false)
    {
        Console.WriteLine("Ошибка, введите корректные данные...");
        num1 = Console.ReadLine();
        isNum1 = double.TryParse(num1, out Num1);
    }
    Console.WriteLine("Введите действие:");
    var act = Console.ReadLine();
    if(act == null) act = "a";
    string a1 = "+";
    string a2 = "-";
    string a3 = "*";
    string a4 = "/";
    bool IsAct = act.Contains(a1) | act.Contains(a2) | act.Contains(a3) | act.Contains(a4);
    while(IsAct == false)
    {
        if(IsAct == false)
        {
            Console.WriteLine("Ошибка, введите корректное действие...");
            act = Console.ReadLine();
            if(act == null) act = "a";
            IsAct = act.Contains(a1) | act.Contains(a2) | act.Contains(a3) | act.Contains(a4);
        }
    }
    Console.WriteLine("Введите второе число:");
    var num2 = Console.ReadLine();
    bool isNum2 = double.TryParse(num2, out Num2);
    while(isNum2 == false)
    if (isNum2 == false)
    {
        Console.WriteLine("Ошибка, введите корректные данные...");
        num2 = Console.ReadLine();
        isNum2 = double.TryParse(num2, out Num2);
    }
    double x = Num1;
    double y = Num2;
    double a = 0;
    if (act == "+") a = (x + y);
    if (act == "-") a = (x - y);
    if (act == "*") a = (x * y);
    if (act == "/") a = (x / y);
    double result = a;
    Console.WriteLine("Ответ:");
    Console.WriteLine(num1 + " " + act + " " + num2 + " = " + result);
}