

public class Program
{
   
        static int Factorial(int n)
        {
            // Caso Base: el factorial de 0 o 1 es 1
            if (n <= 1)
                return 1;
            // Caso Recursivo: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }


        static int FactorialIterativo(int n)
        {
            int resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== FACTORIAL ===");
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial Recursivo de {0} = {1}", n, Factorial(n));
            Console.WriteLine("Factorial Iterativo de {0} = {1}", n, FactorialIterativo(n));
            // Tabla de factoriales del 1 al 10
            Console.WriteLine("\n--- Tabla de Factoriales ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
            Console.ReadLine();
        }


    
}