namespace projetocripto.Models
{
    public class Moeda
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public float quantidade { get; set; }
        public float venda { get; set; }

        public ICollection<Conta> contas { get; set; }
    }
}
