using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    
    public class Donos
    {
        public Donos()
        {
            Animais = new HashSet<Animais>();
        }
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public int Nif { get; set; }

        public ICollection<Animais> Animais { get; set; }
    }
}
