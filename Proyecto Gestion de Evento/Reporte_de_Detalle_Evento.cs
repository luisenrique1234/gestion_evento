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
    public partial class Reporte_de_Detalle_Evento : Form
    {
        public Reporte_de_Detalle_Evento()
        {
            InitializeComponent();
        }

        private void Reporte_de_Detalle_Evento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1DetallesEvento.Evento' Puede moverla o quitarla según sea necesario.
            this.EventoTableAdapter.Fill(this.DataSet1DetallesEvento.Evento);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1DetallesEvento.Expositor' Puede moverla o quitarla según sea necesario.
            this.ExpositorTableAdapter.Fill(this.DataSet1DetallesEvento.Expositor);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1DetallesEvento.Participante' Puede moverla o quitarla según sea necesario.
            this.ParticipanteTableAdapter.Fill(this.DataSet1DetallesEvento.Participante);

            this.reportViewer1.RefreshReport();
        }
    }
}
