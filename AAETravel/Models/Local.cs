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
        public string Localizacao {get; set;}
        public string Telefone {get; set;}
        public string HorarioFuncionamento {get; set;}
        public string Descricao { get; set; }

        [StringLength(300)]
        public string Foto { get; set; }

        public int PaisId { get; set; }
        [ForeignKey("Pais")]
        public Local Pais { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
}