using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetocripto.Models
{
    [Table("Contas")]
    public class Conta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo CLIENTE é obrigatorio...")]
        [Display(Name = "Cliente: ")]
        public Cliente cliente { get; set; }
        
        [Required(ErrorMessage = "Campo MOEDA é obrigatorio...")]
        [Display(Name = "Moeda: ")]
        public Moeda moeda { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Quantidade: ")]
        public float quantidade { get; set; }

        public ICollection<Transasao> transasoes { get; set; }
    }
}
