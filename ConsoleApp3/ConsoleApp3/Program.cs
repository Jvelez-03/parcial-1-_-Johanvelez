internal class Program
{
    private static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese los coeficientes
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Verificar las condiciones para determinar el tipo de solución
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("La ecuación tiene infinitas soluciones.");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución.");
            }
        }
        else
        {
            // Calcular la solución de la ecuación
            double x = -b / a;
            Console.WriteLine("La solución de la ecuación es: x = " + x);
        }
    }
}