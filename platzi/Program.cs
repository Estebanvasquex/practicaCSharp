namespace SuperHeroesApp
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

            superman.SuperPoderes = poderesSuperMan;

        }

        class SuperHeroe
        {
            public int Id { get; set; }
            public string nombre { get; set; }
            public string identidadSecreta { get; set; }
            public string ciudad { get; set; }
            public List<SuperPoder> SuperPoderes;

            public bool puedeVolar;
        }

        class SuperPoder
        {
            public int Id { get; set; }
            public string nombre;
            public string descripcion;
            public NivelPoder nivel;

        }

        enum NivelPoder
        {
            nivelUno,
            nivelDos,
            nivelTres
        }
    }
}