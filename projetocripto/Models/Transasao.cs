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

        [Required(ErrorMessage = "Campo CONTA é obrigatorio...")]
        [Display(Name = "Conta: ")]
        public Conta conta { get; set; }

        [Display(Name = "Data: ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy")]
        public DateTime data { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Quantidade:")]
        public float quantidade { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Venda:")]
        public float valor { get; set; }

        [Required(ErrorMessage = "Campo OPERAÇÃO é obrigatorio...")]
        [Display(Name = "Operação: ")]
        public Operacao operacao { get; set; }

    }
}
