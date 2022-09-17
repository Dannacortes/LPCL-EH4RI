using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCL_CodigoLimpio_ProyectoNumero1
{
    internal class Departamento
    {
        string departamento { get; set; }
        string codigo { get; set; }
        public Departamento(string departamento, string codigo)
        {
            this.departamento = departamento;
            this.codigo = codigo;
        }
    }
}
