//long sum = 0;
//int count = 0;
//Console.WriteLine("Вводите целые от -1000 до 1000; 0 завершает.");
//string line = Console.ReadLine();
//if (line == null) return;
//int value = int.Parse(line);
//while (value != 0)
//{
//    sum += value;
//    count++;
//    line = Console.ReadLine();
//    if (line == null)
//    {
//        Console.WriteLine("Ввод завершён");
//        return;
//    }
//    value = int.Parse(line);
//}
//Console.WriteLine($"Количество: {count}; сумма: {sum}");

//int N = Convert.ToInt32(Console.ReadLine());
//long capacity = 1;
//int steps = 0;
//while (capacity < N)
//{
//    capacity *= 2;
//    steps++;
//}
//Console.WriteLine($"{capacity}; {steps}");

//int[] values = {};
//int index = 0;
//while (index < values.Length && values[index] >= 0)
//{
//    index++;
//}
//if (index < values.Length)
//    Console.WriteLine($"Первое отрицательное: индекс {index}");
//else
//    Console.WriteLine("Не найдено");

//Console.Write("Введите строку: ");
//string text = Console.ReadLine() ?? "";

//int index = text.Length - 1;
//int spaces = 0;

//while (index >= 0 && text[index] == ' ')
//{
//    spaces++;
//    index--;
//}

//Console.WriteLine($"Число завершающих пробелов: {spaces}");

//Console.Write("Введите строку: ");
//string text = Console.ReadLine() ?? "";

//int index = text.Length - 1;
//int count = 0;

//while (index >= 0 && text[index] == '!')
//{
//    count++;
//    index--;
//}

//Console.WriteLine($"Длина завершающей последовательности '!': {count}");

//Console.WriteLine("Введите число: ");
//bool n = int.TryParse(Console.ReadLine(), out int N);
//long p = 1;
//int rep = 0;
//if (N >= 1 && N <= 1000000000)
//{
//    while (p < N)
//    {
//        p =p * 2;
//        rep++;
//    }
//}
//else
//{
//    Console.WriteLine("Ошибка! Введи число от 0 до 1000000000");
//}
//Console.WriteLine($"{p}; {rep}");

//Console.WriteLine("Введите число обьектов N: ");
//bool n = int.TryParse(Console.ReadLine(), out int N);
//long size = 1;
//int k = 0;
//if (N >= 1 && N <= 1000000000)
//{
//    while (size < N)
//    {
//        size *= 2;
//        k++;
//    }
//}
//else
//{
//    Console.WriteLine("Ошибка! Введи число от 0 до 1000000000");
//}
//Console.WriteLine($"Размер буфера: {size}");
//Console.WriteLine($"k = {k}");