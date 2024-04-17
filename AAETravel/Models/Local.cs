using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Local")]
public class Local
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

        public int ExperienciaId { get; set; }
        [ForeignKey("Experiencia")]
        public Local Experiencia { get; set; }
}