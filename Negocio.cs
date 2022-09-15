using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Negocio
    {
        public static string nombreIdea, impactoSocial, departamentoBeneficiado;
        public static double valorInversion, ingresosProyecto;
        public static int cantidadIntegrantes, cantidadDepartamentosBenef;
        //herencia  departamentos, integrantes
        //List<Departamento> listaDepartamentos = new List<Departamento>();
        //List<Integrante> listaIntegrante = new List<Integrante>();

        public Negocio(string nombreIdea, string impactoSocial, double valorInversion, double ingresosProyecto, 
            int cantidadIntegrantes, string departamentoBeneficiado, int cantidadDepartamentosBenef)
        {
            this.NombreIdea = nombreIdea;
            this.ImpactoSocial = impactoSocial;
            this.ValorInversion = valorInversion;
            this.IngresosProyecto = ingresosProyecto;
            this.CantidadIntegrantes = cantidadIntegrantes;
            this.DepartamentoBeneficiado = departamentoBeneficiado;
            this.CantidadDepartamentosBenf = cantidadDepartamentosBenef;
        }

         public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
         public string ImpactoSocial { get => impactoSocial; set => impactoSocial = value; }
         public double ValorInversion { get => valorInversion; set => valorInversion = value; }
         public double IngresosProyecto { get => ingresosProyecto; set => ingresosProyecto = value; }
         public int CantidadIntegrantes { get => cantidadIntegrantes; set => cantidadIntegrantes = value; }
         public string DepartamentoBeneficiado{ get => departamentoBeneficiado; set => departamentoBeneficiado= value; }
         public int CantidadDepartamentosBenf{ get => cantidadDepartamentosBenef; set => cantidadDepartamentosBenef= value; }


        public static void recoleccionDatos()
        {
            Console.WriteLine("Ingrese el nombre de la idea de negocio: ");
            nombreIdea = Console.ReadLine();
            Console.WriteLine("Ingrese el impacto social o economico que tiene el negocio: ");
            impactoSocial = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de integrantes del proyecto: ");
            cantidadIntegrantes = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < cantidadIntegrantes; i++)
            {
                Integrante nuevoIntegrante = new Integrante();
                nuevoIntegrante.addIntegrantes();
   
                
            }
            Console.WriteLine("Cuantos departamentos seran beneficiados con esta idea: ");
            cantidadDepartamentosBenef = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < cantidadDepartamentosBenef; i++)
            {
                Console.WriteLine("Ingrese el departamento numero" + i);

                Departamento.asignarCodeDep()
            }
            Console.WriteLine("Ingrese el valor a invertir del Proyecto: ");
            valorInversion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de ingresos del Proyecto: ");
            ingresosProyecto=Convert.ToDouble(Console.ReadLine());



                


        }
    }
}
