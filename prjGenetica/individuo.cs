using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjGenetica.classes;

namespace prjGenetica
{
    public partial class individuo : Form
    {

        #region Variáveis globais

        public bool excluido = false;
        public bool pais = false;
        public bool clicado = false;

        public string[] nomesPais = null;
        public string nome = "";
        public string geracaoExt = "";
        public string raca = "";
        public string alelos = "";
        public string sangue = "";
        public string[] alelosSangue = null;
        public string rh = "";
        public int tipo = 0;
        public int genero = 0;
        public int geracao = 0;
        public int alelosN = 0;

        #endregion

        #region Construtores

        public individuo(int tipo, int alelosN)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.alelosN = alelosN;

            #region Determina o sangue
                Random r = new Random();
                int numero = r.Next(4);
                alelosSangue = new string[2];
                switch (numero)
                {
                    case 0:
                        //A
                        sangue = "A";
                        alelosSangue[0] = "Ia";
                        alelosSangue[1] = "Ia";
                        break;
                    case 1:
                        //B
                        sangue = "B";
                        alelosSangue[0] = "Ib";
                        alelosSangue[1] = "Ib";
                        break;
                    case 2:
                        //AB
                        sangue = "AB";
                        alelosSangue[0] = "Ia";
                        alelosSangue[1] = "Ib";
                        break;
                    case 3:
                        //O
                        sangue = "O";
                        alelosSangue[0] = "i";
                        alelosSangue[1] = "i";
                        break;
                }
            #endregion

        }
        public individuo(int tipo, int genero, int geracao, int alelosN, string[] nomesPais, string[] alelosSangue)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.genero = genero;
            this.geracao = geracao;
            this.alelosN = alelosN;
            this.nomesPais = nomesPais;
            this.alelosSangue = alelosSangue;

