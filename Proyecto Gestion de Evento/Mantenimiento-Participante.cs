using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Proyecto_Gestion_de_Evento
{
    public partial class Mantenimiento_Participante : Form
    {
        private bool nuevo = false;
        private bool modificar = false;

        private void Limpiar()
        {
            textBox4.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            IDP.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitaControles(bool valor)
        {
            textBox1.Enabled = valor;
            textBox2.Enabled = valor;
            textBox3.Enabled = valor;
            textBox4.Enabled = valor;
            textBox5.Enabled = valor;
            textBox6.Enabled = valor;
            textBox7.Enabled = valor;
            IDP.Enabled = valor;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitarBotones()
        {
            if (nuevo || modificar)
            {
                HabilitaControles(true);
                bNuevo.Enabled = false;
                button2.Enabled = true;
                bModificar.Enabled = false;
                button1.Enabled = true;
                bCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                bNuevo.Enabled = true;
                bModificar.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = false;
                bCancelar.Enabled = false;
            }
        }
        

        



        public Mantenimiento_Participante()
        {
            InitializeComponent();
        }

        SIGEN_Conexion sql = new SIGEN_Conexion();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[1].Value);
            textBox2.Text = Convert.ToString(fila.Cells[2].Value);
            textBox3.Text = Convert.ToString(fila.Cells[6].Value);
            textBox5.Text = Convert.ToString(fila.Cells[3].Value);
            textBox6.Text = Convert.ToString(fila.Cells[4].Value);
            textBox7.Text = Convert.ToString(fila.Cells[5].Value);
            IDP.Text = Convert.ToString(fila.Cells[0].Value);

        }

        private void Mantenimiento_Participante_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.MostrarDatos();
            nuevo = false; modificar = false; HabilitaControles(false); HabilitarBotones();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sql.Eliminar(IDP.Text))
            {
                dataGridView1.DataSource = sql.MostrarDatos();
                MessageBox.Show("Dato Eliminado");
            }
            else { 
                MessageBox.Show("No se a podido Eliminar datos"); 
                 }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                try
                {
                    string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
                    SqlConnection mi_conexion = new SqlConnection(connectionstring);
                    mi_conexion.Open();
                    string commandString = "insert into Participante(Nombre,Apellido,Cedula,Sexo,Correo,Telefono)values(@Nombre,@Apellido,@Cedula,@Sexo,@Correo,@Telefono)";

                    SqlCommand com = new SqlCommand(commandString, mi_conexion);
                    com.Parameters.Add(new SqlParameter("@Nombre", textBox1.Text));
                    com.Parameters.Add(new SqlParameter("@Apellido", textBox2.Text));
                    com.Parameters.Add(new SqlParameter("@Cedula", textBox3.Text));
                    com.Parameters.Add(new SqlParameter("@Sexo", textBox5.Text));
                    com.Parameters.Add(new SqlParameter("@Correo", textBox6.Text));
                    com.Parameters.Add(new SqlParameter("@Telefono", textBox7.Text));

                    com.ExecuteNonQuery();
                    mi_conexion.Close();
                }
                finally { }
            }
            else
                if (modificar)
                {
                    try
                    {
                        string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
                        SqlConnection mi_conexion = new SqlConnection(connectionstring);
                        mi_conexion.Open();
                        string commandString = "update Participante set Nombre= @Nombre ,Apellido = @Apellido,Cedula= @Cedula,Sexo= @Sexo,Correo= @Correo,Telefono= @Telefono where idParticipante=@pid";

                        SqlCommand com = new SqlCommand(commandString, mi_conexion);
                        com.Parameters.Add(new SqlParameter("@pid", IDP.Text));
                        com.Parameters.Add(new SqlParameter("@Nombre", textBox1.Text));
                        com.Parameters.Add(new SqlParameter("@Apellido", textBox2.Text));
                        com.Parameters.Add(new SqlParameter("@Cedula", textBox3.Text));
                        com.Parameters.Add(new SqlParameter("@Sexo", textBox5.Text));
                        com.Parameters.Add(new SqlParameter("@Correo", textBox6.Text));
                        com.Parameters.Add(new SqlParameter("@Telefono", textBox7.Text));

                        com.ExecuteNonQuery();
                        mi_conexion.Close();
                    }
                    finally { }
                }
            MessageBox.Show("\n Guardado.... \n");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text !="") dataGridView1.DataSource = sql.Buscar(textBox4.Text);
           else dataGridView1.DataSource = sql.MostrarDatos();
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            modificar = false;
            Limpiar();
            HabilitaControles(true);
            HabilitarBotones();
            textBox1.Focus();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; Limpiar(); HabilitaControles(false); HabilitarBotones();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IDP.Text == "")
            {
                MessageBox.Show("Selecione un registro para modificar ");
            }
            else
            {
                nuevo = false;
                modificar = true;
                HabilitaControles(true);
                HabilitarBotones();
                textBox1.Focus();
            }
        }

        private void bReporte_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
