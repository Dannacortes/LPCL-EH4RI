using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Negocios
    {
        public static string nombreIdea, departamento_beneficiado, nombre_integrante, apellidos_integrante,
        identificacion_integrante, rol_emprendimiento, email, herramientas4RI;
        public static double valor_inversion ;
        public static int cantidad_integrantes_proyecto;

        public Negocios(string nombreIdea, string departamento_beneficiado, string nombre_integrante,
        string apellidos_integrante, string identificacion_integrante, string rol_emprendimiento,
        string email, string herramientas4RI, double valor_inversion, int cantidad_integrantes_proyecto)
        {
            this.NombreIdea = nombreIdea;
            this.Departamento_beneficiado = departamento_beneficiado;
            this.Nombre_integrante = nombre_integrante;
            this.Apellidos_integrante = apellidos_integrante;
            this.Identificacion_integrante = identificacion_integrante;
            this.Rol_emprendimiento = rol_emprendimiento;
            this.Email = email;
            this.Herramientas4RI = herramientas4RI;
            this.Valor_inversion = valor_inversion;
            this.Cantidad_integrantes_proyecto = cantidad_integrantes_proyecto;
        }

        public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
        public string Departamento_beneficiado { get => departamento_beneficiado; set => departamento_beneficiado = value; }
        public string Nombre_integrante { get => nombre_integrante; set => nombre_integrante = value; }
        public string Apellidos_integrante { get => apellidos_integrante; set => apellidos_integrante = value; }
        public string Identificacion_integrante { get => identificacion_integrante; set => identificacion_integrante = value; }
        public string Rol_emprendimiento { get => rol_emprendimiento; set => rol_emprendimiento = value; }
        public string Email { get => email; set => email = value; }
        public string Herramientas4RI { get => herramientas4RI; set => herramientas4RI = value; }
        public double Valor_inversion { get => valor_inversion; set => valor_inversion = value; }
        public int Cantidad_integrantes_proyecto { get => cantidad_integrantes_proyecto; set => cantidad_integrantes_proyecto = value; }

        public static void Interfaz()
        {
            string controlador;
            controlador = "";
            while (controlador != "*" ) {

                int cantidad_herramientas4RI, CodigoProyecto;
                string impacto_social;

                CodigoProyecto = 0001;
                
                Console.WriteLine("Ingrese idea de negocio ");
                nombreIdea = Console.ReadLine();
                Console.WriteLine("Ingrese número de integrantes ");
                cantidad_integrantes_proyecto = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < cantidad_integrantes_proyecto; i++)
                {
                    Console.WriteLine("Ingrese la identificación del integrante ", i);
                    identificacion_integrante = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del integrante ", i);
                    nombre_integrante = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido del integrante ", i);
                    apellidos_integrante = Console.ReadLine();
                    Console.WriteLine("Ingrese el rol dentro de cada uno de los integrantes del emprendimiento ");
                    rol_emprendimiento = Console.ReadLine();
                    Console.WriteLine("Ingrese el email ");
                    email = Console.ReadLine();

                }
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

                Console.WriteLine("Si desea dejar de ingresar proyectos presione '*', de lo contrario marque cualquier tecla");
                controlador = Console.ReadLine();

                CodigoProyecto += 1;
            }

            
            









        }
        
    }
}