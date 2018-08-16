using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloDocumentos
    {
        private string codigo, descricao;
        private bool inativo, ordpag;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool OrdPag { get => ordpag; set => ordpag = value; }
        public bool Inativo { get => inativo; set => inativo = value; }
    }
}
