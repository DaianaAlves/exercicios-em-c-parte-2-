using System;

public class Test
{
	public static void Main()
	{
		string nome, nome2, nome3, troca, completo, parte;
		
		Console.WriteLine("Digite seu primeiro nome:");
		nome = Console.ReadLine();
		Console.WriteLine("Digite seu segundo nome:");
		nome2 = .ReadLine();
		Console.WriteLine("Digite seu ultimo nome:");
		nome3 =  Console.ReadLine();
		completo=nome +" "+nome2+" "+nome3;
		Console.WriteLine("Ola!! "+completo);
		parte=completo.Substring(5,10);
		Console.WriteLine("caracteres do 5 ao 10: " + parte);
		troca=completo.ToUpper().Replace("A","O");
		Console.WriteLine("letra A pela letra O: " + troca);
		Console.ReadKey();
		
	}
}
