
namespace Proyectoooo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostoUnidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rbtCasual = new System.Windows.Forms.RadioButton();
            this.rdbFormal = new System.Windows.Forms.RadioButton();
            this.rbtDeportivo = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.LightGray;
            this.txtMarca.Location = new System.Drawing.Point(66, 16);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ShortcutsEnabled = false;
            this.txtMarca.Size = new System.Drawing.Size(117, 20);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de serie:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNSerie
            // 
            this.txtNSerie.BackColor = System.Drawing.Color.LightGray;
            this.txtNSerie.Location = new System.Drawing.Point(318, 16);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.ShortcutsEnabled = false;
            this.txtNSerie.Size = new System.Drawing.Size(114, 20);
            this.txtNSerie.TabIndex = 5;
            this.txtNSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidades:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.BackColor = System.Drawing.Color.LightGray;
            this.txtUnidades.Location = new System.Drawing.Point(84, 51);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(86, 20);
            this.txtUnidades.TabIndex = 7;
            this.txtUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidades_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo por Unidad:";
            // 
            // txtCostoUnidad
            // 
            this.txtCostoUnidad.BackColor = System.Drawing.Color.LightGray;
            this.txtCostoUnidad.Location = new System.Drawing.Point(319, 51);
            this.txtCostoUnidad.Name = "txtCostoUnidad";
            this.txtCostoUnidad.Size = new System.Drawing.Size(114, 20);
            this.txtCostoUnidad.TabIndex = 9;
            this.txtCostoUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Porcentaje a descontar: %";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.Color.LightGray;
            this.txtPorcentaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPorcentaje.Location = new System.Drawing.Point(179, 87);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(61, 20);
            this.txtPorcentaje.TabIndex = 11;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(474, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvProductos
            // 
            this.dtvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.dtvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvProductos.ColumnHeadersHeight = 38;
            this.dtvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column7});
            this.dtvProductos.EnableHeadersVisualStyles = false;
            this.dtvProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.dtvProductos.Location = new System.Drawing.Point(1, 186);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtvProductos.Size = new System.Drawing.Size(669, 217);
            this.dtvProductos.TabIndex = 13;
            this.dtvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.Name = "Column1";
            this.Column1.Width = 71;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N° de Serie";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unidades";
            this.Column5.Name = "Column5";
            this.Column5.Width = 87;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Costo p/u";
            this.Column4.Name = "Column4";
            this.Column4.Width = 83;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Calzado";
            this.Column3.Name = "Column3";
            this.Column3.Width = 81;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.Width = 61;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Descontado";
            this.Column7.Name = "Column7";
            this.Column7.Width = 126;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(474, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Borrar Fila";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtOtro);
            this.groupBox1.Controls.Add(this.rbtCasual);
            this.groupBox1.Controls.Add(this.rdbFormal);
            this.groupBox1.Controls.Add(this.rbtDeportivo);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 61);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Calzado";
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Checked = true;
            this.rbtOtro.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtOtro.Location = new System.Drawing.Point(369, 26);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(48, 18);
            this.rbtOtro.TabIndex = 3;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseMnemonic = false;
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // rbtCasual
            // 
            this.rbtCasual.AutoSize = true;
            this.rbtCasual.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbtCasual.Location = new System.Drawing.Point(254, 26);
            this.rbtCasual.Name = "rbtCasual";
            this.rbtCasual.Size = new System.Drawing.Size(109, 18);
            this.rbtCasual.TabIndex = 2;
            this.rbtCasual.Text = "Calzado Casual";
            this.rbtCasual.UseVisualStyleBackColor = true;
            // 
            // rdbFormal
            // 
            this.rdbFormal.AutoSize = true;
            this.rdbFormal.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdbFormal.Location = new System.Drawing.Point(130, 26);
            this.rdbFormal.Name = "rdbFormal";
            this.rdbFormal.Size = new System.Drawing.Size(110, 18);
            this.rdbFormal.TabIndex = 1;
            this.rdbFormal.Text = "Calzado Formal";
            this.rdbFormal.UseVisualStyleBackColor = true;
            // 
            // rbtDeportivo
            // 
            this.rbtDeportivo.AutoSize = true;
            this.rbtDeportivo.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDeportivo.Location = new System.Drawing.Point(6, 26);
            this.rbtDeportivo.Name = "rbtDeportivo";
            this.rbtDeportivo.Size = new System.Drawing.Size(124, 18);
            this.rbtDeportivo.TabIndex = 0;
            this.rbtDeportivo.Text = "Calzado Deportivo";
            this.rbtDeportivo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(673, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtvProductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCostoUnidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostoUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtvProductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFormal;
        private System.Windows.Forms.RadioButton rbtDeportivo;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtCasual;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