            bloquearFatores();

        }

        #endregion

        #region Page Load

        private void individuo_Load(object sender, EventArgs e)
        {
            // Adiciona um a quantidade de indivíduos
            frmPrincipal.qtInd++;
            // Pega um nome aleatório
            Random r = new Random();
            int n = 0;
            int cont = 0;
            do
            {
                cont++;
                if (cont > ListarNomes.nomes.Length / 2)
                {
                    ListarNomes.resetarNomes();
                }
                n = r.Next(ListarNomes.nomes.Length / 2);
            } while (ListarNomes.nomes[n, 1] == "1");
            nome = ListarNomes.nomes[n, 0];
            lblNome.Text = nome;
            ListarNomes.nomes[n, 1] = "1";
            // Coloca aquela Janela no cursor do mouse
            this.Location = Control.MousePosition;
            gerarCaracteristicas();
        }

        #endregion

        #region Métodos

            #region Gerar Características

            private void gerarCaracteristicas()
            {
                //Define a imagem
                switch (tipo)
                {
                    case 0:
                        pcbIndividuo.Image = Properties.Resources.coelho_branco;
                        raca = "Coelho Branco";
                        break;
                    case 1:
                        pcbIndividuo.Image = Properties.Resources.coelho_preto;
                        raca = "Coelho Preto";
                        break;
                }
                this.Text = raca;
                //Define o gênero
                if (!clicado)
                {
                    switch (genero)
                    {
                        case 0:
                            this.BackColor = Color.DodgerBlue;
                            this.Icon = Properties.Resources.masculino.ToIcon();
                            rbMasc.Checked = true;
                            break;
                        case 1:
                            this.BackColor = Color.DeepPink;
                            this.Icon = Properties.Resources.feminino.ToIcon();
                            rbFem.Checked = true;
                            break;
                    }
                }
                else
                {
                    switch (genero)
                    {
                        case 0:
                            this.Icon = Properties.Resources.masculino.ToIcon();
                            rbMasc.Checked = true;
                            break;
                        case 1:
                            this.Icon = Properties.Resources.feminino.ToIcon();
                            rbFem.Checked = true;
                            break;
                    }
                }

                //Define os alelos
                switch (alelosN)
                {
                    case 0:
                        lblAlelos.Font = new Font(lblAlelos.Font, FontStyle.Bold);
                        alelos = "VV";
                        rh = "+";
                        break;
                    case 1:
                        lblAlelos.Font = new Font(lblAlelos.Font, FontStyle.Bold);
                        alelos = "Vv";
                        rh = "+";
                        break;
                    case 2:
                        alelos = "vv";
                        rh = "-";
                        break;
                }
                lblAlelos.Text = alelos;

                //Tipo Sanguíneo
                switch (alelosSangue[0] + alelosSangue[1])
                {
                    //AB
                    case "IaIb":
                        sangue = "AB";
                        rbA1.Enabled = true;
                        rbB2.Enabled = true;
                        rbA1.Checked = true;
                        rbB2.Checked = true;
                        break;
                    case "IbIa":
                        sangue = "AB";
                        rbA1.Enabled = true;
                        rbB2.Enabled = true;
                        rbA1.Checked = true;
                        rbB2.Checked = true;
                        break;
                    //O
                    case "ii":
                        sangue = "O";
                        rbi1.Enabled = true;
                        rbi2.Enabled = true;
                        rbi1.Checked = true;
                        rbi2.Checked = true;
                        break;
                    //A
                    case "IaIa":
                        sangue = "A";
                        rbA1.Enabled = true;
                        rbA2.Enabled = true;
                        rbA1.Checked = true;
                        rbA2.Checked = true;
                        break;
                    case "Iai":
                        sangue = "A";
                        rbA1.Enabled = true;
                        rbi2.Enabled = true;
                        rbA1.Checked = true;
                        rbi2.Checked = true;
                        break;
                    case "iIa":
                        sangue = "A";
                        rbA1.Enabled = true;
                        rbi2.Enabled = true;
                        rbA1.Checked = true;
                        rbi2.Checked = true;
                        break;
                    //B
                    case "IbIb":
                        sangue = "B";
                        rbB1.Enabled = true;
                        rbB2.Enabled = true;
                        rbA2.Enabled = true;
                        rbB1.Checked = true;
                        rbB2.Checked = true;
                        break;
                    case "Ibi":
                        sangue = "B";
                        rbB1.Enabled = true;
                        rbi2.Enabled = true;
                        rbA2.Enabled = true;
                        rbB1.Checked = true;
                        rbi2.Checked = true;
                        break;
                    case "iIb":
                        sangue = "B";
                        rbB1.Enabled = true;
                        rbi2.Enabled = true;
                        rbA2.Enabled = true;
                        rbB1.Checked = true;
                        rbi2.Checked = true;
                        break;
                }
                //Sangue na label
                lblSangue.Text = sangue + rh;

                //Define a geração
                if (geracao == 0)
                {
                    geracaoExt = "P";
                    lblGeracao.Text = "Geração P";
                }
                else
                {
                    geracaoExt = "F" + geracao;
                    lblGeracao.Text = "Geração F" + geracao;
                }

                //Define o nome dos pais
                if (nomesPais != null)
                {
                    lblPai.Text = nomesPais[0];
                    lblMae.Text = nomesPais[1];
                }
                else
                {
                    lblPai.Text = "-";
                    lblMae.Text = "-";
                }
            }

            #endregion

            #region Definir Genero

            private void definirGenero()
            {
                //Define o gênero
                switch (genero)
                {
                    case 0:
                        this.BackColor = Color.DodgerBlue;
                        this.Icon = Properties.Resources.masculino.ToIcon();
                        rbMasc.Checked = true;
                        break;
                    case 1:
                        this.BackColor = Color.DeepPink;
                        this.Icon = Properties.Resources.feminino.ToIcon();
                        rbFem.Checked = true;
                        break;
                }
            }

            #endregion

            #region Bloquear Fatores

            public void bloquearFatores()
            {
                if (!rbA1.Checked)
                {
                    rbA1.Enabled = false;
                }
                if (!rbB1.Checked)
                {
                    rbB1.Enabled = false;
                }
                if (!rbi1.Checked)
                {
                    rbi1.Enabled = false;
                }
                if (!rbA2.Checked)
                {
                    rbA2.Enabled = false;
                }
                if (!rbB2.Checked)
                {
                    rbB2.Enabled = false;
                }
                if (!rbi2.Checked)
                {
                    rbi2.Enabled = false;
                }
            }

            #endregion

        #endregion

        #region Itens do ContextMenu

            #region Excluir

            private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            #endregion

            #region Editar

            private void editarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                System.Drawing.Size size = new System.Drawing.Size();
                size.Height = 529;
                size.Width = this.Size.Width;
                this.Size = size;
            }

            #endregion

        #endregion

        #region Selecionar um individuo

        public void pcbIndividuo_Click(object sender, EventArgs e)
        {

            if (clicado == false)
            {
                clicado = true;
                this.BackColor = Color.Lime;
            }
            else
            {
                clicado = false;
                definirGenero();
            }

        }

        #endregion

        #region Fechar

        public void individuo_FormClosed(object sender, FormClosedEventArgs e)
        {
            excluido = true;
            clicado = false;
            frmPrincipal.qtInd--;
        }

        #endregion

        #region Botão Salvar (Editar)

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (rbMasc.Checked)
            {
                genero = 0;
            }
            else
            {
                genero = 1;
            }

            #region Fatores

            if (rbA1.Checked)
            {
                alelosSangue[0] = "Ia";
            }
            if (rbB1.Checked)
            {
                alelosSangue[0] = "Ib";
            }
            if (rbi1.Checked)
            {
                alelosSangue[0] = "i";
            }
            if (rbA2.Checked)
            {
                alelosSangue[1] = "Ia";
            }
            if (rbB2.Checked)
            {
                alelosSangue[1] = "Ib";
            }
            if (rbi2.Checked)
            {
                alelosSangue[1] = "i";
            }

            #endregion

            //Gera as caracteristicas
            gerarCaracteristicas();
            //Retorna o Size normal
            System.Drawing.Size size = new System.Drawing.Size();
            size.Height = 285;
            size.Width = this.Size.Width;
            this.Size = size;
        }

        #endregion

        #region CheckedButtons

            private void rbB1_CheckedChanged(object sender, EventArgs e)
            {
                if (rbA2.Enabled)
                {
                    rbA2.Enabled = false;
                    rbB2.Checked = true;
                }
                else
                {
                    rbA2.Enabled = true;
                }
            }

            private void rbi1_CheckedChanged(object sender, EventArgs e)
            {
                if (rbA2.Enabled)
                {
                    rbA2.Enabled = false;
                    rbi2.Checked = true;
                }
                else
                {
                    rbA2.Enabled = true;
                }
                if (rbB2.Enabled)
                {
                    rbA2.Enabled = false;
                    rbB2.Enabled = false;
                    rbi2.Checked = true;
                }
                else
                {
                    rbA2.Enabled = true;
                    rbB2.Enabled = true;
                }
            }

        #endregion

    }
}
