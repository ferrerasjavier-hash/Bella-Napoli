using System;
using System.Collections.Generic;

namespace Bella_Napoli
{
    class Program
    {
        static void Main()
        {
            // Base
            List<string> ingredientesBase = new List<string> { "Tomate", "Mozzarella" };

            // Ingredientes
            List<string> ingredientesVegetarianos = new List<string> { "Pimiento", "Tofu" };
            List<string> ingredientesNoVegetarianos = new List<string> { "Pepperoni", "Jamón", "Salmón" };

            Console.Write("Introduzca el nombre del cliente: ");
            string cliente = Console.ReadLine() ?? string.Empty;

            Console.Write("¿Desea una pizza vegetariana? (sí/no): ");
            string respuesta = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            List<string> ingredientesDisponibles;
            string tipoPizza;


            if (respuesta == "sí" || respuesta == "si")
            {
                ingredientesDisponibles = ingredientesVegetarianos;
                tipoPizza = "Vegetariana";
            }
            else if (respuesta == "no")
            {
                ingredientesDisponibles = ingredientesNoVegetarianos;
                tipoPizza = "No vegetariana";
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Console.WriteLine("\nIngredientes disponibles:");
            for (int i = 0; i < ingredientesDisponibles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredientesDisponibles[i]}");
            }


            Console.Write("Seleccione un ingrediente (número): ");
            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out int opcion) ||
                opcion < 1 || opcion > ingredientesDisponibles.Count)
            {
                Console.WriteLine("Selección inválida.");
                return;
            }

            string ingredienteElegido = ingredientesDisponibles[opcion - 1];

            //Resumen del pedido
            Console.WriteLine("\n--- Resumen de tu pedido ---");
            Console.WriteLine($"Cliente: {cliente}");
            Console.WriteLine($"Tipo de pizza: {tipoPizza}");
            Console.WriteLine("Ingredientes: " +
                string.Join(", ", ingredientesBase) + ", " + ingredienteElegido);
        }
    }
}