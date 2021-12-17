using System;

namespace Programacion_5
{
 class Program
  {
    static void Main(string[] args)
        {
            double resultado;
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" PROGRAMA PARA GEOMETRIA ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir") ;
                string opcion = Console.ReadLine();

                if (opcion == "s") {
                    break;
                }
                if (opcion == "c") {
                    Circulo nuev = new Circulo();
                    nuev.circulo();
                }
                else if (opcion == "r") {
                    Rectángulo rec = new Rectángulo();
                    rec.rectángulo();
                }
                else {
                    Triángulo tri = new Triángulo();
                    tri.triángulo();

                }
                Console.WriteLine("Gracias por usar el programa de cálculo geométrico");
            }
        }
        class Circulo{
            public void circulo (){
                double pi = 3.14;
                Console.WriteLine("Ingrese Radio");
                double vradio = double.Parse(Console.ReadLine());
                double resultado = pi * (vradio * vradio);
                Console.WriteLine("El resultado es : " + resultado);
            }

        }
        class  Rectángulo
        {
            public void rectángulo(){
                     Console.WriteLine("Ingrese la Base");
                    double vbase = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Altura");
                    double valtura = double.Parse(Console.ReadLine());
                    double resultado = vbase * valtura;
                    Console.WriteLine("El resultado es : " + resultado);

            }
        }
        class  Triángulo
        {
            public void  triángulo(){
                    Console.WriteLine("Ingrese la Base");
                    double vbase = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Altura");
                    double valtura = double.Parse(Console.ReadLine());
                    double resultado = (vbase * valtura) / 2;
                    Console.WriteLine("El resultado es : " + resultado);

            }
            
        }

    }
 }
