using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    class Skins
    {
        string nome;
        int arma, raridade;
        float preco;

        public string Nome { get => nome; set => nome = value; }
        public int Arma { get => arma; set => arma = value; }
        public int Raridade { get => raridade; set => raridade = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
