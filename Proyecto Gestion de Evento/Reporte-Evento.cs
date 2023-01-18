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
    public partial class Reporte_Evento : Form
    {
        public Reporte_Evento()
        {
            InitializeComponent();
        }

        private void Reporte_Evento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEvento.Evento' Puede moverla o quitarla según sea necesario.
            this.EventoTableAdapter.Fill(this.DataSetEvento.Evento);

            this.reportViewer1.RefreshReport();
        }
    }
}
