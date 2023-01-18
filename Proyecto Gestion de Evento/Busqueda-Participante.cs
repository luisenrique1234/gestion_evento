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
    

    public partial class Busqueda_Participante : Form
    {
        //public Busqueda_Participante();
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
                dataGridView1.DataSource = mi_bindingsource; // se asigna el bindingsource como datasource
                Navigator.BindingSource = mi_bindingsource; //tanto del gridview como del navigator
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
            }
        }
     
        public Busqueda_Participante()
        {
            InitializeComponent();
        }

        private void Busqueda_Participante_Load(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Participante");
            tbBuscar.Focus();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Participante Where (" + cbBusquedas.Text + " Like '%" + tbBuscar.Text + "%')");
            tbBuscar.Focus();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            RegistrodePartipante.modificar = false;
           Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            RegistrodePartipante.modificar = true;
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa en el encabezado, RowIndex será menor que cero
            if (!(e.RowIndex > -1))
            {
                return;
            }
            //obtienes la fila seleccionada
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            //por el número obtiene la columna
            RegistrodePartipante.vidParticipante = Convert.ToInt32(fila.Cells[0].Value);
            RegistrodePartipante.vNombre = Convert.ToString(fila.Cells[1].Value);
            RegistrodePartipante.vApellido = Convert.ToString(fila.Cells[2].Value);
            RegistrodePartipante.vCedula = Convert.ToString(fila.Cells[6].Value);
            RegistrodePartipante.vTelefono = Convert.ToString(fila.Cells[5].Value);
            RegistrodePartipante.vcorreo = Convert.ToString(fila.Cells[4].Value);
            RegistrodePartipante.vsexo = Convert.ToString(fila.Cells[3].Value);
            //Pocesos
            Realizacion_de_Evento.vidParticipante = Convert.ToInt32(fila.Cells[0].Value);
            Realizacion_de_Evento.vNombre = Convert.ToString(fila.Cells[1].Value);
            Realizacion_de_Evento.vApellido = Convert.ToString(fila.Cells[2].Value);
            Realizacion_de_Evento.vCedula = Convert.ToString(fila.Cells[6].Value);
            Realizacion_de_Evento.vTelefono = Convert.ToString(fila.Cells[5].Value);
            Realizacion_de_Evento.vcorreo = Convert.ToString(fila.Cells[4].Value);
            Realizacion_de_Evento.vsexo = Convert.ToString(fila.Cells[3].Value);
            
        }
    }
}
