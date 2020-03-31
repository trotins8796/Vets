using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Consultas
    {
        [Key]
        public int ID { get; set; }

        public DateTime Data { get; set;}

        public string Obsercacoes { get; set; }

        [ForeignKey(nameof(Animal))]
        public int AnimaisFK { get; set; }
        public Animais Animal { get; set; }

        [ForeignKey(nameof(Veterinario))]
        public int VeterinarioFK { get; set; }
        public Veterinarios Veterinario { get; set; }
    }
}
