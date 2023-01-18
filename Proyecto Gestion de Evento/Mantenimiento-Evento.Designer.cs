namespace Proyecto_Gestion_de_Evento
{
    partial class Mantenimiento_Evento
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
            this.dataGridEvento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEvento
            // 
            this.dataGridEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvento.Location = new System.Drawing.Point(3, 238);
            this.dataGridEvento.Name = "dataGridEvento";
            this.dataGridEvento.ReadOnly = true;
            this.dataGridEvento.Size = new System.Drawing.Size(850, 150);
            this.dataGridEvento.TabIndex = 0;
            // 
            // Mantenimiento_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 388);
            this.Controls.Add(this.dataGridEvento);
            this.Name = "Mantenimiento_Evento";
            this.Text = "Mantenimiento_Evento";
            this.Load += new System.EventHandler(this.Mantenimiento_Evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEvento;
    }
}