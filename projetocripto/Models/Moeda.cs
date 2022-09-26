using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetocripto.Models

{
    [Table("Moedas")]
    public class Moeda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo NOME é obrigatorio...")]
        [Display(Name = "Nome:")]
        public string nome { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo DESCRIÇÃO é obrigatorio...")]
        [Display(Name = "Descrição:")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo QUANTIDADE é obrigatorio...")]
        [Display(Name = "Quantidade:")]
        public int quantidade { get; set; }

        [DisplayFormat(DataFormatString = "R${0:N2}")]
        [Display(Name="Custo:")]
        public float valor { get; set; }

        public ICollection<Conta> contas { get; set; }
    }
}
