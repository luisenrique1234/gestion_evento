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
    public partial class Reporte_Expositor : Form
    {
        public Reporte_Expositor()
        {
            InitializeComponent();
        }

        private void Reporte_Expositor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetExpositor.Expositor' Puede moverla o quitarla según sea necesario.
            this.ExpositorTableAdapter.Fill(this.DataSetExpositor.Expositor);

            this.reportViewer1.RefreshReport();
        }
    }
}
