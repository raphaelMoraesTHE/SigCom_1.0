using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloUsuario
    {
        private int codigo, filial, caixa;
        private string nome, senha, email;
        private DateTime dataCad;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Filial { get => filial; set => filial = value; }
        public int Caixa { get => caixa; set => caixa = value; }
        public DateTime DataCad { get => dataCad; set => dataCad = value; } //Modelo referente a campo do formato data no banco de dados
        public string Email { get => email; set => email = value; }
    }
}
