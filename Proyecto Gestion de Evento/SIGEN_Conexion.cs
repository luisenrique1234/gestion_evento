using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.SqlClient;
using System.Data;


namespace Proyecto_Gestion_de_Evento
{
    class SIGEN_Conexion
    {

        //@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True"
        public static string miconexion = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\algorimos\Programacion II\Proyecto Gestion de Evento\Proyecto Gestion de Evento\Database1.mdf;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection(miconexion);
        private DataSet ds;

       
        public DataTable MostrarDatos ()
    {
        conexion.Open();
        SqlCommand cmd = new SqlCommand("select * from Participante", conexion);
        SqlDataAdapter ad = new SqlDataAdapter(cmd);
        ds =new DataSet();
        ad.Fill(ds,"Tablas");
        conexion.Close();
        return ds.Tables["Tablas"];

    }

        public DataTable MostrarDatos2()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Expositor", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public DataTable MostrarDatos3()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Evento", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public DataTable Buscar(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Participante where Nombre like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public DataTable Buscar2(string nombre)
        { 
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Participante where Apellido like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public DataTable Buscar3(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Participante where Cedula like '%{0}%'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public DataTable Buscar4(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Participante where IdParticipante like '{0}'", nombre), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];

        }

        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("DELETE from TableTenporal  where IdTenporal = {0}", id), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0)
            { return true; }
            else { return false; }

        }

        //public bool Atualizar(string nombre, string apellido, string cedula)
        //{
            //conexion.Open();
            //SqlCommand cmd = new SqlCommand(string.Format("update Participante set Nombre = (0),Apellido = (1) where Cedula= (2)", new string[] (nombre, apellido, cedula )), conexion);
            //int filasafectadas = cmd.ExecuteNonQuery();
            //conexion.Close();
            //if (filasafectadas > 0) return true;
            //else return false;

        //}
    }
}
