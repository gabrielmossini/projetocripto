using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetocripto.Models

{
    [Table("Moedas")]
    public class Moeda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo nome é obrigatorio...")]
        [Display(Name = "Descrição: ")]
        public string descricao { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Quantidade: ")]
        public float quantidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name="Compra:")]
        public float compra { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Venda:")]
        public float venda { get; set; }

        public ICollection<Conta> contas { get; set; }
    }
}
