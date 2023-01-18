namespace Proyecto_Gestion_de_Evento
{
    partial class Reporte_Expositor
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
            this.DataSetExpositor = new Proyecto_Gestion_de_Evento.DataSetExpositor();
            this.ExpositorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExpositorTableAdapter = new Proyecto_Gestion_de_Evento.DataSetExpositorTableAdapters.ExpositorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetExpositor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpositorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ExpositorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Gestion_de_Evento.Reporte-Expositor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(505, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetExpositor
            // 
            this.DataSetExpositor.DataSetName = "DataSetExpositor";
            this.DataSetExpositor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpositorBindingSource
            // 
            this.ExpositorBindingSource.DataMember = "Expositor";
            this.ExpositorBindingSource.DataSource = this.DataSetExpositor;
            // 
            // ExpositorTableAdapter
            // 
            this.ExpositorTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Expositor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Expositor";
            this.Text = "Reporte_Expositor";
            this.Load += new System.EventHandler(this.Reporte_Expositor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetExpositor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpositorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ExpositorBindingSource;
        private DataSetExpositor DataSetExpositor;
        private DataSetExpositorTableAdapters.ExpositorTableAdapter ExpositorTableAdapter;
    }
}