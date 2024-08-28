using AAETravel.Models;

namespace AAETravel.ViewModels;

public class ExperienciaVM
{
    public int PaisId { get; set; }
    public Experiencia Experiencia { get; set; }
    public List<Local> Locais { get; set; }
}
