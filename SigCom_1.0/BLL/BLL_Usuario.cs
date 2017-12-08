using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SigCom_1._0.BLL
{
    class BLL_Usuario
    {
        DAO.DAO_Usuario usuario_DAO = null;

        public DataTable dao_lista_usuario()
        {
            DataTable dt = new DataTable();

            try
            {
                usuario_DAO = new DAO.DAO_Usuario();
                dt = usuario_DAO.lista_Usuario();
            }
            catch(Exception erro)
            {
                throw erro;
            }

            return dt;
        }
    }
}
