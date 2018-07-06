using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloCaixa
    {
        private int codigo;
        private string descricao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
