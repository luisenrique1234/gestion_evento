using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestion_de_Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir de la Aplicación!\n Seguro que desea hacerlo?", "Mensaje de SIGEN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) e.Cancel = false; else e.Cancel = true;
        }

        private void resgistroParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroExpositorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void resgistroParticipanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrodePartipante fmant_cargo = new RegistrodePartipante(); fmant_cargo.ShowDialog();
        }

        private void registroExpositorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro_Expositor fmant_cargo = new Registro_Expositor(); fmant_cargo.ShowDialog();
        }

        private void infrormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa es realizado en Visual Studio 2013 para la entrega de Programacion II, Creadores Cesar Abreu Molina, Luis Enrique Gomez. Para mas informacion por favor contactarnos via nuestra web\n", "Mensaje de SIGEN");
        }

        private void caculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\ONENOTE.EXE");
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Luis Enrique\Desktop\Nueva carpeta\descarga (1).html");
            
        }

        private void worldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\root\Office16\WINWORD.EXE");
        }

        private void uCATECIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Luis Enrique\Desktop\Nueva carpeta\UCATECI.html");
        }

        private void mantenimientoParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Participante fmant_cargo = new Mantenimiento_Participante(); fmant_cargo.ShowDialog();
        }

        private void descripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Realizacion_de_Evento fmant_cargo = new Realizacion_de_Evento(); fmant_cargo.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void consultaParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Participante fmant_cargo = new Consulta_Participante(); fmant_cargo.ShowDialog();
        }

        private void consultaExpositorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Expositor fmant_cargo = new Consulta_Expositor(); fmant_cargo.ShowDialog();
        }

        private void consultaEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Evento fmant_cargo = new Consulta_Evento(); fmant_cargo.ShowDialog();
        }

        private void mantenimientoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descripsion_de_Envto fmant_cargo = new Descripsion_de_Envto(); fmant_cargo.ShowDialog();
        }

        private void detallesDelEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Realizacion_Evento fmant_cargo = new Consulta_Realizacion_Evento(); fmant_cargo.ShowDialog();
        }
    }
}
