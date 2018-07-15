using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using DAO;

namespace GUI
{
    public partial class frm_Relatorio : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        public frm_Relatorio()
        {
            InitializeComponent();
        }

        private void frm_Relatorio_Load(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            //report1.GetDataSource(cx);
        }
    }
}
