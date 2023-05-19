namespace Ejemplo1_Clases
{
    partial class ListaCentros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.centroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmCentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmCentroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaCentrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCentroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCentroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCentrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(90, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Centro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(392, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // centroBindingSource
            // 
            this.centroBindingSource.DataSource = typeof(Ejemplo1_Clases.Centro);
            // 
            // frmCentroBindingSource
            // 
            this.frmCentroBindingSource.DataSource = typeof(Ejemplo1_Clases.FrmCentro);
            // 
            // frmCentroBindingSource1
            // 
            this.frmCentroBindingSource1.DataSource = typeof(Ejemplo1_Clases.FrmCentro);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.dirDataGridViewTextBoxColumn,
            this.telfDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.centroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 219);
            this.dataGridView1.TabIndex = 2;
            // 
            // listaCentrosBindingSource
            // 
            this.listaCentrosBindingSource.DataSource = typeof(Ejemplo1_Clases.ListaCentros);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // dirDataGridViewTextBoxColumn
            // 
            this.dirDataGridViewTextBoxColumn.DataPropertyName = "Dir";
            this.dirDataGridViewTextBoxColumn.HeaderText = "Dir";
            this.dirDataGridViewTextBoxColumn.Name = "dirDataGridViewTextBoxColumn";
            // 
            // telfDataGridViewTextBoxColumn
            // 
            this.telfDataGridViewTextBoxColumn.DataPropertyName = "Telf";
            this.telfDataGridViewTextBoxColumn.HeaderText = "Telf";
            this.telfDataGridViewTextBoxColumn.Name = "telfDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ListaCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaCentros";
            this.Text = "ListaCentros";
            this.Load += new System.EventHandler(this.ListaCentros_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCentroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCentroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCentrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource centroBindingSource;
        private System.Windows.Forms.BindingSource frmCentroBindingSource;
        private System.Windows.Forms.BindingSource frmCentroBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaCentrosBindingSource;
    }
}