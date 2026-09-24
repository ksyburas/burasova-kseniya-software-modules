int a1 = -1;
int a2 = -2;
int a3 = -3;
int a4 = -4;
int b1 = 1;
int b2 = 2;
int b3 = 3;
int b4 = 4;

var a = (a1, a2, a3, a4);
var b = (b1, b2, b3, b4);
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

var d = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2) + Math.Pow(a4 - b4, 2));
Console.WriteLine("d = " + d);



Console.WriteLine("Входные данные: ");

var z1 = 36;
var z2 = 15;
var z3 = -67;
var T = 17;

Console.WriteLine("z1 = " + z1);
Console.WriteLine("z2 = " + z2);
Console.WriteLine("z3 = " + z3);
Console.WriteLine("T = " + T);

var q1 = z1 / T;
var q2 = z2 / T;
var q3 = z3 / T;

Console.WriteLine("Вычисления 1: ");
Console.WriteLine("q = z/T");
Console.WriteLine("q1 = " + q1);
Console.WriteLine("q2 = " + q2);
Console.WriteLine("q3 = " + q3);

var S = Math.Exp(q1) + Math.Exp(q2) + Math.Exp(q3);
Console.WriteLine("Вычисления 2: ");
Console.WriteLine("S = e^q1 + e^q2 + e^q3");
Console.WriteLine("S = " + S);

Console.WriteLine("p = e^q / S");
var p1 = Math.Exp(q1) / S;
var p2 = Math.Exp(q2) / S;
var p3 = Math.Exp(q3) / S;

Console.WriteLine("p1 = " + p1);
Console.WriteLine("p2 = " + p2);
Console.WriteLine("p3 = " + p3);



Console.WriteLine("Входные данные: ");
var N = 1000;
var M = 150;

Console.WriteLine("N = " + N);
Console.WriteLine("M = " + M);

var W = N * M;
var B = M;
var P = W + B;
Console.WriteLine("Кол-во весов W = " + W);
Console.WriteLine("Кол-во смещений B = " + B);
Console.WriteLine("Общее кол-во параметров P = " + P);

