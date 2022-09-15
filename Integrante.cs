using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Integrante
    {
         public static string nombre, apellido, identificacion, rol, email;

        public Integrante(string nombre, string apellido, string identificacion, string rol, string email)

        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Identificacion = identificacion;
            this.Rol = rol;
            this.Email = email;
        }

         public string Nombre { get => nombre; set => nombre = value; }
         public string Apellido { get => apellido; set => apellido = value; }
         public string Identificacion { get => identificacion; set => identificacion = value; }
         public string Rol { get => rol; set => rol = value; }
         public string Email { get => email; set => email = value; }

        public static void addIntegrantes()
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


        }
        


    }
}
