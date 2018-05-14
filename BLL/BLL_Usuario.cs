using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Model;

namespace BLL
{
    public class BLL_Usuario
    {
        DAO_Usuario usuario_DAO = null;

        public DataTable dao_lista_usuario()
        {
            DataTable dt = new DataTable();

            try
            {
                usuario_DAO = new DAO_Usuario();
                dt = usuario_DAO.lista_Usuario();
            }
            catch (Exception erro)
            {
                throw erro;
            }

            return dt;
        }

        public void dao_grava_usuario(ModeloUsuario usuario)
        {
            try
            {
                usuario_DAO = new DAO_Usuario();
                usuario_DAO.grava_Usuario(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
