double nota1, nota2, nota3, media;

Console.WriteLine("Digite a nota 1:");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 2:");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota 3:");
nota3 = double.Parse(Console.ReadLine());

media = (((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 3) ;
Console.WriteLine("O valor da média é: " + media);
