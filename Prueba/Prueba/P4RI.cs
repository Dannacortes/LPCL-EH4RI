using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Negocios
    {
       //Lista de integrantes, que recible informacion de la clase integrantes 
       // Lista de departamentos , que trae la informacion de la clase departamento 

        // esta clase tiene el codigo, nombre del proycto, valor de inversion, valor recaudo 
        public static string nombreIdea, departamento_beneficiado, herramientas4RI;
        public static double valor_inversion ;
        public static int cantidad_integrantes_proyecto, cantidad_herramientas4RI;

        public Negocios(string nombreIdea, string departamento_beneficiado, string herramientas4RI, 
            double valor_inversion, int cantidad_integrantes_proyecto, int cantidad_herramientas4RI)
        {
            this.NombreIdea = nombreIdea;
            this.Departamento_beneficiado = departamento_beneficiado;
            this.Herramientas4RI = herramientas4RI;
            this.Valor_inversion = valor_inversion;
            this.Cantidad_integrantes_proyecto = cantidad_integrantes_proyecto;
            this.Cantidad_herramientas4RI = cantidad_herramientas4RI;
        }

        public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
        public string Departamento_beneficiado { get => departamento_beneficiado; set => departamento_beneficiado = value; }
        public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        public double Valor_inversion { get => valor_inversion; set => valor_inversion = value; }
        public int Cantidad_integrantes_proyecto { get => cantidad_integrantes_proyecto; set => cantidad_integrantes_proyecto = value; }
        public int Cantidad_herramientas4RI { get => cantidad_herramientas4RI; set => cantidad_herramientas4RI = value; }


        public static void Interfaz()
        {
            string controlador;
            controlador = "";
            while (controlador != "*" ) {

                int CodigoProyecto;
                string impacto_social;

                CodigoProyecto = 0001;
                
                Console.WriteLine("Ingrese idea de negocio ");
                nombreIdea = Console.ReadLine();
                Console.WriteLine("Cuantas herramientas de la cauarta revolucion industrial se utilizaron ");
                cantidad_herramientas4RI = Convert.ToInt32(Console.ReadLine());

                while (cantidad_herramientas4RI <= 1)
                {
                    Console.WriteLine("Cuantas herramientas de la cauarta revolucion industrial se utilizaron ");
                    cantidad_herramientas4RI = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Que impacto social o economico genera ");
                impacto_social = Console.ReadLine();

                Console.WriteLine("Ingrese el Departmento que se beneficia con el proyecto ");
                departamento_beneficiado = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de la inversion que tiene el proyecto ");
                valor_inversion = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite el que tiene el proyecto ");
                valor_inversion = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Si desea dejar de ingresar proyectos presione '*', de lo contrario marque cualquier tecla");
                controlador = Console.ReadLine();

                CodigoProyecto += 1;
            }

            
            









        }
        
    }
}