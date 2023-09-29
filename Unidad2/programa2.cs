using System;
namespace programa2 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Stephanie ", apellidos = "Cordero Mtz", completo;
            completo = nombre + apellidos;
            int a = 5, b = 23, suma;
            suma = a + b;
            Console.WriteLine(" * * Bienvenido * * " + completo + " * *");
            Console.Write("La operación suma de A=" + a + " B=" + b);
            Console.Write($"Tu resultado es {suma}");
            Console.WriteLine(" -- Gracias :)");
        }
    }
}