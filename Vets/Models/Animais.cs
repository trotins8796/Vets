using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Animais
    {
        public Animais()
        {
            ListaConsultas = new HashSet<Consultas>();
        }
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public int Peso { get; set; }

        public string Raca { get; set; }

        public string Foto { get; set; }

        [ForeignKey("Dono")]
        public int DonoFK { get; set; }
        public Donos Dono { get; set; }

        public ICollection<Consultas> ListaConsultas { get; set; }



    }
}
