using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Gestion_de_Evento
{
    public partial class Mantenimiento_Expocitor : Form
    {

        public Mantenimiento_Expocitor()
        {
            InitializeComponent();
        }
        SIGEN_Conexion sql = new SIGEN_Conexion();

        private void dataGridEX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mantenimiento_Expocitor_Load(object sender, EventArgs e)
        {
            dataGridEX.DataSource = sql.MostrarDatos2();
        }
    }
}
