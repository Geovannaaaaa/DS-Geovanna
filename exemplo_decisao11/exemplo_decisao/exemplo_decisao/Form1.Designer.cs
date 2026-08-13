namespace exemplo_decisao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_ds = new System.Windows.Forms.RadioButton();
            this.rdb_adm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_noite = new System.Windows.Forms.CheckBox();
            this.chk_tarde = new System.Windows.Forms.CheckBox();
            this.chk_manha = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_resultadoCurso = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_resultadoPeriodo = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.rdb_ds);
            this.groupBox1.Controls.Add(this.rdb_adm);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_ds
            // 
            this.rdb_ds.AutoSize = true;
            this.rdb_ds.BackColor = System.Drawing.Color.MediumVioletRed;
            this.rdb_ds.Location = new System.Drawing.Point(19, 92);
            this.rdb_ds.Name = "rdb_ds";
            this.rdb_ds.Size = new System.Drawing.Size(247, 24);
            this.rdb_ds.TabIndex = 1;
            this.rdb_ds.Text = "Desenvolvimento de Sistemas";
            this.rdb_ds.UseVisualStyleBackColor = false;
            this.rdb_ds.CheckedChanged += new System.EventHandler(this.rdb_ds_CheckedChanged);
            // 
            // rdb_adm
            // 
            this.rdb_adm.AutoSize = true;
            this.rdb_adm.BackColor = System.Drawing.Color.MediumVioletRed;
            this.rdb_adm.Location = new System.Drawing.Point(19, 39);
            this.rdb_adm.Name = "rdb_adm";
            this.rdb_adm.Size = new System.Drawing.Size(135, 24);
            this.rdb_adm.TabIndex = 0;
            this.rdb_adm.Text = "Administração";
            this.rdb_adm.UseVisualStyleBackColor = false;
            this.rdb_adm.CheckedChanged += new System.EventHandler(this.rdb_adm_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox2.Controls.Add(this.chk_noite);
            this.groupBox2.Controls.Add(this.chk_tarde);
            this.groupBox2.Controls.Add(this.chk_manha);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(36, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // chk_noite
            // 
            this.chk_noite.AutoSize = true;
            this.chk_noite.BackColor = System.Drawing.Color.MediumVioletRed;
            this.chk_noite.Location = new System.Drawing.Point(7, 118);
            this.chk_noite.Name = "chk_noite";
            this.chk_noite.Size = new System.Drawing.Size(72, 24);
            this.chk_noite.TabIndex = 2;
            this.chk_noite.Text = "Noite";
            this.chk_noite.UseVisualStyleBackColor = false;
            // 
            // chk_tarde
            // 
            this.chk_tarde.AutoSize = true;
            this.chk_tarde.BackColor = System.Drawing.Color.MediumVioletRed;
            this.chk_tarde.Location = new System.Drawing.Point(7, 80);
            this.chk_tarde.Name = "chk_tarde";
            this.chk_tarde.Size = new System.Drawing.Size(76, 24);
            this.chk_tarde.TabIndex = 1;
            this.chk_tarde.Text = "Tarde";
            this.chk_tarde.UseVisualStyleBackColor = false;
            // 
            // chk_manha
            // 
            this.chk_manha.AutoSize = true;
            this.chk_manha.BackColor = System.Drawing.Color.MediumVioletRed;
            this.chk_manha.Location = new System.Drawing.Point(7, 39);
            this.chk_manha.Name = "chk_manha";
            this.chk_manha.Size = new System.Drawing.Size(84, 24);
            this.chk_manha.TabIndex = 0;
            this.chk_manha.Text = "Manhã";
            this.chk_manha.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox3.Controls.Add(this.lbl_resultadoCurso);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(366, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // lbl_resultadoCurso
            // 
            this.lbl_resultadoCurso.AutoSize = true;
            this.lbl_resultadoCurso.BackColor = System.Drawing.Color.Pink;
            this.lbl_resultadoCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_resultadoCurso.Location = new System.Drawing.Point(6, 53);
            this.lbl_resultadoCurso.Name = "lbl_resultadoCurso";
            this.lbl_resultadoCurso.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultadoCurso.TabIndex = 0;
            this.lbl_resultadoCurso.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox4.Controls.Add(this.lbl_resultadoPeriodo);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(366, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado Período";
            // 
            // lbl_resultadoPeriodo
            // 
            this.lbl_resultadoPeriodo.AutoSize = true;
            this.lbl_resultadoPeriodo.BackColor = System.Drawing.Color.Pink;
            this.lbl_resultadoPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lbl_resultadoPeriodo.Location = new System.Drawing.Point(6, 55);
            this.lbl_resultadoPeriodo.Name = "lbl_resultadoPeriodo";
            this.lbl_resultadoPeriodo.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultadoPeriodo.TabIndex = 0;
            this.lbl_resultadoPeriodo.Text = "label2";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_mostrar.ForeColor = System.Drawing.Color.White;
            this.btn_mostrar.Location = new System.Drawing.Point(622, 239);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(121, 42);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::exemplo_decisao.Properties.Resources.Meeeeeee__3;
            this.pictureBox1.Location = new System.Drawing.Point(613, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.RadioButton rdb_ds;
        private System.Windows.Forms.RadioButton rdb_adm;
        private System.Windows.Forms.CheckBox chk_noite;
        private System.Windows.Forms.CheckBox chk_tarde;
        private System.Windows.Forms.CheckBox chk_manha;
        private System.Windows.Forms.Label lbl_resultadoCurso;
        private System.Windows.Forms.Label lbl_resultadoPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

