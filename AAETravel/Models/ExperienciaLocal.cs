using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AAETravel.Models;

    public class ExperienciaLocal
    {
   public int LocalId { get; set; }
        [ForeignKey("Local")]
        public Lista Local { get; set; }
    }
