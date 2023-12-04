using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Usuario
    {
        string nome;
        string senha;

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
    }
       
}
