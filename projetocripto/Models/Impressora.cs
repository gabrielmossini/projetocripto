using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetocripto.Models
{
    public enum Status { Sim, Não}
    [Table("Impressora")]
    public class Impressora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo LOCAL é obrigatorio...")]
        [Display(Name = "Local: ")]
        public string setor { get; set; }

        [Required(ErrorMessage = "Campo RESET é obrigatorio...")]
        [Display(Name = "Feito Reset: ")]
        public Status status { get; set; }

        [DataType(DataType.Date)]
        public DateTime data { get; set; }
    }
}
