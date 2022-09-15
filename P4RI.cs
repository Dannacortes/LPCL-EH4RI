
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // PRINCIPAL 
    internal class P4RI
    {
       

        public static void Menu()
        {
            int eleccionUsuario;
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Ingrese una de las siguientes opciones \n 1.Ingrese un nuevo proyecto \n" +
                "2. Agrega integrantes \n 3. Eliminar integrantes \n 4. Modificar inversión");
            eleccionUsuario = Convert.ToInt16(Console.ReadLine());
    
            if (eleccionUsuario == 1)
            {
                string controlador = "*";
                int codigo = 0001
                while(controlador == "*")
                {
                    Prueba.Negocio newProyect = new Prueba.Negocio;
                    newProyect.recoleccionDatos();
                    Console.WriteLine("El codigo de su Negocio es " + codigo)

                    Console.WriteLine("Desea agregar mas proyectos presione cualquier tecla" +
                        ", para detenerse presione * ");
                    controlador = Console.ReadLine;

                    codigo += 1

                }
            }



        }
        //Lista de integrantes, que recible informacion de la clase integrantes 
        // Lista de departamentos , que trae la informacion de la clase departamento 

        // esta clase tiene el codigo, nombre del proycto, valor de inversion, valor recaudo 
        //public static string nombreIdea, herramientas4RI;
        //public static double valor_inversion ;
        //public static int cantidad_integrantes_proyecto, cantidad_herramientas4RI;

        //public P4RI(string nombreIdea, string herramientas4RI, 
        //    double valor_inversion, int cantidad_integrantes_proyecto, int cantidad_herramientas4RI)
        //{
        //    this.NombreIdea = nombreIdea;
        //    this.Herramientas4RI = herramientas4RI;
        //    this.Valor_inversion = valor_inversion;
        //    this.Cantidad_integrantes_proyecto = cantidad_integrantes_proyecto;
        //    this.Cantidad_herramientas4RI = cantidad_herramientas4RI;
        //}

        //public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
        //public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        //public double Valor_inversion { get => valor_inversion; set => valor_inversion = value; }
        //public int Cantidad_integrantes_proyecto { get => cantidad_integrantes_proyecto; set => cantidad_integrantes_proyecto = value; }
        //public int Cantidad_herramientas4RI { get => cantidad_herramientas4RI; set => cantidad_herramientas4RI = value; }
        //public static void Interfaz()
        //{
        //    string controlador;
        //    controlador = "";
        //    while (controlador != "*" ) {

        //        int CodigoProyecto;
        //        string impacto_social;

        //        CodigoProyecto = 0001;

        //        Console.WriteLine("Ingrese idea de negocio ");
        //        nombreIdea = Console.ReadLine();
        //        Console.WriteLine("Cuantas herramientas de la cauarta revolucion industrial se utilizaron ");
        //        cantidad_herramientas4RI = Convert.ToInt32(Console.ReadLine());

        //        while (cantidad_herramientas4RI <= 1)
        //        {
        //            Console.WriteLine("Cuantas herramientas de la cauarta revolucion industrial se utilizaron ");
        //            cantidad_herramientas4RI = Convert.ToInt32(Console.ReadLine());
        //        }

        //        Console.WriteLine("Que impacto social o economico genera ");
        //        impacto_social = Console.ReadLine();

        //        Console.WriteLine("Ingrese el valor de la inversion que tiene el proyecto ");
        //        valor_inversion = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Digite el que tiene el proyecto ");
        //        valor_inversion = Convert.ToDouble(Console.ReadLine());

        //        Console.WriteLine("Si desea dejar de ingresar proyectos presione '*', de lo contrario marque cualquier tecla");
        //        controlador = Console.ReadLine();

        //        CodigoProyecto += 1;
        //    }












    }

}
}