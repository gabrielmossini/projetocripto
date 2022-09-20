namespace projetocripto.Models
{
    public enum Estado { AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO}
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public Estado estado { get; set; }
        public int idade { get; set; }

        public ICollection<Conta> contas { get; set; }
        
    }
}
