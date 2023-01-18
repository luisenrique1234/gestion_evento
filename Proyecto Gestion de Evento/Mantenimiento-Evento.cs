using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestion_de_Evento
{
    public partial class Mantenimiento_Evento : Form
    {
        public Mantenimiento_Evento()
        {
            InitializeComponent();
        }
        SIGEN_Conexion sql = new SIGEN_Conexion();

        private void Mantenimiento_Evento_Load(object sender, EventArgs e)
        {
            dataGridEvento.DataSource = sql.MostrarDatos3();
        }
    }
}
