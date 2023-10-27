using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperPoder
    {
        public int Id { get; set; }
        public string nombre;
        public string descripcion;
        public NivelPoder nivel;

        public SuperPoder()
        {
            Id = 1;
            nivel = NivelPoder.nivelUno;

        }
    }

    enum NivelPoder
    {
        nivelUno,
        nivelDos,
        nivelTres
    }
}
