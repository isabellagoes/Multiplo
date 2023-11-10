Console.WriteLine("--- Multiplo ---\n");

Console.Write("Digite um número...........: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de...: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 % numero2 == 0)
{
    Console.Write($"{numero1} ");
            Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("é multiplo ");
            Console.ResetColor();
    Console.WriteLine($"de {numero2}");
}
else
{
    Console.Write($"{numero1} ");
            Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("não é multiplo ");
            Console.ResetColor();
    Console.WriteLine($"de {numero2}");
}