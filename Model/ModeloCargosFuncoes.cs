using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloCargosFuncoes
    {
        private int codigo;
        private string descricao;
        private bool vendedor, tecnico, motorista, supervisor, cobrador, outros;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool Vendedor { get => vendedor; set => vendedor = value; }
        public bool Tecnico { get => tecnico; set => tecnico = value; }
        public bool Motorista { get => motorista; set => motorista = value; }
        public bool Supervisor { get => supervisor; set => supervisor = value; }
        public bool Cobrador { get => cobrador; set => cobrador = value; }
        public bool Outros { get => outros; set => outros = value; }
    }
}
