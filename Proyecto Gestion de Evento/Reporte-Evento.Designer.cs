namespace Proyecto_Gestion_de_Evento
{
    partial class Reporte_Evento
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEvento = new Proyecto_Gestion_de_Evento.DataSetEvento();
            this.EventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventoTableAdapter = new Proyecto_Gestion_de_Evento.DataSetEventoTableAdapters.EventoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EventoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Gestion_de_Evento.Reporte-Evento1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1031, 309);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetEvento
            // 
            this.DataSetEvento.DataSetName = "DataSetEvento";
            this.DataSetEvento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EventoBindingSource
            // 
            this.EventoBindingSource.DataMember = "Evento";
            this.EventoBindingSource.DataSource = this.DataSetEvento;
            // 
            // EventoTableAdapter
            // 
            this.EventoTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 309);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Evento";
            this.Text = "Reporte_Evento";
            this.Load += new System.EventHandler(this.Reporte_Evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EventoBindingSource;
        private DataSetEvento DataSetEvento;
        private DataSetEventoTableAdapters.EventoTableAdapter EventoTableAdapter;
    }
}