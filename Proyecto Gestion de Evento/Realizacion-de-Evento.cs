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
    public partial class Realizacion_de_Evento : Form
    {
        SIGEN_Conexion sql = new SIGEN_Conexion();
        
        public static bool modificar = true;
        public static int vidParticipante = 0, IdTenporal=0;
        public static string vNombre, vApellido, vCedula, vTelefono, vcorreo, vsexo;
        public static int eidexpositor = 0;
        public static string eNombre, eApellido, eTelefono, ecorreo, esexo;
        public static int vidEvento = 0, vPrecio = 0, vCupo = 0, vDuracion = 0;
        public static string vLugar, vHora, vFecha, vDescripcion, vEncargado, xNombre ;


        public static string miconexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";

        private void Limpiar()
        { 
        
            //de Evento
            tbIDEvento.Text = string.Empty;
            tbEvento.Text = string.Empty;
            tbCupo.Text = string.Empty;
            tbLugar.Text = string.Empty;
            EventoFecha.Value = System.DateTime.Now.Date;
    
            //de Expositor
            tbIDExpositor.Text = string.Empty;
            tbNombre.Text = string.Empty;
            tbApellido.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbCorreo.Text = string.Empty;
            //de Participante
            tbIDParticipante.Text = string.Empty;
            tbBuscarParticipante.Text = string.Empty;
            //variables
            //vidParticipante = 0;
            //vNombre = "";
            //selecciono = false;
            //Esto se hace para todas las variables que tengamos en el Form
        }

        private void MostrarMercancia()
   {
   SqlConnection mi_conexion = new SqlConnection(miconexion);
    try
  {
    SqlCommand miinstruccion = mi_conexion.CreateCommand();
    miinstruccion.CommandText = "Select IdParticipante, Nombre," + "Apellido As Participante From Participante Where IdParticipante=" + Convert.ToInt32(vidParticipante);
    mi_conexion.Open();
    //creamos el objeto datareader
    SqlDataReader midatareader = miinstruccion.ExecuteReader();
    //Leer la fila devuelta usando el obejto SqlDataReader
    midatareader.Read();

    //Pasar los valores a las variables
    //vParticipante = Convert.ToString(midatareader["Nombre"]);
    //vidParticipante = Convert.ToInt32(midatareader["IdParticipante"]);
    //Mostrar los valores de las columnas contenidas en el Objeto
    //SqlDataReader
    tbIDParticipante.Text = Convert.ToString(midatareader["IdParticipante"]);
    tbBuscarParticipante.Text = Convert.ToString(midatareader["Nombre"]);
    //Cerrar el Objeto SqlDataReader al terminar de usarlo
    MessageBox.Show("2");
    midatareader.Close();
    mi_conexion.Close();
    }
    catch
    {
    MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
    }
    }

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
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al realizar la operación solicitada! ");
            }

        }
        public Realizacion_de_Evento()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            //if (sql.Eliminar(textBox1.Text))
           //{
               // dataGridView1.DataSource = sql.MostrarDatos();
               // MessageBox.Show("Dato Eliminado");
            //}
            //else
           // {
             //   MessageBox.Show("No se a podido Eliminar datos");
            //}
            Close();
        }

        private void BBuscarParticipante_Click(object sender, EventArgs e)
        {
            vidParticipante = 0;
            
            Busqueda_Participante fbcargo = new Busqueda_Participante();
            fbcargo.ShowDialog();
            if (modificar)
            {
                
                tbIDParticipante.Text = Convert.ToString(vidParticipante);
                
                tbBuscarParticipante.Text = vNombre;
                
                //tbNombre.Text = vApellido;
                //string fecha1 = EventoFecha.Text;
                
                
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                vNombre = ""; vApellido = ""; vidParticipante = 0;
                

            }



            //vidParticipante = 0;
            //Busqueda_Participante fbmercancia = new Busqueda_Participante();
            //fbmercancia.ShowDialog();
            //if (selecciono)
            //{
              //  MostrarMercancia();
               // tbIDParticipante.Focus();
            //}
            //else
            //{
              //  MessageBox.Show("No eligio ningun participante!");
                //tbBuscarParticipante.Focus();
            //}
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tbNombre.Focus();
        }

        private void tbIDParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sólo se permiten números
    if (Char.IsDigit(e.KeyChar))
    {
    e.Handled = false;
    }
    else
    if (Char.IsPunctuation(e.KeyChar)) //permitir punto
    {
    e.Handled = false;
    }
    else
    if (Char.IsControl(e.KeyChar)) //permitir teclas de control
    {
        e.Handled = false;
    }
    else
    {
        //el resto de teclas pulsadas se desactivan
        e.Handled = true;
    }
        }

        private void tbIDEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIDEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sólo se permiten números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsPunctuation(e.KeyChar)) //permitir punto
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
        }

        private void tbIDExpositor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sólo se permiten números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsPunctuation(e.KeyChar)) //permitir punto
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
        }

        private void Realizacion_de_Evento_Load(object sender, EventArgs e)
        {
            //IdTenporal = 0;
            //MostrarDatos("Select IdEvento,IdParticipante,IdExpositor From  Evento,Participante,Expositor");
            MostrarDatos("Select * From  TableTenporal");
            //textBox1.Text = Convert.ToString(IdTenporal);

        }

        private void BBuscarExpositor_Click(object sender, EventArgs e)
        {
            eidexpositor = 0;
            Buscar_Expositor fbcargo = new Buscar_Expositor();
            fbcargo.ShowDialog();
            if (modificar)
            {
                tbIDExpositor.Text = Convert.ToString(eidexpositor);
                tbNombre.Text = eNombre;
                tbApellido.Text = eApellido;
                //cbSexo.Text = esexo;
                tbTelefono.Text = eTelefono;
                tbCorreo.Text = ecorreo;
                
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                eidexpositor = 0; eNombre = ""; eApellido = "";
                
                
            }
        }

        private void BBuscarEvento_Click(object sender, EventArgs e)
        {
            vidEvento = 0;
            Busqueda_Evento fbcargo = new Busqueda_Evento();
            fbcargo.ShowDialog();
            if (modificar)
            {
                tbIDEvento.Text = Convert.ToString(vidEvento);
                tbEvento.Text = xNombre;
                
                //tbHora.Text = vHora;
                //tbFecha.Text = vFecha;
                //tbDuracion.Text = Convert.ToString(vDuracion);
                //tbEncargado.Text = vEncargado;
                tbLugar.Text = vLugar;
                //tbDescripsion.Text = vDescripcion;
                tbCupo.Text = Convert.ToString(vCupo);
                //tbPrecio.Text = Convert.ToString(vPrecio);

                
            }
            else
            {
                MessageBox.Show("No eligió ningún cargo!");
                vNombre = ""; vEncargado = ""; vidEvento = 0;
                Limpiar();
                

            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            SqlConnection mi_conexion = new SqlConnection(connectionstring);
            mi_conexion.Open();
            string commandString = "insert into TableTenporal(NombreP,ApellidoP,SexoP,CorreoP,TelefonoP,Cedula,IdParticipante,IdExpositor,NombreE,ApellidoE,TelefonoE,CorreoE,SexoE,IdEvento,Nombre,Cupo,Lugar,Fecha,Precio,Descripcion,Encargado,Hora,Duracion)values(@NombreP,@ApellidoP,@SexoP,@CorreoP,@TelefonoP,@Cedula,@IdParticipante,@IdExpositor,@NombreE,@ApellidoE,@TelefonoE,@CorreoE,@SexoE,@IdEvento,@Nombre,@Cupo,@Lugar,@Fecha,@Precio,@Descripcion,@Encargado,@Hora,@Duracion)";
            //string commandString1 = "insert into TableTenporal(SexoE)values(@SexoE)";
            //SqlCommand com1 = new SqlCommand(commandString1, mi_conexion);
            SqlCommand com = new SqlCommand(commandString, mi_conexion);
            com.Parameters.Add(new SqlParameter("@NombreP", tbBuscarParticipante.Text));
            com.Parameters.Add(new SqlParameter("@ApellidoP", vApellido));
            com.Parameters.Add(new SqlParameter("@Cedula", vCedula));
            com.Parameters.Add(new SqlParameter("@TelefonoP", vTelefono));
            com.Parameters.Add(new SqlParameter("@CorreoP", vcorreo));
            com.Parameters.Add(new SqlParameter("@SexoP", vsexo));
            

            
            //eNombre, eApellido, eTelefono, ecorreo, esexo;
            com.Parameters.Add(new SqlParameter("@SexoE", esexo));

            com.Parameters.Add(new SqlParameter("@IdParticipante", tbIDParticipante.Text));
            com.Parameters.Add(new SqlParameter("@IdExpositor", tbIDExpositor.Text));
            com.Parameters.Add(new SqlParameter("@NombreE", tbNombre.Text));
            com.Parameters.Add(new SqlParameter("@ApellidoE", tbApellido.Text));
            com.Parameters.Add(new SqlParameter("@TelefonoE", tbTelefono.Text));
            com.Parameters.Add(new SqlParameter("@IdEvento", tbIDEvento.Text));
            com.Parameters.Add(new SqlParameter("@Nombre", tbEvento.Text));
            com.Parameters.Add(new SqlParameter("@Cupo", tbCupo.Text));
            com.Parameters.Add(new SqlParameter("@Lugar", tbLugar.Text));
            com.Parameters.Add(new SqlParameter("@CorreoE", tbCorreo.Text));
            com.Parameters.Add(new SqlParameter("@Fecha", EventoFecha.Text));

            com.Parameters.Add(new SqlParameter("@Precio", vPrecio));
            com.Parameters.Add(new SqlParameter("@Descripcion", vDescripcion));
            com.Parameters.Add(new SqlParameter("@Encargado", vEncargado));
            com.Parameters.Add(new SqlParameter("@Hora", vHora));
            
            com.Parameters.Add(new SqlParameter("@Duracion", vDuracion));
            
            

            //com.Parameters.Add(new SqlParameter("@Cedula", tbCedulap.Text));
            //com.Parameters.Add(new SqlParameter("@Sexo", cbSexop.Text));
            //com.Parameters.Add(new SqlParameter("@Correo", tbCorreop.Text));
            //com.Parameters.Add(new SqlParameter("@Telefono", tbTelefonop.Text));

            com.ExecuteNonQuery();
            mi_conexion.Close();
            MostrarDatos("Select * From  TableTenporal");

            //string connectionstring3 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            //SqlConnection mi_conexion3 = new SqlConnection(connectionstring3);
            //mi_conexion3.Open();
            //string commandString3 = "insert into EventoDetalles (ID_Evento,ID_Participante)values(@ID_Evento,@ID_Participante)";
            //SqlCommand com3 = new SqlCommand(commandString3, mi_conexion3);
            //com3.Parameters.Add(new SqlParameter("@ID_Evento", tbIDEvento.Text));
            //com3.Parameters.Add(new SqlParameter("@ID_Participante", tbIDParticipante.Text));


            //com3.ExecuteNonQuery();
            //mi_conexion3.Close();

            string connectionstring3 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            SqlConnection mi_conexion3 = new SqlConnection(connectionstring3);
            mi_conexion3.Open();
            string commandString3 = "insert into EventoDetalles2 (ID_Evento,ID_Participante,ID_Expositor)values(@ID_Evento,@ID_Participante,@ID_Expositor)";
            SqlCommand com3 = new SqlCommand(commandString3, mi_conexion3);
            com3.Parameters.Add(new SqlParameter("@ID_Evento", tbIDEvento.Text));
            com3.Parameters.Add(new SqlParameter("@ID_Participante", tbIDParticipante.Text));
            com3.Parameters.Add(new SqlParameter("@ID_Expositor", tbIDExpositor.Text));


            com3.ExecuteNonQuery();
            mi_conexion3.Close();

            MessageBox.Show("\n Agregado.... \n");
        }

        private void EventoFecha_ValueChanged(object sender, EventArgs e)
        {
            //DateTime fecha = EventoFecha.Value;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTenporal = 0;
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            Realizacion_de_Evento.IdTenporal = Convert.ToInt32(fila.Cells[0].Value);
            textBox1.Text = Convert.ToString(IdTenporal);
        }

        private void Realizacion_de_Evento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Selecione la cula de la tabla para eliinar");
                e.Cancel = true;
            }
            else
            {

                if (sql.Eliminar(textBox1.Text))
                {
                    dataGridView1.DataSource = sql.MostrarDatos();
                    //MessageBox.Show("Dato Eliminado");
                    if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("No se a podido Eliminar datos");
                }
            }

            }


            

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            SqlConnection mi_conexion = new SqlConnection(connectionstring);
            mi_conexion.Open();
            string commandString = "insert into Participante(Nombre,Apellido,Sexo,Correo,Telefono,Cedula)values(@Nombre,@Apellido,@Sexo,@Correo,@Telefono,@Cedula)";
            SqlCommand com = new SqlCommand(commandString, mi_conexion);
            com.Parameters.Add(new SqlParameter("@Nombre", tbBuscarParticipante.Text));
            com.Parameters.Add(new SqlParameter("@Apellido", vApellido));
            com.Parameters.Add(new SqlParameter("@Cedula", vCedula));
            com.Parameters.Add(new SqlParameter("@Sexo", vsexo));
            com.Parameters.Add(new SqlParameter("@Correo", vcorreo));
            com.Parameters.Add(new SqlParameter("@Telefono", vTelefono));

            com.ExecuteNonQuery();
            mi_conexion.Close();
            //Exposito

            string connectionstring1 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            SqlConnection mi_conexion1 = new SqlConnection(connectionstring1);
            mi_conexion1.Open();
            string commandString1 = "insert into Expositor(Nombre,Apellido,Sexo,Correo,Telefono)values(@Nombre,@Apellido,@Sexo,@Correo,@Telefono)";
            SqlCommand com1 = new SqlCommand(commandString1, mi_conexion1);
            com1.Parameters.Add(new SqlParameter("@Nombre", tbNombre.Text));
            com1.Parameters.Add(new SqlParameter("@Apellido", tbApellido.Text));
            com1.Parameters.Add(new SqlParameter("@Sexo", esexo));
            com1.Parameters.Add(new SqlParameter("@Correo", tbCorreo.Text));
            com1.Parameters.Add(new SqlParameter("@Telefono", tbTelefono.Text));

            com1.ExecuteNonQuery();
            mi_conexion1.Close();

            //Evento

            string connectionstring2 = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
            SqlConnection mi_conexion2 = new SqlConnection(connectionstring2);
            mi_conexion2.Open();
            string commandString2 = "insert into Evento(Nombre,Hora,Precio,Fecha,Descripcion,Encargado,Cupo,Duracion,Lugar)values(@Nombre,@Hora,@Precio,@Fecha,@Descripcion,@Encargado,@Cupo,@Duracion,@Lugar)";
            SqlCommand com2 = new SqlCommand(commandString2, mi_conexion2);
            com2.Parameters.Add(new SqlParameter("@Nombre", tbEvento.Text));
            com2.Parameters.Add(new SqlParameter("@Hora", vHora));
            com2.Parameters.Add(new SqlParameter("@Fecha", EventoFecha.Text));
            com2.Parameters.Add(new SqlParameter("@Duracion", vDuracion));
            com2.Parameters.Add(new SqlParameter("@Encargado", vEncargado));
            com2.Parameters.Add(new SqlParameter("@Cupo", tbCupo.Text));
            com2.Parameters.Add(new SqlParameter("@Precio", vPrecio));
            com2.Parameters.Add(new SqlParameter("@Descripcion", vDescripcion));
            com2.Parameters.Add(new SqlParameter("@Lugar", tbLugar.Text));

            com2.ExecuteNonQuery();
            mi_conexion2.Close();

            //evento detalles
            

            MessageBox.Show("\n Guardado.... \n");
        }
    }
}
