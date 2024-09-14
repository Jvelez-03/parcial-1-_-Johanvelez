internal class Program
{
    private static void Main(string[] args)
    {
        //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:
        
        // pedimos sueldo base del vendedor 
        Console.Write("Ingrese el sueldo base del vendedor: ");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        // Solicitar los montos de las ventas 1,2 y 3
        Console.Write("Ingrese el monto de la primera venta: ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la segunda venta: ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la tercera venta: ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        // generamos las operaciones para cada comision (10% de cada venta)
        double comision1 = venta1 * 0.10;
        double comision2 = venta2 * 0.10;
        double comision3 = venta3 * 0.10;

        //calculamos el total de comisiones
        double totalComisiones = comision1 + comision2 + comision3;

        // Calcular el total de ventas
        double totalVentas = venta1 + venta2 + venta3;

        // este sera el total que resivira el vendedor 
        double totalRecibido = sueldoBase + totalComisiones;

        // en este punto determinamos si el vendedor supero el objetivo de ventas propuesto y si se logro el objetivo aplicar el veneficio extra 
        double beneficioExtra = 100000;
        if (totalVentas >= 1000000)
        {
            totalRecibido += beneficioExtra;
            Console.WriteLine("¡Felicitaciones! Has superado el objetivo del mes y ganas un beneficio extra de $100,000.");
        }
        else
        {
            Console.WriteLine("No has alcanzado el objetivo del mes, por lo tanto, no recibes el beneficio extra.");
        }

        // en esta parte determinamos cuál venta generó la mayor comisión
        double mayorComision = Math.Max(comision1, Math.Max(comision2, comision3));
        string ventaMayorComision;
        if (mayorComision == comision1) ventaMayorComision = "primera";
        else if (mayorComision == comision2) ventaMayorComision = "segunda";
        else ventaMayorComision = "tercera";

        // Calculamos el promedio de las comisiones
        double promedioComisiones = totalComisiones / 3;

        // Mostrar el resultado
        Console.WriteLine("\nTotal de comisiones: $" + totalComisiones);
        Console.WriteLine("Total que recibirá el vendedor: $" + totalRecibido);
        Console.WriteLine("La venta que generó la mayor comisión fue la " + ventaMayorComision + " venta.");
        Console.WriteLine("El promedio de las comisiones recibidas es: $" + promedioComisiones);
    }
}