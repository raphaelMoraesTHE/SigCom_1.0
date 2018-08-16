using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloPlanosPagamento
    {
        private int codigo, maxparcelas, primeirovenc, limiteprimeirovenc, limiteultimovenc, vencparcelas;
        private double comissao, valminvenda, maxdesconto, minentrada, jurosfincomentrada, jurosfinsememtrada;
        private string descricao, pagamento, abreviacao, tpcomissao, tpvencimento;
        private bool descnota, descitem, precoprom, entrobrigatoria, altquantparc, altvalparc, valintparc;

        public int Codigo { get => codigo; set => codigo = value; }
        public int MaxParcelas { get => maxparcelas; set => maxparcelas = value; }
        public int PrimeiroVenc { get => primeirovenc; set => primeirovenc = value; }
        public int LimitePrimeiroVenc { get => limiteprimeirovenc; set => limiteprimeirovenc = value; }
        public int LimiteUltimoVenc { get => limiteultimovenc; set => limiteultimovenc = value; }
        public int VencParcelas { get => vencparcelas; set => vencparcelas = value; }
        public double Comissao { get => comissao; set => comissao = value; }
        public double ValMinVenda { get => valminvenda; set => valminvenda = value; }
        public double MaxDesconto { get => maxdesconto; set => maxdesconto = value; }
        public double MinEntrada { get => minentrada; set => minentrada = value; }
        public double JurosFincomEntrada { get => jurosfincomentrada; set => jurosfincomentrada = value; }
        public double JurosFinsemEmtrada { get => jurosfinsememtrada; set => jurosfinsememtrada = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Pagamento { get => pagamento; set => pagamento = value; }
        public string Abreviacao { get => abreviacao; set => abreviacao = value; }
        public string TpComissao { get => tpcomissao; set => tpcomissao = value; }
        public string TpVencimento { get => tpvencimento; set => tpvencimento = value; }
        public bool DescNota { get => descnota; set => descnota = value; }
        public bool DescItem { get => descitem; set => descitem = value; }
        public bool PrecoProm { get => precoprom; set => precoprom = value; }
        public bool EntrObrigatoria { get => entrobrigatoria; set => entrobrigatoria = value; }
        public bool AltQuantParc { get => altquantparc; set => altquantparc = value; }
        public bool AltValParc { get => altvalparc; set => altvalparc = value; }
        public bool ValIntParc { get => valintparc; set => valintparc = value; }
    }
}
