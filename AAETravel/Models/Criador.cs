using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Criador")]
public class Criador
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobre { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

}
