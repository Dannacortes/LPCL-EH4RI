using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCL_CodigoLimpio_ProyectoNumero1
{
    internal class P4RI
    {
        public List<Negocio> negocios = new List<Negocio>();

        public P4RI()
        {

            int eleccionUsuario;
            Console.WriteLine("BIENVENIDO");
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese una de las siguientes opciones\n" +
                    "0. para cerrar la aplicacion \n" +
                    "1. Ingrese un nuevo proyecto\n" + 
                    "2. Acceder a  un negocio existente \n" +
                    "3. Mostrar Estadisticas");
                eleccionUsuario = Convert.ToInt16(Console.ReadLine());

                if (eleccionUsuario == 1)
                {
                    IngresarProyecto();
                }
                else if (eleccionUsuario == 2)
                {

                    //IngresarIntegrantes(cantidadIntegrantes);
                    int codigoIngresado;
                    Console.WriteLine("Ingrese el codigo del proyecto: ");
                    codigoIngresado = int.Parse(Console.ReadLine());
                    var negocioElegido = (from negocio in negocios where negocio.Codigo == codigoIngresado select negocio).FirstOrDefault();
                    if (negocioElegido != default)
                    {
                        menuNegocio((Negocio) negocioElegido);
                    }
                }
                else if (eleccionUsuario == 3)
                {

                    estadisticas();


                }
                else if (eleccionUsuario == 0)
                {
                    continuar = false;
                }
            }



        }
        public List<string> IngresarHerramientas4RI(int cantidadHerramientas)
        {
            List<string> ListaHerramientas = new();
            string herramienta4RI;

            for (int i = 0; i < cantidadHerramientas; i++)
            {
                Console.WriteLine("Ingrese la Herramienta utilizada en su emprendimiento: ");
                herramienta4RI = Console.ReadLine();
                ListaHerramientas.Add(herramienta4RI);

            }
            return ListaHerramientas;

        }
        public List<Departamento> IngresarDepartamentos(int cantidadDepartamentos)
        {
            List<Departamento> ListaDepartamentos = new();
            string departamentoBeneficiado;
            string nombreDep, codigoDep;

            for (int i = 0; i < cantidadDepartamentos; i++)
            {
                Console.WriteLine("Ingrese el nombre del departamento: ");
                nombreDep = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo del departamento: ");
                codigoDep = Console.ReadLine();

                var nuevoDep = new Departamento(nombreDep, codigoDep);
                ListaDepartamentos.Add(nuevoDep);
            }
            return ListaDepartamentos;

        }
        public void menuNegocio(Negocio negocioActual)
        {
            bool menu = true;
            while (menu)
            {
                // Va a ir el menu donde tiene todo lo de negocio, agregar integrantes, modificar, etc 

                int seleccionMenu;
                Console.WriteLine("Ingrese: \n 0. Volver al menu anterior \n 1. Agregar un nuevo integrante  \n 2. Eliminar un integrante existente \n 3. Modificar valor de inversión y total de ingresos");
                seleccionMenu = Convert.ToInt16(Console.ReadLine());
                if (seleccionMenu == 0)
                {
                    return;
                }
                if (seleccionMenu == 1)
                {
                    int cantidad;
                    Console.WriteLine("Ingrese cuantos Integrantes va a agregar");
                    cantidad = int.Parse(Console.ReadLine());
                    IngresarIntegrantes(cantidad);
                }
                else if (seleccionMenu == 2)
                {
                    

                    string IdIntegrante;
                   
                  // aqui borrar
                    Console.WriteLine("Ingrese la identificacion de el integrante que desea eliminar");
                    IdIntegrante = Console.ReadLine();
                    var IdIntegranteDelete = (from integrante in negocioActual.ListaIntegrantes where integrante.Identificacion == IdIntegrante select integrante).FirstOrDefault();
                    if (IdIntegranteDelete != default)
                    {
                        negocioActual.ListaIntegrantes.Remove((Integrante) IdIntegranteDelete);
                    }
                

                }
                else if (seleccionMenu == 3)
                {
                    int eleccion;
                    double valorCambiar;
                    Console.WriteLine("Que valor desea modificar 1. Inversion \n 2. Total de Ingresos ");
                    eleccion = int.Parse(Console.ReadLine());
                    // Desde aca no sabemos como hacer lo de mofificar 
                    if (eleccion == 1)
                    {

                        Console.WriteLine("Ingrese el valor a modificar");
                        valorCambiar = Convert.ToDouble(Console.ReadLine());

                        negocioActual.valorInversion = valorCambiar;
                    }

                    else if (eleccion == 2)
                    {
                        Console.WriteLine("Ingrese el valor a modificar");
                        valorCambiar = Convert.ToDouble(Console.ReadLine());

                        negocioActual.IngresosProyecto = valorCambiar;
                    }
                    
                }


            }
        }
        public List<Integrante> IngresarIntegrantes(int cantidad)
        {
            List<Integrante> listaIntegrantes = new();
            string nombre, identificacion, apellido, rol, email;
            for (int i = 0; i < cantidad; i++)
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
                listaIntegrantes.Add(nuevoIntegrante);

            }
            return listaIntegrantes;
        }



        public void IngresarProyecto()
        {
            string nombreIdea, impactoSocial;
            double valorInversion, ingresosProyecto;
            int cantidadIntegrantes, cantidadDepartamentosBenef, cantidadDepartamentos, cantidadHerramientas;
            Console.WriteLine("Ingrese el nombre de la idea de negocio: ");
            nombreIdea = Console.ReadLine();
            Console.WriteLine("Ingrese el impacto social o economico que tiene el negocio: ");
            impactoSocial = Console.ReadLine();
            Console.WriteLine("Ingrese el valor a invertir del Proyecto: ");
            valorInversion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de ingresos del Proyecto: ");
            ingresosProyecto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de integrantes: ");
            cantidadIntegrantes = int.Parse(Console.ReadLine());
            List<Integrante> integrantes = IngresarIntegrantes(cantidadIntegrantes);
            Console.WriteLine("Ingrese la cantidad de departamentos beneficiados: ");
            cantidadDepartamentos = int.Parse(Console.ReadLine());
            List<Departamento> departamentos = IngresarDepartamentos(cantidadDepartamentos);
            Console.WriteLine("Ingrese la cantidad de herramientas utilizadas en el proyecto: ");
            cantidadHerramientas = int.Parse(Console.ReadLine());
            List<string> herramientas = IngresarHerramientas4RI(cantidadHerramientas);
            Negocio nuevoNegocio = new Negocio(nombreIdea, impactoSocial, valorInversion, ingresosProyecto, integrantes, departamentos, herramientas);
            negocios.Add(nuevoNegocio);

        }


        public void estadisticas()

        {
            //SI
            var NegocioMasDepaMasingre = (from negocio in negocios orderby negocio.IngresosProyecto orderby negocio.ListaDepartamentos.Count descending select negocio).FirstOrDefault();
            Console.WriteLine($"El negocio que más departamentos ingiere {NegocioMasDepaMasingre}");
            //sumainversion
            double totalIngreso = negocios.Sum(negocio => negocio.IngresosProyecto);
            Console.WriteLine($"La suma total de ingresos es de {totalIngreso}");
            //suma 
            double totalInversion = negocios.Sum(negocio => negocio.ValorInversion);
            Console.WriteLine($"La suma total de inversion de los proyectos es de {totalInversion}");
            //3depa
            var negociosMas3Depa = (from negocio in negocios where negocio.ListaDepartamentos.Count > 3 select negocio);
            Console.WriteLine($"Los negocios que ingieren en más de 3 dpartamentos son: {negociosMas3Depa}");
            foreach (Negocio nego in negociosMas3Depa)
            {
                Console.WriteLine(nego);
            }
            int negocioInteliArti = (from negocio in negocios where negocio.Herramientas.Contains("Inteligencia artificial") select negocio).Count();
            Console.WriteLine($"Hay {negocioInteliArti} que usan inteligencia artificial");

            var negocioMas4RI = (from negocio in negocios orderby negocio.Herramientas.Count descending select negocio).FirstOrDefault();
            Console.WriteLine($"El negocio que mas Herramientas de la 4RI tiene es {negocioMas4RI}");
            //Maso
            var negociosRentabilidad = (from negocio in negocios orderby negocio.IngresosProyecto - negocio.ValorInversion descending select negocio);
            if (negociosRentabilidad.Count() <= 3) {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(negociosRentabilidad.ElementAt(i));
                } 
            }

            Console.ReadLine();
        }

    }

}

