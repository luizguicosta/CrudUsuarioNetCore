using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Perfil")]
    public class Perfil
    {
        public Perfil()
        {
           this.Funcionalidades = new List<Funcionalidade>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPerfil { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Nome do perfil é obrigatório")]
        [Display(Name ="Nome do Perfil")]
        public string NomePerfil { get; set; }
        [Display(Name = "Data de cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual List<Funcionalidade> Funcionalidades { get; set; }
    }
}
