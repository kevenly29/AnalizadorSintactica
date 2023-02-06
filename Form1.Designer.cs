namespace AnalizadorLexicoCompiladores
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLexico = new System.Windows.Forms.Button();
            this.TOKEN_LEXEMA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1_codigo = new System.Windows.Forms.TextBox();
            this.btnanalisisSintactico = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(664, 376);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 23);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar Tabla";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(370, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLexico
            // 
            this.btnLexico.BackColor = System.Drawing.Color.Black;
            this.btnLexico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLexico.Location = new System.Drawing.Point(423, 329);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(90, 23);
            this.btnLexico.TabIndex = 2;
            this.btnLexico.Text = "Analisis Lexico";
            this.btnLexico.UseVisualStyleBackColor = false;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // TOKEN_LEXEMA
            // 
            this.TOKEN_LEXEMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TOKEN_LEXEMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.TOKEN_LEXEMA.Location = new System.Drawing.Point(423, 31);
            this.TOKEN_LEXEMA.Name = "TOKEN_LEXEMA";
            this.TOKEN_LEXEMA.Size = new System.Drawing.Size(337, 292);
            this.TOKEN_LEXEMA.TabIndex = 3;
            this.TOKEN_LEXEMA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TOKEN_LEXEMA_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TOKEN";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LEXEMA";
            this.Column2.Name = "Column2";
            // 
            // textBox1_codigo
            // 
            this.textBox1_codigo.Location = new System.Drawing.Point(35, 31);
            this.textBox1_codigo.Multiline = true;
            this.textBox1_codigo.Name = "textBox1_codigo";
            this.textBox1_codigo.Size = new System.Drawing.Size(340, 292);
            this.textBox1_codigo.TabIndex = 4;
            // 
            // btnanalisisSintactico
            // 
            this.btnanalisisSintactico.BackColor = System.Drawing.Color.Black;
            this.btnanalisisSintactico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnanalisisSintactico.Location = new System.Drawing.Point(35, 329);
            this.btnanalisisSintactico.Name = "btnanalisisSintactico";
            this.btnanalisisSintactico.Size = new System.Drawing.Size(121, 23);
            this.btnanalisisSintactico.TabIndex = 5;
            this.btnanalisisSintactico.Text = "Analisis Sintactico";
            this.btnanalisisSintactico.UseVisualStyleBackColor = false;
            this.btnanalisisSintactico.Click += new System.EventHandler(this.btnanalisisSintactico_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 54);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnanalisisSintactico);
            this.Controls.Add(this.textBox1_codigo);
            this.Controls.Add(this.TOKEN_LEXEMA);
            this.Controls.Add(this.btnLexico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TOKEN_LEXEMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.DataGridView TOKEN_LEXEMA;
        private System.Windows.Forms.TextBox textBox1_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnanalisisSintactico;
        private System.Windows.Forms.TextBox textBox1;
    }
}

