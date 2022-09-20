﻿namespace projetocripto.Models
{
    public class Conta
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Moeda moeda { get; set; }
        public float quantidade { get; set; }

        public ICollection<Transasao> transasoes { get; set; }
    }
}
