namespace prjGenetica
{
    partial class individuo
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
            this.contextMenuIndividuo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGeracao = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAlelos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbPais = new System.Windows.Forms.GroupBox();
            this.lblMae = new System.Windows.Forms.Label();
            this.lblPai = new System.Windows.Forms.Label();
            this.lblSangue = new System.Windows.Forms.Label();
            this.gbFator1 = new System.Windows.Forms.GroupBox();
            this.rbi1 = new System.Windows.Forms.RadioButton();
            this.rbB1 = new System.Windows.Forms.RadioButton();
            this.rbA1 = new System.Windows.Forms.RadioButton();
            this.gbFator2 = new System.Windows.Forms.GroupBox();
            this.rbi2 = new System.Windows.Forms.RadioButton();
            this.rbB2 = new System.Windows.Forms.RadioButton();
            this.rbA2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbIndividuo = new System.Windows.Forms.PictureBox();
            this.contextMenuIndividuo.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.gbPais.SuspendLayout();
            this.gbFator1.SuspendLayout();
            this.gbFator2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndividuo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuIndividuo
            // 
            this.contextMenuIndividuo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuIndividuo.Name = "contextMenuIndividuo";
            this.contextMenuIndividuo.Size = new System.Drawing.Size(110, 48);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.exit;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.lapis;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // lblGeracao
            // 
            this.lblGeracao.AutoSize = true;
            this.lblGeracao.BackColor = System.Drawing.Color.Transparent;
            this.lblGeracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeracao.ImageKey = "(none)";
            this.lblGeracao.Location = new System.Drawing.Point(6, 162);
            this.lblGeracao.Name = "lblGeracao";
            this.lblGeracao.Size = new System.Drawing.Size(71, 20);
            this.lblGeracao.TabIndex = 1;
            this.lblGeracao.Text = "Geração";
            this.lblGeracao.Click += new System.EventHandler(this.pcbIndividuo_Click);
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbFem);
            this.gbGenero.Controls.Add(this.rbMasc);
            this.gbGenero.Location = new System.Drawing.Point(6, 259);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(200, 53);
            this.gbGenero.TabIndex = 2;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "GÊNERO";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFem.Location = new System.Drawing.Point(109, 19);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(81, 20);
            this.rbFem.TabIndex = 1;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasc.Location = new System.Drawing.Point(11, 19);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(87, 20);
            this.rbMasc.TabIndex = 0;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 460);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(188, 33);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAlelos
            // 
            this.lblAlelos.AutoSize = true;
            this.lblAlelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlelos.Location = new System.Drawing.Point(175, 163);
            this.lblAlelos.Name = "lblAlelos";
            this.lblAlelos.Size = new System.Drawing.Size(31, 20);
            this.lblAlelos.TabIndex = 4;
            this.lblAlelos.Text = "VV";
            this.lblAlelos.Click += new System.EventHandler(this.pcbIndividuo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 4);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(77, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Teddy";
            this.lblNome.Click += new System.EventHandler(this.pcbIndividuo_Click);
            // 
            // gbPais
            // 
            this.gbPais.Controls.Add(this.lblMae);
            this.gbPais.Controls.Add(this.lblPai);
            this.gbPais.Location = new System.Drawing.Point(6, 191);
            this.gbPais.Name = "gbPais";
            this.gbPais.Size = new System.Drawing.Size(200, 63);
            this.gbPais.TabIndex = 3;
            this.gbPais.TabStop = false;
            this.gbPais.Text = "PAIS";
            // 
            // lblMae
            // 
            this.lblMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMae.Location = new System.Drawing.Point(8, 36);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(186, 20);
            this.lblMae.TabIndex = 1;
            this.lblMae.Text = "Mãe";
            this.lblMae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPai
            // 
            this.lblPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPai.Location = new System.Drawing.Point(8, 15);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(186, 20);
            this.lblPai.TabIndex = 0;
            this.lblPai.Text = "Pai";
            this.lblPai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSangue
            // 
            this.lblSangue.AutoSize = true;
            this.lblSangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangue.Location = new System.Drawing.Point(130, 163);
            this.lblSangue.Name = "lblSangue";
            this.lblSangue.Size = new System.Drawing.Size(40, 20);
            this.lblSangue.TabIndex = 6;
            this.lblSangue.Text = "AB+";
            this.lblSangue.Click += new System.EventHandler(this.pcbIndividuo_Click);
            // 
            // gbFator1
            // 
            this.gbFator1.Controls.Add(this.rbi1);
            this.gbFator1.Controls.Add(this.rbB1);
            this.gbFator1.Controls.Add(this.rbA1);
            this.gbFator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFator1.Location = new System.Drawing.Point(27, 19);
            this.gbFator1.Name = "gbFator1";
            this.gbFator1.Size = new System.Drawing.Size(71, 109);
            this.gbFator1.TabIndex = 5;
            this.gbFator1.TabStop = false;
            this.gbFator1.Text = "FATOR1";
            // 
            // rbi1
            // 
            this.rbi1.AutoSize = true;
            this.rbi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbi1.Location = new System.Drawing.Point(9, 71);
            this.rbi1.Name = "rbi1";
            this.rbi1.Size = new System.Drawing.Size(30, 24);
            this.rbi1.TabIndex = 6;
            this.rbi1.Text = "i";
            this.rbi1.UseVisualStyleBackColor = true;
            this.rbi1.CheckedChanged += new System.EventHandler(this.rbi1_CheckedChanged);
            // 
            // rbB1
            // 
            this.rbB1.AutoSize = true;
            this.rbB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB1.Location = new System.Drawing.Point(9, 45);
            this.rbB1.Name = "rbB1";
            this.rbB1.Size = new System.Drawing.Size(41, 24);
            this.rbB1.TabIndex = 5;
            this.rbB1.Text = "Ib";
            this.rbB1.UseVisualStyleBackColor = true;
            this.rbB1.CheckedChanged += new System.EventHandler(this.rbB1_CheckedChanged);
            // 
            // rbA1
            // 
            this.rbA1.AutoSize = true;
            this.rbA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA1.Location = new System.Drawing.Point(9, 19);
            this.rbA1.Name = "rbA1";
            this.rbA1.Size = new System.Drawing.Size(41, 24);
            this.rbA1.TabIndex = 4;
            this.rbA1.Text = "Ia";
            this.rbA1.UseVisualStyleBackColor = true;
            // 
            // gbFator2
            // 
            this.gbFator2.Controls.Add(this.rbi2);
            this.gbFator2.Controls.Add(this.rbB2);
            this.gbFator2.Controls.Add(this.rbA2);
            this.gbFator2.Location = new System.Drawing.Point(104, 19);
            this.gbFator2.Name = "gbFator2";
            this.gbFator2.Size = new System.Drawing.Size(71, 109);
            this.gbFator2.TabIndex = 7;
            this.gbFator2.TabStop = false;
            this.gbFator2.Text = "FATOR2";
            // 
            // rbi2
            // 
            this.rbi2.AutoSize = true;
            this.rbi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbi2.Location = new System.Drawing.Point(19, 71);
            this.rbi2.Name = "rbi2";
            this.rbi2.Size = new System.Drawing.Size(30, 24);
            this.rbi2.TabIndex = 6;
            this.rbi2.Text = "i";
            this.rbi2.UseVisualStyleBackColor = true;
            // 
            // rbB2
            // 
            this.rbB2.AutoSize = true;
            this.rbB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB2.Location = new System.Drawing.Point(19, 45);
            this.rbB2.Name = "rbB2";
            this.rbB2.Size = new System.Drawing.Size(41, 24);
            this.rbB2.TabIndex = 5;
            this.rbB2.Text = "Ib";
            this.rbB2.UseVisualStyleBackColor = true;
            // 
            // rbA2
            // 
            this.rbA2.AutoSize = true;
            this.rbA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA2.Location = new System.Drawing.Point(19, 19);
            this.rbA2.Name = "rbA2";
            this.rbA2.Size = new System.Drawing.Size(41, 24);
            this.rbA2.TabIndex = 4;
            this.rbA2.Text = "Ia";
            this.rbA2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbFator1);
            this.groupBox1.Controls.Add(this.gbFator2);
            this.groupBox1.Location = new System.Drawing.Point(6, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO SANGUÍNEO";
            // 
            // pcbIndividuo
            // 
            this.pcbIndividuo.Image = global::prjGenetica.Properties.Resources.coelho_branco;
            this.pcbIndividuo.Location = new System.Drawing.Point(-1, 0);
            this.pcbIndividuo.Name = "pcbIndividuo";
            this.pcbIndividuo.Size = new System.Drawing.Size(214, 188);
            this.pcbIndividuo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIndividuo.TabIndex = 0;
            this.pcbIndividuo.TabStop = false;
            this.pcbIndividuo.Click += new System.EventHandler(this.pcbIndividuo_Click);
            // 
            // individuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(212, 258);
            this.ContextMenuStrip = this.contextMenuIndividuo;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSangue);
            this.Controls.Add(this.gbPais);
            this.Controls.Add(this.lblGeracao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblAlelos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.pcbIndividuo);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "individuo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "individuo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.individuo_FormClosed);
            this.Load += new System.EventHandler(this.individuo_Load);
            this.contextMenuIndividuo.ResumeLayout(false);
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbPais.ResumeLayout(false);
            this.gbFator1.ResumeLayout(false);
            this.gbFator1.PerformLayout();
            this.gbFator2.ResumeLayout(false);
            this.gbFator2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndividuo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuIndividuo;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbIndividuo;
        private System.Windows.Forms.Label lblGeracao;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAlelos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbPais;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.Label lblSangue;
        private System.Windows.Forms.GroupBox gbFator1;
        private System.Windows.Forms.RadioButton rbi1;
        private System.Windows.Forms.RadioButton rbB1;
        private System.Windows.Forms.RadioButton rbA1;
        private System.Windows.Forms.GroupBox gbFator2;
        private System.Windows.Forms.RadioButton rbi2;
        private System.Windows.Forms.RadioButton rbB2;
        private System.Windows.Forms.RadioButton rbA2;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}