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
    public class BLL_TabMunicipio
    {
        DAO_TabMunicipio tabMunicipio_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;
        
        public BLL_TabMunicipio(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public DataTable pesquisa_Municipio_Nome(String pesquisa)
        {
            try
            {
                tabMunicipio_DAO = new DAO_TabMunicipio(conexao);
                return tabMunicipio_DAO.pesquisa_Municipio_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Municipio()
        {
            try
            {
                tabMunicipio_DAO = new DAO_TabMunicipio(conexao);
                return tabMunicipio_DAO.lista_Municipio();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloTabMunicipio carregaModeloMunicipio(int codigo)
        {
            try
            {
                tabMunicipio_DAO = new DAO_TabMunicipio(conexao);
                return tabMunicipio_DAO.carregaModeloMunicipio(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
