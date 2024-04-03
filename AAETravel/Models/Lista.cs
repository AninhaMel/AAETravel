using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Lista")]
public class Lista
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DataCadastro { get; set; }
        public int? UsuarioId { get; set; }
        [ForeignKey("Usuario")]
        public Lista Usuario { get; set; }

         public int? LocalId { get; set; }
        [ForeignKey("Local")]
        public Lista Local { get; set; }
}