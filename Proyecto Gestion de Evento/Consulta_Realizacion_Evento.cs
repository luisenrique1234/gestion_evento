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
    public partial class Consulta_Realizacion_Evento : Form
    {
        public static string miconexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";


        private void MostrarDatos(string sql) //recibe un parámetro con la instrucción sql deseada
        {
            SqlConnection mi_conexion = new SqlConnection(miconexion); //conexión a la base de datos
            try
            {
                BindingSource mi_bindingsource = new BindingSource(); //se crea un objeto bindingsource
                SqlDataAdapter mi_dataadapter = new SqlDataAdapter(sql, mi_conexion); //Se crea el select
                DataTable mi_datatable = new DataTable();
                mi_conexion.Open();
                mi_dataadapter.Fill(mi_datatable); //se llena el datatable con el resultado del select
                mi_bindingsource.DataSource = mi_datatable; //se establece el datasouce con el datatable
                ConsultaR.DataSource = mi_bindingsource; // se asigna el bindingsource como datasource
                bindingNavigator3.BindingSource = mi_bindingsource; //tanto del gridview como del navigator
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
            }
        }

        public Consulta_Realizacion_Evento()
        {
            InitializeComponent();
        }

        private void Consulta_Realizacion_Evento_Load(object sender, EventArgs e)
        {
            //MostrarDatos("Select * From EventoDetalles2");

            //MostrarDatos("SELECT EventoDetalles.ID_Evento, Participante.Nombre FROM EventoDetalles INNER JOIN Participante ON EventoDetalles.ID_Evento = Participante.IdParticipante");

            //MostrarDatos("SELECT EventoDetalles.ID_Evento,EventoDetalles.ID_Participante, Participante.Nombre FROM EventoDetalles INNER JOIN Participante ON EventoDetalles.ID_Participante= Participante.IdParticipante");

            //MostrarDatos("SELECT EventoDetalles.ID_Evento , Evento.Nombre AS Evento,Evento.Fecha,Evento.Lugar,Participante.Nombre AS Participante,Participante.Apellido,Participante.Correo,Participante.Telefono FROM ((EventoDetalles INNER JOIN Participante ON EventoDetalles.ID_Participante =  Participante.IdParticipante) INNER JOIN Evento ON EventoDetalles.ID_Evento = Evento.IdEvento)");

            MostrarDatos("SELECT EventoDetalles2.ID_Evento , Evento.Nombre AS Evento,Evento.Fecha,Evento.Lugar,Expositor.Nombre AS Expositor,Participante.Nombre AS Participante,Participante.Apellido,Participante.Correo,Participante.Telefono FROM (((EventoDetalles2 INNER JOIN Participante ON EventoDetalles2.ID_Participante =  Participante.IdParticipante) INNER JOIN Evento ON EventoDetalles2.ID_Evento = Evento.IdEvento) INNER JOIN Expositor ON EventoDetalles2.ID_Expositor = Expositor.IdExpositor)");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbRealizacionE_TextChanged(object sender, EventArgs e)
        {
            //MostrarDatos("SELECT EventoDetalles.ID_Evento , Evento.Nombre AS Evento,Evento.Fecha,Evento.Lugar,Participante.Nombre AS Participante,Participante.Apellido,Participante.Correo,Participante.Telefono FROM ((EventoDetalles INNER JOIN Participante ON EventoDetalles.ID_Participante =  Participante.IdParticipante) INNER JOIN Evento ON EventoDetalles.ID_Evento = Evento.IdEvento) Where (Evento.Nombre Like '%" + tbRealizacionE.Text + "%')");

            MostrarDatos("SELECT EventoDetalles2.ID_Evento , Evento.Nombre AS Evento,Evento.Fecha,Evento.Lugar,Expositor.Nombre AS Expositor,Participante.Nombre AS Participante,Participante.Apellido,Participante.Correo,Participante.Telefono FROM (((EventoDetalles2 INNER JOIN Participante ON EventoDetalles2.ID_Participante =  Participante.IdParticipante) INNER JOIN Evento ON EventoDetalles2.ID_Evento = Evento.IdEvento) INNER JOIN Expositor ON EventoDetalles2.ID_Expositor = Expositor.IdExpositor) Where (Evento.Nombre Like '%" + tbRealizacionE.Text + "%')");
        

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Consulta_Realizacion_Evento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }

        private void BReporte_Click(object sender, EventArgs e)
        {
            Reporte_de_Detalle_Evento fmant_cargo = new Reporte_de_Detalle_Evento(); fmant_cargo.ShowDialog();
        }
    }
}
