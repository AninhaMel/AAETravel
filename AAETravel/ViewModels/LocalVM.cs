using AAETravel.Models;

namespace AAETravel.ViewModels;

public class LocalVM
{
    public int PaisId { get; set; }
    public int ExperienciaId { get; set; }
    public Experiencia Experiencias { get; set; }
    public Local Locais { get; set; }
    public List<Lista> Lista { get; set; }
}
