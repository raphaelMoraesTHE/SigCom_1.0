using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloTabMunicipio
    {
        private int codigo, codigoUF;
        private string nome, siglaUF;

        public int Codigo { get => codigo; set => codigo = value; }
        public int CodigoUF { get => codigoUF; set => codigoUF = value; }
        public string Nome { get => nome; set => nome = value; }
        public string SiglaUF { get => siglaUF; set => siglaUF = value; }
    }
}
