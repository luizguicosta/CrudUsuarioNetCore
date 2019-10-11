using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int IdUsuario { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Perfil é obrigatório")]
        [Display(Name ="Perfil")]
        public int IdPerfil { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
