using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloTabUF
    {
        private int codigo;
        private double icmsInterno, nfceValMaximo, clienteMinimoIdentificacao;
        private bool nfceMeioPagamentoXML;
        private string nome, sigla;

        public int Codigo { get => codigo; set => codigo = value; }
        public double IcmsInterno { get => icmsInterno; set => icmsInterno = value; }
        public double NfceValMaximo { get => nfceValMaximo; set => nfceValMaximo = value; }
        public double ClienteMinimoIdentificacao { get => clienteMinimoIdentificacao; set => clienteMinimoIdentificacao = value; }
        public bool NfceMeioPagamentoXML { get => nfceMeioPagamentoXML; set => nfceMeioPagamentoXML = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
    }
}
