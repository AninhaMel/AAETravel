using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

public class ExperienciaLocal
{
    public int LocalId { get; set; }
    [ForeignKey("LocalId")]
    public Local Local { get; set; }

    public int ExperienciaId { get; set; }
    [ForeignKey("ExperienciaId")]
    public Experiencia Experiencia { get; set; }
}
