using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloSaldoCaixa
    {
        private int codigo;
        private string descricao, tiposaldo;
        private bool tef, prazo, inativo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string TipoSaldo { get => tiposaldo; set => tiposaldo = value; }
        public bool Tef { get => tef; set => tef = value; }
        public bool Prazo { get => prazo; set => prazo = value; }
        public bool Inativo { get => inativo; set => inativo = value; }
    }
}
