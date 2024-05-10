using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AAETravel.Models;

    public class ExperienciaLocal
    {
   public int LocalId { get; set; }
        [ForeignKey("Local")]
        public Lista Local { get; set; }

           public int ExperienciaId { get; set; }
        [ForeignKey("Experiencia")]
        public Lista Experiencia { get; set; }
    }
