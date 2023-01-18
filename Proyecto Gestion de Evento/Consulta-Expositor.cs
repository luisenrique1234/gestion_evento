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
    public partial class Consulta_Expositor : Form
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
                dataGridView1.DataSource = mi_bindingsource; // se asigna el bindingsource como datasource
                bindingNavigator1.BindingSource = mi_bindingsource; //tanto del gridview como del navigator
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
            }
        }
        public Consulta_Expositor()
        {
            InitializeComponent();
        }

        private void Consulta_Expositor_Load(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Expositor");
            tbBuscar.Focus();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Expositor Where (" + cbBusquedas.Text + " Like '%" + tbBuscar.Text + "%')");
            tbBuscar.Focus();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bReporte_Click(object sender, EventArgs e)
        {
            Reporte_Expositor fmant_cargo = new Reporte_Expositor(); fmant_cargo.ShowDialog();
        }

        private void Consulta_Expositor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }
    }
}
