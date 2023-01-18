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
    public partial class Busqueda_Evento : Form
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
        public Busqueda_Evento()
        {
            InitializeComponent();
        }

        private void Busqueda_Evento_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Busqueda_Evento_Load(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Evento");
            tbBuscarEvento.Focus();
        }

        private void tbBuscarEvento_TextChanged(object sender, EventArgs e)
        {
            MostrarDatos("Select * From Evento Where (" + cbEvento.Text + " Like '%" + tbBuscarEvento.Text + "%')");
            tbBuscarEvento.Focus();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Descripsion_de_Envto.modificar = false;
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            Descripsion_de_Envto.modificar = true;
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
            Descripsion_de_Envto.vidEvento = Convert.ToInt32(fila.Cells[0].Value);
            Descripsion_de_Envto.vNombre = Convert.ToString(fila.Cells[8].Value);
            Descripsion_de_Envto.vPrecio = Convert.ToInt32(fila.Cells[3].Value);
            Descripsion_de_Envto.vCupo = Convert.ToInt32(fila.Cells[9].Value);
            Descripsion_de_Envto.vDuracion = Convert.ToInt32(fila.Cells[10].Value);
            Descripsion_de_Envto.vLugar = Convert.ToString(fila.Cells[1].Value);
            Descripsion_de_Envto.vHora = Convert.ToString(fila.Cells[2].Value);
            Descripsion_de_Envto.vFecha= Convert.ToString(fila.Cells[4].Value);
            Descripsion_de_Envto.vDescripcion = Convert.ToString(fila.Cells[5].Value);
            Descripsion_de_Envto.vEncargado = Convert.ToString(fila.Cells[6].Value);
            //Procesos
            Realizacion_de_Evento.vidEvento = Convert.ToInt32(fila.Cells[0].Value);
            Realizacion_de_Evento.xNombre = Convert.ToString(fila.Cells[8].Value);
            Realizacion_de_Evento.vPrecio = Convert.ToInt32(fila.Cells[3].Value);
            Realizacion_de_Evento.vCupo = Convert.ToInt32(fila.Cells[9].Value);
            Realizacion_de_Evento.vDuracion = Convert.ToInt32(fila.Cells[10].Value);
            Realizacion_de_Evento.vLugar = Convert.ToString(fila.Cells[1].Value);
            Realizacion_de_Evento.vHora = Convert.ToString(fila.Cells[2].Value);
            Realizacion_de_Evento.vFecha = Convert.ToString(fila.Cells[4].Value);
            Realizacion_de_Evento.vDescripcion = Convert.ToString(fila.Cells[5].Value);
            Realizacion_de_Evento.vEncargado = Convert.ToString(fila.Cells[6].Value); 
        }
    }
}
