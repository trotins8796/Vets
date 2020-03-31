using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            Consultas = new HashSet<Consultas>();
        }
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public int numCedulaProf { get; set; }

        public string Fotografia { get; set; }

        public ICollection<Consultas> Consultas { get; set; }


    }
}
