namespace prjGenetica
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuStripFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.cruzarIndividuoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIndivíduoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coelhoMalhadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.coelhoPretoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cruzarIndivíduosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsIndivíduosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGeracao = new System.Windows.Forms.ToolStripTextBox();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFormPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.criarIndivíduoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coelhoPretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cruzarIndividuosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtInd = new System.Windows.Forms.Label();
            this.lblDominante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verificador = new System.Windows.Forms.Timer(this.components);
            this.MenuStripFrmPrincipal.SuspendLayout();
            this.contextMenuFormPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripFrmPrincipal
            // 
            this.MenuStripFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cruzarIndividuoToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.MenuStripFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripFrmPrincipal.Name = "MenuStripFrmPrincipal";
            this.MenuStripFrmPrincipal.Size = new System.Drawing.Size(722, 24);
            this.MenuStripFrmPrincipal.TabIndex = 1;
            this.MenuStripFrmPrincipal.Text = "menuStrip1";
            // 
            // cruzarIndividuoToolStripMenuItem
            // 
            this.cruzarIndividuoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarIndivíduoToolStripMenuItem1,
            this.cruzarIndivíduosToolStripMenuItem,
            this.cmExcluir});
            this.cruzarIndividuoToolStripMenuItem.Name = "cruzarIndividuoToolStripMenuItem";
            this.cruzarIndividuoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cruzarIndividuoToolStripMenuItem.Text = "Ações";
            // 
            // criarIndivíduoToolStripMenuItem1
            // 
            this.criarIndivíduoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coelhoMalhadoToolStripMenuItem1,
            this.coelhoPretoToolStripMenuItem2});
            this.criarIndivíduoToolStripMenuItem1.Image = global::prjGenetica.Properties.Resources.bunny;
            this.criarIndivíduoToolStripMenuItem1.Name = "criarIndivíduoToolStripMenuItem1";
            this.criarIndivíduoToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.criarIndivíduoToolStripMenuItem1.Text = "Criar Indivíduo";
            // 
            // coelhoMalhadoToolStripMenuItem1
            // 
            this.coelhoMalhadoToolStripMenuItem1.Image = global::prjGenetica.Properties.Resources.branco;
            this.coelhoMalhadoToolStripMenuItem1.Name = "coelhoMalhadoToolStripMenuItem1";
            this.coelhoMalhadoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.coelhoMalhadoToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.coelhoMalhadoToolStripMenuItem1.Text = "Coelho Branco";
            this.coelhoMalhadoToolStripMenuItem1.Click += new System.EventHandler(this.coelhoToolStripMenuItem_Click);
            // 
            // coelhoPretoToolStripMenuItem2
            // 
            this.coelhoPretoToolStripMenuItem2.Image = global::prjGenetica.Properties.Resources.preto;
            this.coelhoPretoToolStripMenuItem2.Name = "coelhoPretoToolStripMenuItem2";
            this.coelhoPretoToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.coelhoPretoToolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.coelhoPretoToolStripMenuItem2.Text = "Coelho Preto";
            this.coelhoPretoToolStripMenuItem2.Click += new System.EventHandler(this.coelhoPretoToolStripMenuItem_Click);
            // 
            // cruzarIndivíduosToolStripMenuItem
            // 
            this.cruzarIndivíduosToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.cruz2;
            this.cruzarIndivíduosToolStripMenuItem.Name = "cruzarIndivíduosToolStripMenuItem";
            this.cruzarIndivíduosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cruzarIndivíduosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cruzarIndivíduosToolStripMenuItem.Text = "Cruzar Indivíduos";
            this.cruzarIndivíduosToolStripMenuItem.Click += new System.EventHandler(this.cruzarIndividuoToolStripMenuItem_Click);
            // 
            // cmExcluir
            // 
            this.cmExcluir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsIndivíduosToolStripMenuItem,
            this.geraçãoToolStripMenuItem});
            this.cmExcluir.Image = global::prjGenetica.Properties.Resources.exit;
            this.cmExcluir.Name = "cmExcluir";
            this.cmExcluir.Size = new System.Drawing.Size(208, 22);
            this.cmExcluir.Text = "Excluir";
            // 
            // todosOsIndivíduosToolStripMenuItem
            // 
            this.todosOsIndivíduosToolStripMenuItem.Name = "todosOsIndivíduosToolStripMenuItem";
            this.todosOsIndivíduosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.todosOsIndivíduosToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.todosOsIndivíduosToolStripMenuItem.Text = "Todos os Indivíduos";
            this.todosOsIndivíduosToolStripMenuItem.Click += new System.EventHandler(this.todosOsIndivíduosToolStripMenuItem_Click);
            // 
            // geraçãoToolStripMenuItem
            // 
            this.geraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtGeracao});
            this.geraçãoToolStripMenuItem.Name = "geraçãoToolStripMenuItem";
            this.geraçãoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.geraçãoToolStripMenuItem.Text = "Geração";
            // 
            // txtGeracao
            // 
            this.txtGeracao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGeracao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGeracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeracao.Name = "txtGeracao";
            this.txtGeracao.Size = new System.Drawing.Size(152, 23);
            this.txtGeracao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGeracao_KeyDown);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.config;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // contextMenuFormPrincipal
            // 
            this.contextMenuFormPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarIndivíduoToolStripMenuItem,
            this.cruzarIndividuosToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuFormPrincipal.Name = "contextMenuFormPrincipal";
            this.contextMenuFormPrincipal.Size = new System.Drawing.Size(167, 70);
            // 
            // criarIndivíduoToolStripMenuItem
            // 
            this.criarIndivíduoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coelhoToolStripMenuItem,
            this.coelhoPretoToolStripMenuItem});
            this.criarIndivíduoToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.bunny;
            this.criarIndivíduoToolStripMenuItem.Name = "criarIndivíduoToolStripMenuItem";
            this.criarIndivíduoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.criarIndivíduoToolStripMenuItem.Text = "Criar Indivíduo";
            // 
            // coelhoToolStripMenuItem
            // 
            this.coelhoToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.branco;
            this.coelhoToolStripMenuItem.Name = "coelhoToolStripMenuItem";
            this.coelhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coelhoToolStripMenuItem.Text = "Coelho Branco";
            this.coelhoToolStripMenuItem.Click += new System.EventHandler(this.coelhoToolStripMenuItem_Click);
            // 
            // coelhoPretoToolStripMenuItem
            // 
            this.coelhoPretoToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.preto;
            this.coelhoPretoToolStripMenuItem.Name = "coelhoPretoToolStripMenuItem";
            this.coelhoPretoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coelhoPretoToolStripMenuItem.Text = "Coelho Preto";
            this.coelhoPretoToolStripMenuItem.Click += new System.EventHandler(this.coelhoPretoToolStripMenuItem_Click);
            // 
            // cruzarIndividuosToolStripMenuItem
            // 
            this.cruzarIndividuosToolStripMenuItem.Image = global::prjGenetica.Properties.Resources.cruz2;
            this.cruzarIndividuosToolStripMenuItem.Name = "cruzarIndividuosToolStripMenuItem";
            this.cruzarIndividuosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cruzarIndividuosToolStripMenuItem.Text = "Cruzar Indivíduos";
            this.cruzarIndividuosToolStripMenuItem.Click += new System.EventHandler(this.cruzarIndividuoToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Individuos:";
            // 
            // lblQtInd
            // 
            this.lblQtInd.AutoSize = true;
            this.lblQtInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtInd.Location = new System.Drawing.Point(95, 54);
            this.lblQtInd.Name = "lblQtInd";
            this.lblQtInd.Size = new System.Drawing.Size(16, 18);
            this.lblQtInd.TabIndex = 4;
            this.lblQtInd.Text = "0";
            // 
            // lblDominante
            // 
            this.lblDominante.AutoSize = true;
            this.lblDominante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominante.Location = new System.Drawing.Point(102, 32);
            this.lblDominante.Name = "lblDominante";
            this.lblDominante.Size = new System.Drawing.Size(117, 18);
            this.lblDominante.TabIndex = 6;
            this.lblDominante.Text = "Pelagem Branca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dominante:";
            // 
            // verificador
            // 
            this.verificador.Interval = 10;
            this.verificador.Tick += new System.EventHandler(this.verificador_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjGenetica.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 537);
            this.ContextMenuStrip = this.contextMenuFormPrincipal;
            this.Controls.Add(this.lblDominante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQtInd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStripFrmPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripFrmPrincipal;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de genética";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.frmPrincipal_SizeChanged);
            this.MenuStripFrmPrincipal.ResumeLayout(false);
            this.MenuStripFrmPrincipal.PerformLayout();
            this.contextMenuFormPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripFrmPrincipal;
        private System.Windows.Forms.ContextMenuStrip contextMenuFormPrincipal;
        private System.Windows.Forms.ToolStripMenuItem criarIndivíduoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coelhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coelhoPretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cruzarIndividuoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cruzarIndividuosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtInd;
        private System.Windows.Forms.Label lblDominante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem criarIndivíduoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coelhoMalhadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem coelhoPretoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cruzarIndivíduosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmExcluir;
        private System.Windows.Forms.ToolStripMenuItem todosOsIndivíduosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtGeracao;
        private System.Windows.Forms.Timer verificador;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}

