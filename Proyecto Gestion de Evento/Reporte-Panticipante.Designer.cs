namespace Proyecto_Gestion_de_Evento
{
    partial class Reporte_Panticipante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ParticipanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1Participante = new Proyecto_Gestion_de_Evento.DataSet1Participante();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ParticipanteTableAdapter = new Proyecto_Gestion_de_Evento.DataSet1ParticipanteTableAdapters.ParticipanteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1Participante)).BeginInit();
            this.SuspendLayout();
            // 
            // ParticipanteBindingSource
            // 
            this.ParticipanteBindingSource.DataMember = "Participante";
            this.ParticipanteBindingSource.DataSource = this.DataSet1Participante;
            // 
            // DataSet1Participante
            // 
            this.DataSet1Participante.DataSetName = "DataSet1Participante";
            this.DataSet1Participante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ParticipanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Gestion_de_Evento.ReportParticipante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // ParticipanteTableAdapter
            // 
            this.ParticipanteTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Panticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 387);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Panticipante";
            this.Text = "Reporte_Panticipante";
            this.Load += new System.EventHandler(this.Reporte_Panticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParticipanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1Participante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ParticipanteBindingSource;
        private DataSet1Participante DataSet1Participante;
        private DataSet1ParticipanteTableAdapters.ParticipanteTableAdapter ParticipanteTableAdapter;
    }
}