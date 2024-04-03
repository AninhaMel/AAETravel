using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Cidade")]
public class Cidade
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

        public int? PaisId { get; set; }
        [ForeignKey("PaisId")]
        public Cidade Pais { get; set; }
}
