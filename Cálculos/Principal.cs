using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculos
{
    public class Principal
    {
        Figura f = new Figura();
        Operación op = new Operación();
        public void Welcome()
        {
            Console.WriteLine("Bienvenido al programa, presione cualquier tecla para proceder la captura de la figura");
            Console.ReadKey();
            GetFig();
        }
        public void Menu()
        {
            int opc = 0;double result = 0;
            Console.WriteLine("Figura: {0}\tLado A: {1}\tLadoB: {2}\n\n",f.Nombre,f.LadoA,f.LadoB);
            Console.WriteLine("Seleccione con un número el Área a calcular con base en los datos que ingresaste:\n\n1.-Capturar nueva figura \n2.-Cuadrado\n3.-Rectángulo\n4.-Triángulo\n");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    GetFig();
                    break;
                case 2:
                    result=op.Area(f.LadoA);
                    Console.WriteLine("El área de la figura {0} es: {1} unidades cuadradas",f.Nombre,result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    result = op.Area(f.LadoA, f.LadoB);
                    Console.WriteLine("El área de la figura {0} es: {1} unidades cuadradas", f.Nombre, result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 4:
                    op.Area( 2, f.LadoA, f.LadoB);
                    Console.WriteLine("El área de la figura {0} es: {1} unidades cuadradas", f.Nombre, result);
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5:
                    System.Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Seleccione una opción válida, por favor");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        public void GetFig()
        {
            Console.WriteLine("Ingrese el nombre de la figura: ");
            f.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el lado A de la figura: ");
            f.LadoA = double.Parse(Console.ReadLine());
            Console.WriteLine("INgrese el lado B de la figura: ");
            f.LadoB = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("La figura {0} ha sido capturada, su lado A es: {1} y su lado B es {2}",f.Nombre,f.LadoA,f.LadoB);
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
    }
}
