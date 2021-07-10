using System;

public class Test
{
    public static void Main()
    {
        string nome, nome2, nome3;
        Console.WriteLine("Digite seu primeiro nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu segundo nome:");
        nome2 = .ReadLine();
        Console.WriteLine("Digite seu ultimo nome:");
        nome3 = Console.ReadLine();
        Console.WriteLine("Seja Bem vinda(o) " + nome + " " + nome2 + " " + nome3);
        Console.WriteLine("Seu email institucional é:" + nome + "@fatec.sp.gov.br");
        Console.ReadKey();
    }
}
