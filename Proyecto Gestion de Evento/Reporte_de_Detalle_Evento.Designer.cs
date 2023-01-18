namespace Proyecto_Gestion_de_Evento
{
    partial class Reporte_de_Detalle_Evento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1DetallesEvento = new Proyecto_Gestion_de_Evento.DataSet1DetallesEvento();
            this.EventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventoTableAdapter = new Proyecto_Gestion_de_Evento.DataSet1DetallesEventoTableAdapters.EventoTableAdapter();
            this.ExpositorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExpositorTableAdapter = new Proyecto_Gestion_de_Evento.DataSet1DetallesEventoTableAdapters.ExpositorTableAdapter();
            this.ParticipanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ParticipanteTableAdapter = new Proyecto_Gestion_de_Evento.DataSet1DetallesEventoTableAdapters.ParticipanteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DetallesEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpositorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EventoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ExpositorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ParticipanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Gestion_de_Evento.Report1DetalleEvento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(533, 279);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1DetallesEvento
            // 
            this.DataSet1DetallesEvento.DataSetName = "DataSet1DetallesEvento";
            this.DataSet1DetallesEvento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EventoBindingSource
            // 
            this.EventoBindingSource.DataMember = "Evento";
            this.EventoBindingSource.DataSource = this.DataSet1DetallesEvento;
            // 
            // EventoTableAdapter
            // 
            this.EventoTableAdapter.ClearBeforeFill = true;
            // 
            // ExpositorBindingSource
            // 
            this.ExpositorBindingSource.DataMember = "Expositor";
            this.ExpositorBindingSource.DataSource = this.DataSet1DetallesEvento;
            // 
            // ExpositorTableAdapter
            // 
            this.ExpositorTableAdapter.ClearBeforeFill = true;
            // 
            // ParticipanteBindingSource
            // 
            this.ParticipanteBindingSource.DataMember = "Participante";
            this.ParticipanteBindingSource.DataSource = this.DataSet1DetallesEvento;
            // 
            // ParticipanteTableAdapter
            // 
            this.ParticipanteTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_de_Detalle_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 279);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_de_Detalle_Evento";
            this.Text = "Reporte_de_Detalle_Evento";
            this.Load += new System.EventHandler(this.Reporte_de_Detalle_Evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DetallesEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpositorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EventoBindingSource;
        private DataSet1DetallesEvento DataSet1DetallesEvento;
        private System.Windows.Forms.BindingSource ExpositorBindingSource;
        private System.Windows.Forms.BindingSource ParticipanteBindingSource;
        private DataSet1DetallesEventoTableAdapters.EventoTableAdapter EventoTableAdapter;
        private DataSet1DetallesEventoTableAdapters.ExpositorTableAdapter ExpositorTableAdapter;
        private DataSet1DetallesEventoTableAdapters.ParticipanteTableAdapter ParticipanteTableAdapter;
    }
}