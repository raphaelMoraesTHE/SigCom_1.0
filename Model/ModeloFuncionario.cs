using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloFuncionario
    {
        private int codigo, filial, codmunicipio;
        private double comissaoAvista, comissaoAprazo, comissaoRenegociacao;
        private string nome, apelido, endereco, endNumero, complemento, bairro, cep, telefone, celular, fax, cpf, identidade, cnh, cnhCategoria, ctps, observacao;
        private DateTime dataNascimento, dataCadastro, dataCnhValidade, dataAdmissao, dataAfastamento;
        private bool inativo;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Filial { get => filial; set => filial = value; }
        public int CodMunicipio { get => codmunicipio; set => codmunicipio = value; }
        public double ComissaoAvista { get => comissaoAvista; set => comissaoAvista = value; }
        public double ComissaoAprazo { get => comissaoAprazo; set => comissaoAprazo = value; }
        public double ComissaoRenegociacao { get => comissaoRenegociacao; set => comissaoRenegociacao = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataCnhValidade { get => dataCnhValidade; set => dataCnhValidade = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public DateTime DataAfastamento { get => dataAfastamento; set => dataAfastamento = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string EndNumero { get => endNumero; set => endNumero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Identidade { get => identidade; set => identidade = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public string CnhCategoria { get => cnhCategoria; set => cnhCategoria = value; }
        public string Ctps { get => ctps; set => ctps = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public bool Inativo { get => inativo; set => inativo = value; }
    }
}
