
using System.Diagnostics.Metrics;

public class Program
{
    static int contador = 0;
    static void Hanoi(int n, string origen, string destino, string auxiliar)
    {
        // Caso Base: solo 1 disco, mover directamente
        if (n == 1)
        {
            contador++;
            Console.WriteLine("Mov {0}: Disco {1} de {2} → {3}",
            contador, n, origen, destino);
            return;
        }
        // Mover n-1 discos de origen a auxiliar
        Hanoi(n - 1, origen, auxiliar, destino);
        // Mover el disco más grande al destino
        contador++;
        Console.WriteLine("Mov {0}: Disco {1} de {2} → {3}",
        contador, n, origen, destino);
        // Mover n-1 discos de auxiliar a destino
        Hanoi(n - 1, auxiliar, destino, origen);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== TORRE DE HANOI ===");
        Console.Write("Ingrese número de discos: ");
        int discos = Convert.ToInt32(Console.ReadLine());
        contador = 0;
        Console.WriteLine("\nResolviendo para {0} discos:\n", discos);
        Hanoi(discos, "A", "C", "B");
        Console.WriteLine("\nTotal de movimientos: {0}", contador);
        Console.WriteLine("Fórmula: 2^{0} - 1 = {1}", discos, (int)Math.Pow(2, discos) - 1);

        // Tabla de complejidad
        Console.WriteLine("\n--- Tabla de Movimientos ---");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} discos = {1} movimientos", i, (int)Math.Pow(2, i) - 1);
        }
        Console.ReadLine();
    }

}