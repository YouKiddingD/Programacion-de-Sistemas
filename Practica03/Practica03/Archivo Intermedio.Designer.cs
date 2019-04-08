namespace Practica03
{
    partial class Archivo_Intermedio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETIQUETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTRUCCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERANDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODOBJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CP,
            this.ETIQUETA,
            this.INSTRUCCION,
            this.OPERANDO,
            this.CODOBJ});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // ETIQUETA
            // 
            this.ETIQUETA.HeaderText = "ETIQUETA";
            this.ETIQUETA.Name = "ETIQUETA";
            this.ETIQUETA.ReadOnly = true;
            // 
            // INSTRUCCION
            // 
            this.INSTRUCCION.HeaderText = "INSTRUCCION";
            this.INSTRUCCION.Name = "INSTRUCCION";
            this.INSTRUCCION.ReadOnly = true;
            // 
            // OPERANDO
            // 
            this.OPERANDO.HeaderText = "OPERANDO";
            this.OPERANDO.Name = "OPERANDO";
            this.OPERANDO.ReadOnly = true;
            // 
            // CODOBJ
            // 
            this.CODOBJ.HeaderText = "CODIGO OBJETO";
            this.CODOBJ.Name = "CODOBJ";
            this.CODOBJ.ReadOnly = true;
            // 
            // Archivo_Intermedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 301);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 340);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Archivo_Intermedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Archivo_Intermedio";
            this.Load += new System.EventHandler(this.Archivo_Intermedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETIQUETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTRUCCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERANDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODOBJ;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}