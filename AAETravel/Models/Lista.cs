using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAETravel.Models;

[Table("Lista")]
public class Lista
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

         public int LocalId { get; set; }
        [ForeignKey("LocalId")]
        public Local Local { get; set; }

}