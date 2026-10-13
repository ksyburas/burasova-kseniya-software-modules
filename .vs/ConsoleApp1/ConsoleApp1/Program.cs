//Console.Write("Ведите число: ");
//var x = Convert.ToInt32(Console.ReadLine());
//int num = x < 0 ? -x : x;
//Console.Write("Число: " + num);
//Console.WriteLine("Введите стороны треугольника: ");
//var a = Convert.ToInt32(Console.ReadLine());
//var b = Convert.ToInt32(Console.ReadLine());
//var c = Convert.ToInt32(Console.ReadLine());
//if (a > 0
//    && b > 0
//    && c > 0
//    && a + b > c
//    && a + c > b
//    && b + c > a)
//{
//    Console.WriteLine("Треугольник существует");
//}
//else
//{
//    Console.WriteLine("Треугольника не существует");
//}

//Console.Write("Введите номер месяца: ");
//var month = Convert.ToInt32(Console.ReadLine());
//switch(month)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("Зима");
//        break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Весна");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Лето");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Осень");
//        break;
//}
//сильный мороз(ниже −20), мороз(−20...−1), прохладно(0...15), тепло(16...25), жарко(выше 25).

//Console.Write("Введите температуру: ");
//var temp = Convert.ToInt32(Console.ReadLine());
//string result = temp switch
//{
//    <= -20 => "Сильный мороз",
//    <= -1 => "Мороз",
//    <= 15 => "Прохладно",
//    <= 25 => "Тепло",
//    >= 25 => "Жарко",
//};
//Console.WriteLine(result);