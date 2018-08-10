using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloOpComerciais
    {
        private int codigo, maxprod, maxserv, idctcustos;
        private double descmaxitem, descmaxnota;
        private string descricao, abreviacao, cfopd, cfopf, serienf, tpmoviment, tpdevol, tpdocfiscal, repetidos, preco, atualizacompra;
        private bool movestoque, docfiscal, calcimposto, estnegativo, naoaltpreco, numautomatico, movdeposito, inativo;
        
        public int Codigo { get => codigo; set => codigo = value; }
        public int MaxProd { get => maxprod; set => maxprod = value; }
        public int MaxServ { get => maxserv; set => maxserv = value; }
        public int IdCustos { get => idctcustos; set => idctcustos = value; }
        public double DescMaxItem { get => descmaxitem; set => descmaxitem = value; }
        public double DescMaxNota { get => descmaxnota; set => descmaxnota = value; }
        public string Descricao { get => descricao; set => descricao = value; }        
        public string Abreviacao { get => abreviacao; set => abreviacao = value; }
        public string CfopD { get => cfopd; set => cfopd = value; }
        public string CfopF { get => cfopf; set => cfopf = value; }
        public string SerieNF { get => serienf; set => serienf = value; }
        public string TpMoviment { get => tpmoviment; set => tpmoviment = value; }
        public string TpDevol { get => tpdevol; set => tpdevol = value; }
        public string TpDocFiscal { get => tpdocfiscal; set => tpdocfiscal = value; }
        public string Repetidos { get => repetidos; set => repetidos = value; }
        public string Preco { get => preco; set => preco = value; }
        public string AtualizaCompra { get => atualizacompra; set => atualizacompra = value; }
        public bool MovEstoque { get => movestoque; set => movestoque = value; }
        public bool DocFiscal { get => docfiscal; set => docfiscal = value; }
        public bool CalcImposto { get => calcimposto; set => calcimposto = value; }
        public bool EstNegativo { get => estnegativo; set => estnegativo = value; }
        public bool NaoAltPreco { get => naoaltpreco; set => naoaltpreco = value; }
        public bool NumAutomatico { get => numautomatico; set => numautomatico = value; }
        public bool MovDeposito { get => movdeposito; set => movdeposito = value; }
        public bool Inativo { get => inativo; set => inativo = value; }
    }
}
