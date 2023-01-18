namespace Proyecto_Gestion_de_Evento
{
    partial class Mantenimiento_Expocitor
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
            this.dataGridEX = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEX)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEX
            // 
            this.dataGridEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEX.Location = new System.Drawing.Point(3, 249);
            this.dataGridEX.Name = "dataGridEX";
            this.dataGridEX.ReadOnly = true;
            this.dataGridEX.Size = new System.Drawing.Size(654, 157);
            this.dataGridEX.TabIndex = 0;
            this.dataGridEX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEX_CellContentClick);
            // 
            // Mantenimiento_Expocitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 411);
            this.Controls.Add(this.dataGridEX);
            this.Name = "Mantenimiento_Expocitor";
            this.Text = "Mantenimiento_Expocitor";
            this.Load += new System.EventHandler(this.Mantenimiento_Expocitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEX;
    }
}