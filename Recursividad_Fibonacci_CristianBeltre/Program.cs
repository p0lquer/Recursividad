
public class Program
{
    static int Fibonacci(int n)
    {
        // Caso Base: el Fibonacci de 0 es 0 y el de 1 es 1
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        // Caso Recursivo: F(n) = F(n-1) + F(n-2)
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int FibonacciIterativo(int n)
    {
        if (n == 0) return 0;
        else if (n == 1) return 1;
        int a = 0, b = 1, resultado = 0;
        for (int i = 2; i <= n; i++)
        {
            resultado = a + b;
            a = b;
            b = resultado;
        }
        return resultado;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("=== FIBONACCI ===");
        Console.Write("Ingrese un número que termine la secuencia: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci de {0} = {1}", n, Fibonacci(n));
        Console.WriteLine("\n--- Tabla de Fibonacci ---");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("F({0}) = {1}", i, Fibonacci(i));
        }
        Console.ReadLine();
        //comparrar con el metodo iterativo
        Console.WriteLine("\n--- Tabla de Fibonacci Iterativo  vs Fibonacci Recursivo---");
        int primeros = 35;
        var sw = System.Diagnostics.Stopwatch.StartNew();
        int resultadoIterativo = FibonacciIterativo(primeros);
        sw.Stop();
        Console.WriteLine("Fibonacci Iterativo de {0} = {1} (Tiempo: {2} ms)", primeros, resultadoIterativo, sw.ElapsedMilliseconds);
        sw.Restart();

        int resultadoRecursivo = Fibonacci(primeros);
        sw.Stop();
        Console.WriteLine("Fibonacci Recursivo de {0} = {1} (Tiempo: {2} ms)", primeros, resultadoRecursivo, sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}