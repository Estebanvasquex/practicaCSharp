namespace SuperHeroesApp.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           


            var poderVolar = new SuperPoder();

            poderVolar.Id = 1;
            poderVolar.nombre = "Volar";
            poderVolar.descripcion = "Planear en el aire";
            poderVolar.nivel = NivelPoder.nivelDos;

            var superFuerza = new SuperPoder();
            superFuerza.Id = 2;
            superFuerza.nombre = "Súper fuerza";
            superFuerza.descripcion = "Levantar hasta 80 veces su peso";
            superFuerza.nivel = NivelPoder.nivelDos;

            var superman = new SuperHeroe();

            superman.Id = 1;
            superman.nombre = "Superman";
            superman.identidadSecreta = "Clark Kent";
            superman.ciudad = "Medellin";
            superman.puedeVolar = true;
            List<SuperPoder> poderesSuperMan = new List<SuperPoder>();
            poderesSuperMan.Add(poderVolar);
            poderesSuperMan.Add(superFuerza);
            superman.superPoderes = poderesSuperMan;
            superman.puedeVolar = true;
            superman.UsarSuperPoder();
        }

   





     
    }
}