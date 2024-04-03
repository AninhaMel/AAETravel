using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Usuario")]
public class Usuario
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
     public string Descricao { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
}