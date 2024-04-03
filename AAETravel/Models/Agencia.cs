using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Agencia")]
public class Agencia
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
     public string Descricao { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }
        public string Link { get; set; }
}