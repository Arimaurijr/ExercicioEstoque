using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Produto(int id, string nome)
        {
            this.ID = id;
            this.Nome = nome;
        }
        public override string ToString()
        {
            return "\nDados do PRODUTO:\nID: " + ID + "\nNome: " + Nome + "\n\n";
        }
    }
}
