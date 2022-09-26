using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projetocripto.Models
{
    public enum Operacao {Compra, Venda}
    [Table("Transacoes")]
    public class Transasao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID:")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo IMPRESSORA é obrigatorio...")]
        [Display(Name = "Impressora: ")]
        public Conta impressora { get; set; }

        [Display(Name = "Data: ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy")]
        public DateTime data { get; set; }
    }
}
