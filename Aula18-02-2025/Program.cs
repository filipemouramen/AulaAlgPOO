Console.WriteLine("Exercício 02");

int A, B, C; 
double R, S, O;

Console.WriteLine("Escreva o valor de A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o valor de B:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o valor de C:");
int c = int.Parse(Console.ReadLine());

R = Math.Pow(a + b, 2);

S = Math.Pow(b + c, 2);

O = (R + S) / 2;

Console.WriteLine(O);


