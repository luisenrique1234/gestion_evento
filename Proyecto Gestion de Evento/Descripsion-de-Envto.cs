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
    public partial class Descripsion_de_Envto : Form
    {
        public static bool nuevo = false;
        public static bool modificar = false;

        public static int vidEvento = 0, vPrecio = 0, vCupo = 0, vDuracion = 0;
        public static string vLugar, vHora, vFecha, vDescripcion, vEncargado, vNombre;

        private void Limpiar()
        {
            tbNombre.Text = string.Empty;
            tbHora.Text = string.Empty;
            tbFecha.Text = string.Empty;
            tbDuracion.Text = string.Empty;
            tbEncargado.Text = string.Empty;
            tbCupo.Text = string.Empty;
            tbPrecio.Text = string.Empty;
            tbDescripsion.Text = string.Empty;
            tbLugar.Text = string.Empty;
            tbIDEvento.Text = string.Empty;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitaControles(bool valor)
        {
            tbNombre.Enabled = valor;
            tbHora.Enabled = valor;
            tbFecha.Enabled = valor;
            tbDuracion.Enabled = valor;
            tbEncargado.Enabled = valor;
            tbCupo.Enabled = valor;
            tbPrecio.Enabled = valor;
            tbDescripsion.Enabled = valor;
            tbLugar.Enabled = valor;
            tbIDEvento.Enabled = valor;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitarBotones()
        {
            if (nuevo || modificar)
            {
                HabilitaControles(true);
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BModificar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BModificar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }
        public Descripsion_de_Envto()
        {
            InitializeComponent();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            modificar = false;
            Limpiar();
            HabilitaControles(true);
            HabilitarBotones();
            tbNombre.Focus();
        }

        private void Descripsion_de_Envto_Load(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; HabilitaControles(false); HabilitarBotones();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Descripsion_de_Envto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SendKeys.Send("{TAB}"); }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; Limpiar(); HabilitaControles(false); HabilitarBotones();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
           { 
            try
            {

                string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
                SqlConnection mi_conexion = new SqlConnection(connectionstring);
                mi_conexion.Open();
                string commandString = "insert into Evento(Nombre,Hora,Precio,Fecha,Descripcion,Encargado,Cupo,Duracion,Lugar)values(@Nombre,@Hora,@Precio,@Fecha,@Descripcion,@Encargado,@Cupo,@Duracion,@Lugar)";
                SqlCommand com = new SqlCommand(commandString, mi_conexion);
                com.Parameters.Add(new SqlParameter("@Nombre", tbNombre.Text));
                com.Parameters.Add(new SqlParameter("@Hora", tbHora.Text));
                com.Parameters.Add(new SqlParameter("@Fecha", tbFecha.Text));
                com.Parameters.Add(new SqlParameter("@Duracion", tbDuracion.Text));
                com.Parameters.Add(new SqlParameter("@Encargado", tbEncargado.Text));
                com.Parameters.Add(new SqlParameter("@Cupo", tbCupo.Text));
                com.Parameters.Add(new SqlParameter("@Precio", tbPrecio.Text));
                com.Parameters.Add(new SqlParameter("@Descripcion", tbDescripsion.Text));
                com.Parameters.Add(new SqlParameter("@Lugar", tbLugar.Text));

                com.ExecuteNonQuery();
                mi_conexion.Close();
                Limpiar();

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
                        string commandString = "update Evento set Nombre= @Nombre ,Hora = @Hora,Fecha= @Fecha,Duracion= @Duracion,Encargado= @Encargado,Cupo= @Cupo,Precio= @Precio,Descripcion= @Descripcion,Lugar= @Lugar where IdEvento=@pid";

                        SqlCommand com = new SqlCommand(commandString, mi_conexion);
                        com.Parameters.Add(new SqlParameter("@pid", tbIDEvento.Text));
                        com.Parameters.Add(new SqlParameter("@Nombre", tbNombre.Text));
                        com.Parameters.Add(new SqlParameter("@Hora", tbHora.Text));
                        com.Parameters.Add(new SqlParameter("@Fecha", tbFecha.Text));
                        com.Parameters.Add(new SqlParameter("@Duracion", tbDuracion.Text));
                        com.Parameters.Add(new SqlParameter("@Encargado", tbEncargado.Text));
                        com.Parameters.Add(new SqlParameter("@Cupo", tbCupo.Text));
                        com.Parameters.Add(new SqlParameter("@Precio", tbPrecio.Text));
                        com.Parameters.Add(new SqlParameter("@Descripcion", tbDescripsion.Text));
                        com.Parameters.Add(new SqlParameter("@Lugar", tbLugar.Text));

                        com.ExecuteNonQuery();
                        mi_conexion.Close();
                    }
                    finally { }
                }



            MessageBox.Show("\n Guardado.... \n");

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Descripsion_de_Envto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            vidEvento = 0;
            Busqueda_Evento fbcargo = new Busqueda_Evento();
            fbcargo.ShowDialog();
            if (modificar)
            {
                tbIDEvento.Text = Convert.ToString(vidEvento);
                tbNombre.Text = vNombre;
                tbHora.Text = vHora;
                tbFecha.Text = vFecha;
                tbDuracion.Text = Convert.ToString(vDuracion);
                tbEncargado.Text = vEncargado;
                tbLugar.Text = vLugar;
                tbDescripsion.Text = vDescripcion;
                tbCupo.Text = Convert.ToString(vCupo);
                tbPrecio.Text = Convert.ToString(vPrecio);

                BModificar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                vNombre = ""; vEncargado = ""; vidEvento = 0;
                Limpiar();
                BBuscar.Focus();

            }

            
        }


        private void BModificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            modificar = true;
            HabilitaControles(true);
            HabilitarBotones();
            tbNombre.Focus();
        
        }

        
    }
}
