﻿using System;

namespace programa3 
{
    internal class promedio
    {
        static void Main(string[] args)
        {
            int c1, c2, c3, c4, c5, c6;
            float promedio;
            Console.WriteLine("Escribe Calificacion 1: ");
            c1 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Escribe Calificacion 2: ");
            c2 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Escribe Calificacion 3: ");
            c3 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Escribe Calificacion 4: ");
            c4 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Escribe Calificacion 5: ");
            c5 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Escribe Calificacion 6: ");
            c6 = Convert.ToInt32( Console.ReadLine() );
            //PASO- CALCULA PROMEDIO
            promedio=( c1 + c2 + c3 + c4 + c5 + c6 ) / 6;
            //PASO- IMPRIME EL RESULTADO
            Console.WriteLine("Tu promedio es: "+ promedio);
        }
    }
}