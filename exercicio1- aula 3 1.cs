using System;

public class Test
{
    public static void Main()
    {
        double r, a, d, p;
        Console.WriteLine("Digite o Raio do circulo :");
        r = double.Parse(Console.ReadLine());
        a = 3.14 * r * r;
        d = 2 * r;
        p = 2 * 3.14 * r;
        Console.WriteLine("A area do circulo é :" + a);
        Console.WriteLine("O diametro do circulo é :" + d);
        Console.WriteLine("O perimetro do circulo é:" + p);
        Console.ReadKey();
    }
}