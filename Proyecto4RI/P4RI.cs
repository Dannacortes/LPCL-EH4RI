
using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // PRINCIPAL 
    internal class P4RI
    {
        public List<Negocio> negocios = new List<Negocio>();

        public  P4RI()
        {
            int eleccionUsuario;
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Ingrese una de las siguientes opciones \n 1.Ingrese un nuevo proyecto \n" +
                "2. Agrega integrantes \n 3. Eliminar integrantes \n 4. Modificar inversión \n 5. Mostrar Estadisticas ");
            eleccionUsuario = Convert.ToInt16(Console.ReadLine());

            if (eleccionUsuario == 1)
            {
                string controlador = "*";

                while (controlador == "*")
                {
                    string nombreIdea, impactoSocial, departamentoBeneficiado;
                    double valorInversion, ingresosProyecto;
                    int cantidadIntegrantes, cantidadDepartamentosBenef;
                    Console.WriteLine("Ingrese el nombre de la idea de negocio: ");
                    nombreIdea = Console.ReadLine();
                    Console.WriteLine("Ingrese el impacto social o economico que tiene el negocio: ");
                    impactoSocial = Console.ReadLine();
                    Console.WriteLine("Ingrese el valor a invertir del Proyecto: ");
                    valorInversion = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de ingresos del Proyecto: ");
                    ingresosProyecto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de integrantes del proyecto: ");
                    cantidadIntegrantes = Convert.ToInt16(Console.ReadLine());

                    string nombre, apellido, identificacion, rol, email;
                    List<Integrante> integrantes = new List<Integrante>();
                    for (int i = 0; i < cantidadIntegrantes; i++)
                    {
                        Console.WriteLine("Ingrese el nombre del Integrante: ");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del Integrante: ");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese la identificación del Integrante: ");
                        identificacion = Console.ReadLine();
                        Console.WriteLine("Ingrese el rol en el emprendimiento: ");
                        rol = Console.ReadLine();
                        Console.WriteLine("Ingrese el email del integrante: ");
                        email = Console.ReadLine();
                        var nuevoIntegrante = new Integrante(nombre, apellido, identificacion, rol, email);
                        integrantes.Add(nuevoIntegrante);

                    }
                    List<Departamento> departamentos = new List<Departamento>();
                    string nombreDep, codigoDep;
                    Console.WriteLine("Cuantos departamentos seran beneficiados con esta idea: ");
                    cantidadDepartamentosBenef = Convert.ToInt16(Console.ReadLine());
                    for (int i = 0; i < cantidadDepartamentosBenef; i++)
                    {
                        Console.WriteLine("Ingrese el nombre del departamento: ");
                        nombreDep = Console.ReadLine();
                        Console.WriteLine("Ingrese el codigo del departamento: ");
                        codigoDep = Console.ReadLine();
                        departamentoBeneficiado = Console.ReadLine();
                        var nuevoDep = new Departamento(nombreDep, codigoDep);
                        departamentos.Add(nuevoDep);

                    }
                    List<string> herramientas = new List<string>();
                    int cantidadHerramientas;
                    string herramienta4RI;
                    Console.WriteLine("Ingrese la cantidad de Herramientas de la 4RI: ");
                    cantidadHerramientas = Convert.ToInt16(Console.ReadLine());
                    for (int i = 0; i < cantidadHerramientas; i++)
                    {
                        Console.WriteLine("Ingrese la Herramienta utilizada en su emprendimiento: ");
                        herramienta4RI = Console.ReadLine();

                        herramientas.Add(herramienta4RI);

                    }

                    var nuevoNegocio = new Negocio(nombreIdea, impactoSocial, valorInversion, ingresosProyecto, integrantes, departamentos, herramientas);
                    negocios.Add(nuevoNegocio);



                    Console.WriteLine("Desea agregar mas proyectos presione cualquier tecla" +
                        ", para detenerse presione * ");
                    controlador = Console.ReadLine();

                }

            }
            else if (eleccionUsuario == 2)
            {
                string codigoIngresado;
                Console.WriteLine("Ingrese el codigo del proyecto: ");
                codigoIngresado = Convert.ToInt64(Console.ReadLine());
                var codigoIgual = (from negocio in negocios where negocio.Codigo = codigoIngresado select negocio);

            }
            else if (eleccionUsuario == 5) {

                estadisticas();
            
            
            }
            


    }
      
        
        public void estadisticas()

        {

            var NegocioMasDepaMasingre = (from negocio in negocios orderby negocio.IngresosProyecto orderby negocio.ListaDepartamentos.Count descending  select negocio).FirstOrDefault();
            Console.WriteLine(NegocioMasDepaMasingre);
            double totalIngreso = negocios.Sum(negocio =>  negocio.ValorInversion);
            var negociosMas3Depa = from negocio in negocios where negocio.ListaDepartamentos.Count > 3 select negocio;
            
            foreach(Negocio nego in negociosMas3Depa)
            {
                Console.WriteLine(nego);
            }
            int negocioInteliArti = (from negocio in negocios where negocio.Herramientas.Contains("Inteligencia artificial") select negocio).Count();
            Console.WriteLine($"Hay {negocioInteliArti} que usan inteligencia artificial");

            var negociosRentabilidad = from negocio in negocios orderby negocio.IngresosProyecto - negocio.ValorInversion descending select negocio;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(negociosRentabilidad.ElementAt(i));
            }
            Console.ReadLine();
        }
        
    }

}
