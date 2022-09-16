namespace Prueba
{
    internal class Negocio
    {
        private static int codigo_supremo = 0;
        public int Codigo { get; set; }

        public string nombreIdea, impactoSocial;
        public  double valorInversion, ingresosProyecto;
        public List<Integrante> ListaIntegrantes { get; set; }
        public List<Departamento> ListaDepartamentos { get; set; }
        public List<string> Herramientas { get; set; }  
        public override string ToString()
        {
            return $"{nombreIdea} " ;
        }

        public Negocio(string nombreIdea, string impactoSocial, double valorInversion, double ingresosProyecto,
           List<Integrante> listaIntegrantes, List<Departamento> listaDepartamentos, List<string> herramientas)
        {
            this.NombreIdea = nombreIdea;
            this.ImpactoSocial = impactoSocial;
            this.ValorInversion = valorInversion;
            this.IngresosProyecto = ingresosProyecto;
            this.ListaIntegrantes = listaIntegrantes;
            this.ListaDepartamentos = listaDepartamentos;
            this.Herramientas = herramientas;
            this.Codigo = codigo_supremo;
            codigo_supremo++;
            Console.WriteLine($"El codigo del negocio creado es: {this.Codigo}");
        }

        public string NombreIdea { get => nombreIdea; set => nombreIdea = value; }
        public string ImpactoSocial { get => impactoSocial; set => impactoSocial = value; }
        public double ValorInversion { get => valorInversion; set => valorInversion = value; }
        public double IngresosProyecto { get => ingresosProyecto; set => ingresosProyecto = value; }
        
        
    }

    
}

