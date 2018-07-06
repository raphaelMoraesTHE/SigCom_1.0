using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloEmpresa
    {
        private int codigo, codmunicipio;
        private string nome, fantasia, sigla, endereco, endnumero, complemento, bairro, cep, telefone, celular, fax, cnpj, inscestadual, inscmunicipal, cnae, regtributario, natreceita, email, site, observacao;

        public int Codigo { get => codigo; set => codigo = value; }
        public int CodMunicipio { get => codmunicipio; set => codmunicipio = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Fantasia { get => fantasia; set => fantasia = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string EndNumero { get => endnumero; set => endnumero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscEstadual { get => inscestadual; set => inscestadual = value; }
        public string InscMunicipal { get => inscmunicipal; set => inscmunicipal = value; }
        public string Cnae { get => cnae; set => cnae = value; }
        public string RegTributario { get => regtributario; set => regtributario = value; }
        public string NatReceita { get => natreceita; set => natreceita = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
