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
    public partial class Registro_Expositor : Form
    {
        public static bool nuevo = false;
        public static bool modificar = false;

        public static int eidexpositor= 0;
        public static string eNombre, eApellido, eTelefono, ecorreo, esexo;
        private void Limpiar()
        {
            tbNombre.Text = string.Empty;
            tbApellido.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            cbSexo.Text = string.Empty;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitaControles(bool valor)
        {
            tbNombre.Enabled = valor;
            IDE.Enabled = valor;
            tbApellido.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbCorreo.Enabled = valor;
            cbSexo.Enabled = valor;
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
                

        public Registro_Expositor()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
            

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Expositor_Load(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; HabilitaControles(false); HabilitarBotones();
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

        private void Registro_Expositor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SendKeys.Send("{TAB}"); }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            modificar = false;
            Limpiar();
            HabilitaControles(false);
            HabilitarBotones();
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
                string commandString = "insert into Expositor(Nombre,Apellido,Sexo,Correo,Telefono)values(@Nombre,@Apellido,@Sexo,@Correo,@Telefono)";
                SqlCommand com = new SqlCommand(commandString, mi_conexion);
                com.Parameters.Add(new SqlParameter("@Nombre", tbNombre.Text));
                com.Parameters.Add(new SqlParameter("@Apellido", tbApellido.Text));
                com.Parameters.Add(new SqlParameter("@Sexo", cbSexo.Text));
                com.Parameters.Add(new SqlParameter("@Correo", tbCorreo.Text));
                com.Parameters.Add(new SqlParameter("@Telefono", tbTelefono.Text));

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
                        string commandString = "update Expositor set Nombre= @Nombre ,Apellido = @Apellido,Sexo= @Sexo,Correo= @Correo,Telefono= @Telefono where IdExpositor=@pid";

                        SqlCommand com = new SqlCommand(commandString, mi_conexion);
                        com.Parameters.Add(new SqlParameter("@pid", IDE.Text));
                        com.Parameters.Add(new SqlParameter("@Nombre", tbNombre.Text));
                        com.Parameters.Add(new SqlParameter("@Apellido", tbApellido.Text));
                        com.Parameters.Add(new SqlParameter("@Sexo", cbSexo.Text));
                        com.Parameters.Add(new SqlParameter("@Correo", tbCorreo.Text));
                        com.Parameters.Add(new SqlParameter("@Telefono", tbTelefono.Text));

                        com.ExecuteNonQuery();
                        mi_conexion.Close();
                    }
                    finally { }
                }

            MessageBox.Show("\n Guardado.... \n");
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            modificar = true;
            HabilitaControles(true);
            HabilitarBotones();
            tbNombre.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Expositor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            eidexpositor = 0;
            Buscar_Expositor fbcargo = new Buscar_Expositor();
            fbcargo.ShowDialog();
            if (modificar)
            {
                IDE.Text = Convert.ToString(eidexpositor);
                tbNombre.Text = eNombre;
                tbApellido.Text = eApellido;
                cbSexo.Text = esexo;
                tbTelefono.Text = eTelefono;
                tbCorreo.Text = ecorreo;
                BModificar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                eidexpositor = 0; eNombre = ""; eApellido = "";
                Limpiar();
                BBuscar.Focus();
            }
        }
    }
}
