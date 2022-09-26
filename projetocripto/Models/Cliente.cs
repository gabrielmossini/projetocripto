using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetocripto.Models
{
    public enum Secretaria { Administração, Agricultura, Jurídico, Cultura, Educação, Esporte, Planejamento, Infraestrutura, Saúde, Assistência }
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo NOME é obrigatorio...")]
        [Display(Name = "Nome: ")]
        public string nome { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo SETOR é obrigatorio...")]
        [Display(Name = "Setor: ")]
        public string setor { get; set; }

        [Required(ErrorMessage = "Campo SECRETARIA é obrigatorio...")]
        [Display(Name = "Secretaria: ")]
        public Secretaria secretaria { get; set; }

        public ICollection<Conta> contas { get; set; }
        
    }
}
