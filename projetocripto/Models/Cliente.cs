using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetocripto.Models
{
    public enum Estado { AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO}
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
        [Required(ErrorMessage = "Campo CIDADE é obrigatorio...")]
        [Display(Name = "Cidade: ")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Campo ESTADO é obrigatorio...")]
        [Display(Name = "Estado: ")]
        public Estado estado { get; set; }

        [Range(18, 80, ErrorMessage = "Idade entre 18 - 80 Anos...")]
        [Display(Name = "Idade: ")]
        public int idade { get; set; }

        public ICollection<Conta> contas { get; set; }
        
    }
}
