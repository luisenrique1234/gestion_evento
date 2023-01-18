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
    public partial class Reporte_Panticipante : Form
    {
        public Reporte_Panticipante()
        {
            InitializeComponent();
        }

        private void Reporte_Panticipante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1Participante.Participante' Puede moverla o quitarla según sea necesario.
            this.ParticipanteTableAdapter.Fill(this.DataSet1Participante.Participante);

            this.reportViewer1.RefreshReport();
        }
    }
}
