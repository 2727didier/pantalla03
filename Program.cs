﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pantalla03
{
    internal class Program
    {
            static List<Producto> inventario = new List<Producto>();

            static void Main()
            {
                int opcion;

                do
                {
                    MostrarMenuGestionProductos();
                    opcion = ObtenerOpcion();

                    switch (opcion)
                    {
                        case 1:
                            AgregarProducto();
                            break;
                        case 2:
                            EliminarProducto();
                            break;
                        case 3:
                            ModificarProducto();
                            break;
                        case 4:
                            MostrarInventario();
                            break;
                        case 5:
                            Console.WriteLine("Volviendo al Menú Principal");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                            break;
                    }
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();

                } while (opcion != 5);
            }

        private static void MostrarInventario()
        {
            throw new NotImplementedException();
        }

        private static void ModificarProducto()
        {
            throw new NotImplementedException();
        }

        private static void EliminarProducto()
        {
            throw new NotImplementedException();
        }

        static void MostrarMenuGestionProductos()
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("||       Gestionar Productos - Mi Tiendita      ||");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|| 1. Agregar Producto                          ||");
                Console.WriteLine("|| 2. Eliminar Producto                         ||");
                Console.WriteLine("|| 3. Modificar Producto                        ||");
                Console.WriteLine("|| 4. Mostrar Inventario                        ||");
                Console.WriteLine("|| 5. Volver al Menú Principal                  ||");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Seleccione una opción:");
            }

            static int ObtenerOpcion()
            {
                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
                return opcion;
            }

            static void AgregarProducto()
            {
                Console.Clear();
                Console.WriteLine("===== Pantalla para Agregar Producto =====");
                Console.WriteLine("--------------------------------------------------");

                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del producto: ");
                double precio;
                while (!double.TryParse(Console.ReadLine(), out precio))
                {
                    Console.WriteLine("Por favor, ingresa un precio válido.");
                }
                Console.Write("Ingrese la cantidad del producto: ");
                int cantidad;
                while (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("Por favor, ingresa una cantidad válida.");
                }
                inventario.Add(new Producto(nombre, precio, cantidad));
                Console.WriteLine("\nConfirmación: Producto agregado exitosamente.");
            }
    class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public Producto(string nombre, double precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
        }
    }

}
    

