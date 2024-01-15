using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Primer lote con 10 registros de productos, cada producto tiene:
            //                - Código Articulo (3 dígitos no correlativos)
            //                - Precio
            //                - Código de Marca(1 a 10)
            //            Segundo lote con las ventas de la semana. Cada venta tiene:
            //                - Código Artículo
            //                - Cantidad
            //                - Código Cliente (1 a 100)
            //            Este lote corta con Código de Cliente cero.

            Articulo[] articulos = new Articulo[10];
            
            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de marca(1 a 10):");
                articulos[i].CodiMarca = int.Parse(Console.ReadLine());

            }

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo de cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente !=0)
            {
                Console.WriteLine("Codigo de articulo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());


                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo de cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }


        }
    }
}
