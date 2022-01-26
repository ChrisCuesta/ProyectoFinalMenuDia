
namespace Presentacion
{
    partial class VentanaCreacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnBebida = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnSopa = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_entrada = new System.Windows.Forms.ComboBox();
            this.comboBox_bebida = new System.Windows.Forms.ComboBox();
            this.comboBox_segundo = new System.Windows.Forms.ComboBox();
            this.comboBox_sopa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxEntrada = new System.Windows.Forms.Label();
            this.textBoxBebida = new System.Windows.Forms.Label();
            this.textBoxSegundo = new System.Windows.Forms.Label();
            this.textBoxSopa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEntrada);
            this.groupBox1.Controls.Add(this.btnBebida);
            this.groupBox1.Controls.Add(this.btnSegundo);
            this.groupBox1.Controls.Add(this.btnSopa);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox_entrada);
            this.groupBox1.Controls.Add(this.comboBox_bebida);
            this.groupBox1.Controls.Add(this.comboBox_segundo);
            this.groupBox1.Controls.Add(this.comboBox_sopa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú del día";
            // 
            // textBoxId
            // 
            this.textBoxId.AutoSize = true;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Location = new System.Drawing.Point(97, 17);
            this.textBoxId.MaximumSize = new System.Drawing.Size(20, 20);
            this.textBoxId.MinimumSize = new System.Drawing.Size(30, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(30, 20);
            this.textBoxId.TabIndex = 41;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 265);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 266);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(372, 177);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(43, 23);
            this.btnEntrada.TabIndex = 12;
            this.btnEntrada.Text = "...";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnBebida
            // 
            this.btnBebida.Location = new System.Drawing.Point(372, 129);
            this.btnBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBebida.Name = "btnBebida";
            this.btnBebida.Size = new System.Drawing.Size(43, 25);
            this.btnBebida.TabIndex = 11;
            this.btnBebida.Text = "...";
            this.btnBebida.UseVisualStyleBackColor = true;
            this.btnBebida.Click += new System.EventHandler(this.btnBebida_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(372, 84);
            this.btnSegundo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(43, 23);
            this.btnSegundo.TabIndex = 10;
            this.btnSegundo.Text = "...";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnSopa
            // 
            this.btnSopa.Location = new System.Drawing.Point(372, 39);
            this.btnSopa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSopa.Name = "btnSopa";
            this.btnSopa.Size = new System.Drawing.Size(43, 25);
            this.btnSopa.TabIndex = 9;
            this.btnSopa.Text = "...";
            this.btnSopa.UseVisualStyleBackColor = true;
            this.btnSopa.Click += new System.EventHandler(this.btnSopa_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 226);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox_entrada
            // 
            this.comboBox_entrada.FormattingEnabled = true;
            this.comboBox_entrada.Location = new System.Drawing.Point(97, 177);
            this.comboBox_entrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_entrada.Name = "comboBox_entrada";
            this.comboBox_entrada.Size = new System.Drawing.Size(253, 24);
            this.comboBox_entrada.TabIndex = 7;
            // 
            // comboBox_bebida
            // 
            this.comboBox_bebida.FormattingEnabled = true;
            this.comboBox_bebida.Location = new System.Drawing.Point(97, 129);
            this.comboBox_bebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_bebida.Name = "comboBox_bebida";
            this.comboBox_bebida.Size = new System.Drawing.Size(253, 24);
            this.comboBox_bebida.TabIndex = 6;
            // 
            // comboBox_segundo
            // 
            this.comboBox_segundo.FormattingEnabled = true;
            this.comboBox_segundo.Location = new System.Drawing.Point(97, 84);
            this.comboBox_segundo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_segundo.Name = "comboBox_segundo";
            this.comboBox_segundo.Size = new System.Drawing.Size(253, 24);
            this.comboBox_segundo.TabIndex = 5;
            // 
            // comboBox_sopa
            // 
            this.comboBox_sopa.FormattingEnabled = true;
            this.comboBox_sopa.Location = new System.Drawing.Point(97, 39);
            this.comboBox_sopa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_sopa.Name = "comboBox_sopa";
            this.comboBox_sopa.Size = new System.Drawing.Size(253, 24);
            this.comboBox_sopa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bebida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sopa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(587, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista de Menú";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxEntrada);
            this.groupBox3.Controls.Add(this.textBoxBebida);
            this.groupBox3.Controls.Add(this.textBoxSegundo);
            this.groupBox3.Controls.Add(this.textBoxSopa);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1054, 199);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comidas";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.AutoSize = true;
            this.textBoxEntrada.Location = new System.Drawing.Point(8, 106);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(0, 17);
            this.textBoxEntrada.TabIndex = 3;
            // 
            // textBoxBebida
            // 
            this.textBoxBebida.AutoSize = true;
            this.textBoxBebida.Location = new System.Drawing.Point(8, 79);
            this.textBoxBebida.Name = "textBoxBebida";
            this.textBoxBebida.Size = new System.Drawing.Size(0, 17);
            this.textBoxBebida.TabIndex = 2;
            // 
            // textBoxSegundo
            // 
            this.textBoxSegundo.AutoSize = true;
            this.textBoxSegundo.Location = new System.Drawing.Point(8, 50);
            this.textBoxSegundo.Name = "textBoxSegundo";
            this.textBoxSegundo.Size = new System.Drawing.Size(0, 17);
            this.textBoxSegundo.TabIndex = 1;
            // 
            // textBoxSopa
            // 
            this.textBoxSopa.AutoSize = true;
            this.textBoxSopa.Location = new System.Drawing.Point(8, 21);
            this.textBoxSopa.Name = "textBoxSopa";
            this.textBoxSopa.Size = new System.Drawing.Size(0, 17);
            this.textBoxSopa.TabIndex = 0;
            // 
            // VentanaCreacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaCreacion";
            this.Text = "Creación de menú";
            this.Load += new System.EventHandler(this.VentanaCreacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnBebida;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnSopa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_entrada;
        private System.Windows.Forms.ComboBox comboBox_bebida;
        private System.Windows.Forms.ComboBox comboBox_segundo;
        private System.Windows.Forms.ComboBox comboBox_sopa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label textBoxId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label textBoxEntrada;
        private System.Windows.Forms.Label textBoxBebida;
        private System.Windows.Forms.Label textBoxSegundo;
        private System.Windows.Forms.Label textBoxSopa;
    }
}