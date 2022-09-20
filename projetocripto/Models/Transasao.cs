namespace projetocripto.Models
{
    public enum Operacao {Compra, Venda}
    public class Transasao
    {
        public int id { get; set; }
        public Conta conta { get; set; }
        public DateTime data { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
        public Operacao operacao { get; set; }

    }
}
