

Console.WriteLine("Robin paga o pastel pros funcionarios");
double x1, y1, x2, y2, p1, p2, d;

x1 = double.Parse(Console.ReadLine());
x2 = double.Parse(Console.ReadLine());
y1 = double.Parse(Console.ReadLine());
y2 = double.Parse(Console.ReadLine());

p1 = Math.Pow(x2 - x1, 2);
p2 = Math.Pow(y2 - y1, 2);

d = Math.Sqrt(p1 + p2);

Console.Write(d);








