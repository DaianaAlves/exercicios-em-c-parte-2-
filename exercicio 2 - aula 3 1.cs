
double a, b, c, x1, x2, raiz, delta;
Console.WriteLine("Informe A :");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Informe B :");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Informe C :");
c = double.Parse(Console.ReadLine());
delta = (b * b) - (4 * a * c);
raiz = Math.Sqrt(delta);
x1 = ((-(b)) + raiz) / (2 * a));
x2 = ((-(b)) - raiz) / (2 * a));
Console.WriteLine(" O resultado de x1 é :" + x1);
Console.WriteLine("O resultado de x2 é:" + x2);
Console.ReadKey();
	}
}