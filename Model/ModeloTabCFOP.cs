using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModeloTabCFOP
    {
        private int id;
        private string natureza, descricao, es, dentro, complemento, imobilizado;

        public int Id { get => id; set => id = value; }
        public string Natureza { get => natureza; set => natureza = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string ES { get => es; set => es = value; }
        public string Dentro { get => dentro; set => dentro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Imobilizado { get => imobilizado; set => imobilizado = value; }
    }
}
