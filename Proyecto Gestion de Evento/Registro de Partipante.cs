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


    public partial class RegistrodePartipante : Form
    {


        public static bool nuevo = false;
        public static bool modificar = false;
        public static int vidParticipante= 0;
        public static string vNombre, vApellido,vCedula,vTelefono,vcorreo,vsexo;

        private void Limpiar()
        {
            tbNombrep.Text = string.Empty;
            IDP.Text = string.Empty;
            tbApellidop.Text = string.Empty;
            tbTelefonop.Text = string.Empty;
            tbCorreop.Text = string.Empty;
            cbSexop.Text = string.Empty;
            tbCedulap.Text = string.Empty;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitaControles(bool valor)
        {
            tbNombrep.Enabled = valor;
            IDP.Enabled = valor;
            tbApellidop.Enabled = valor;
            tbTelefonop.Enabled = valor;
            tbCorreop.Enabled = valor;
            cbSexop.Enabled = valor;
            tbCedulap.Enabled = valor;
            //Esto se hace para todos los controles que tengamos en el Form
        }

        private void HabilitarBotones()
        {
            if (nuevo || modificar)
            {
                HabilitaControles(true);
                ANuevo.Enabled = false;
                button2.Enabled = true;
                //AModificar.Enabled = false;
                bModicicar2.Enabled = false;
                ACancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                ANuevo.Enabled = true;
                button2.Enabled = false;
                //AModificar.Enabled = true;
                bModicicar2.Enabled = true;
                ACancelar.Enabled = false;
            }
        }


        public RegistrodePartipante()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (nuevo)
           { 
            try
            {

                string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
                SqlConnection mi_conexion = new SqlConnection(connectionstring);
                mi_conexion.Open();
                string commandString = "insert into Participante(Nombre,Apellido,Sexo,Correo,Telefono,Cedula)values(@Nombre,@Apellido,@Sexo,@Correo,@Telefono,@Cedula)";
                SqlCommand com = new SqlCommand(commandString, mi_conexion);
                com.Parameters.Add(new SqlParameter("@Nombre", tbNombrep.Text));
                com.Parameters.Add(new SqlParameter("@Apellido", tbApellidop.Text));
                com.Parameters.Add(new SqlParameter("@Cedula", tbCedulap.Text));
                com.Parameters.Add(new SqlParameter("@Sexo", cbSexop.Text));
                com.Parameters.Add(new SqlParameter("@Correo", tbCorreop.Text));
                com.Parameters.Add(new SqlParameter("@Telefono", tbTelefonop.Text));
                
                com.ExecuteNonQuery();
                mi_conexion.Close();
                Limpiar();

            }
            finally {}
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
                        com.Parameters.Add(new SqlParameter("@Nombre", tbNombrep.Text));
                        com.Parameters.Add(new SqlParameter("@Apellido", tbApellidop.Text));
                        com.Parameters.Add(new SqlParameter("@Cedula", tbCedulap.Text));
                        com.Parameters.Add(new SqlParameter("@Sexo", cbSexop.Text));
                        com.Parameters.Add(new SqlParameter("@Correo", tbCorreop.Text));
                        com.Parameters.Add(new SqlParameter("@Telefono", tbTelefonop.Text));

                        com.ExecuteNonQuery();
                        mi_conexion.Close();
                    }
                    finally { }
                }



            MessageBox.Show("\n Guardado.... \n");

            }

        private void ASalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistrodePartipante_Load(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; HabilitaControles(false); HabilitarBotones();
        }

        private void RegistrodePartipante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SendKeys.Send("{TAB}"); }
        }

        private void ANuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            modificar = false;
            Limpiar();
            HabilitaControles(true);
            HabilitarBotones();
            tbNombrep.Focus();
        }

        private void ACancelar_Click(object sender, EventArgs e)
        {
            nuevo = false; modificar = false; Limpiar(); HabilitaControles(false); HabilitarBotones();
        }

        private void AModificar_Click(object sender, EventArgs e)
        {
            vidParticipante = 0;
            Busqueda_Participante fbcargo = new  Busqueda_Participante();
            fbcargo.ShowDialog();
            if (modificar)
            {
                IDP.Text = Convert.ToString(vidParticipante);
                tbNombrep.Text = vNombre;
                tbApellidop.Text = vApellido;
                tbCedulap.Text = vCedula;
                cbSexop.Text = vsexo;
                tbCorreop.Text = vcorreo;
                tbTelefonop.Text = vTelefono;
                bModicicar2_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                vNombre = ""; vApellido = ""; vidParticipante = 0;
                Limpiar();
                AModificar.Focus();
            
          }

            
        }

        private void tbNombrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidop_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSexop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbCorreop_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefonop_TextChanged(object sender, EventArgs e)
        {

        }

        private void bModicicar2_Click(object sender, EventArgs e)
        {
            nuevo = false;
            modificar = true;
            HabilitaControles(true);
            HabilitarBotones();
            tbNombrep.Focus();
        }

        private void RegistrodePartipante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }
    }
}
