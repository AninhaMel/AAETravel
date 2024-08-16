using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAETravel.Models;

namespace AAETravel.ViewModels;

public class HomeVM
{
    public List<Pais> Paises { get; set; }
    public List<Agencia> Agencias { get; set; }
}
