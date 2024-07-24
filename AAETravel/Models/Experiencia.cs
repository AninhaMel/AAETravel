using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;
[Table("Experiencia")]

public class Experiencia
{

     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int Id { get; set; }

     public string Nome { get; set; }

     [StringLength(300)]
     public string Foto { get; set; }

     public string Cor { get; set; }

     [StringLength(300)]
     public string Fundo { get; set; }
     public List<ExperienciaLocal> ExperienciasLocais { get; set; }

}
