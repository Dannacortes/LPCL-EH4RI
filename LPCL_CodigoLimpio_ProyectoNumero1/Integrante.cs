using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCL_CodigoLimpio_ProyectoNumero1
{
    internal class Integrante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public Integrante(string nombre, string apellido, string identificacion, string rol, string email)

        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Identificacion = identificacion;
            this.Rol = rol;
            this.Email = email;
        }
    }
}
