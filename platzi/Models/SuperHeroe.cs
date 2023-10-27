using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe
    {
        public int Id { get; set; }
        public string _nombre;
        public string nombre 
        { get 
            {
                return _nombre;
            } 
           set 
            {
                _nombre = value.Trim();
            }
        }
        public string identidadSecreta { get; set; }
        public string ciudad { get; set; }
        public List<SuperPoder> superPoderes;
        public bool puedeVolar;
        public string nombreIdentidadSecreta {
            get
            {
                return $"{nombre} ({identidadSecreta})";
            }
               }

        public SuperHeroe()
        {
            Id = 1;
            superPoderes = new List<SuperPoder>();
            puedeVolar = false;

        }

        public void UsarSuperPoder()
        {
            foreach (var item in superPoderes)
            {
                Console.WriteLine($"{this.nombreIdentidadSecreta} está usando el súper poder {item.nombre}!!");

            }

        }
    }
}

