using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Funcionalidade")]
    public class Funcionalidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionalidade { get; set; }
        [Required(ErrorMessage ="O nome da funcionalidade é obrigatório")]
        [MaxLength(50)]
        public string Nome { get; set; }
        public int? IdPerfil { get; set; }
        [Display(Name ="Data de cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public virtual Perfil Perfil { get; set; }
    }
}
