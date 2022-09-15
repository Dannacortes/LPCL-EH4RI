
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
       

        public  void Menu()
        {
            int eleccionUsuario;
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Ingrese una de las siguientes opciones \n 1.Ingrese un nuevo proyecto \n" +
                "2. Agrega integrantes \n 3. Eliminar integrantes \n 4. Modificar inversión");
            eleccionUsuario = Convert.ToInt16(Console.ReadLine());
    
            if (eleccionUsuario == 1)
            {
                string controlador = "*";
                int codigo = 0001;
                while(controlador == "*")
                {
                    
                    Console.WriteLine("El codigo de su Negocio es " + codigo);

                    Console.WriteLine("Desea agregar mas proyectos presione cualquier tecla" +
                        ", para detenerse presione * ");
                    controlador = Console.ReadLine;

                    codigo += 1;

                }
            }



        }

    }

}
}