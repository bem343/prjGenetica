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
    public partial class frmPrincipal : Form
    {

        #region Variáveis Globais

        private AutoCompleteStringCollection dadosLista = new AutoCompleteStringCollection();
        private List<individuo> individuos = new List<individuo>();
        public List<string> geracoes = new List<string>();

        public static int qtInd = 0;

        #endregion

        #region Construtores

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Load

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // configuracoes.MdiParent = this;
            ListarNomes.listarNomes();
            verificador.Start();
        }

        #endregion

        #region Métodos

            #region Novo Indivíduo(Default)

            private void NovoIndividuo(int tipo, int alelos)
            {
                //Atualiza a lista de geração Define a geração
                if (geracoes.Count == 0)
                {
                    geracoes.Add("P");
                    dadosLista.Add("P");
                    txtGeracao.AutoCompleteCustomSource = dadosLista;
                }

                //Instância um individuo novo e guarda-o
                individuo individuo = new individuo(tipo, alelos);
                individuo.MdiParent = this;
                individuo.Show();

                individuos.Add(individuo);
            }

            #endregion

            #region Novo Indivíduo (personalizado)

            private void NovoIndividuo(int tipo, int genero, int geracao, int alelos, string[] nomesPais, string[] Sangue)
            {
                //Atualiza a lista de gerações e define-a
                if (geracao == 0)
                {
                    if (geracoes.Count == 0)
                    {
                        geracoes.Add("P");
                        dadosLista.Add("P");
                        txtGeracao.AutoCompleteCustomSource = dadosLista;
                    }
                }
                else
                {
                    bool tem = false;
                    foreach(var item in geracoes)
                    {
                        if (item == "F" + geracao)
                        {
                            tem = true;
                            break;
                        }
                    }
                    if (!tem)
                    {
                        geracoes.Add("F" + geracao);
                        dadosLista.Add("F" + geracao);
                        txtGeracao.AutoCompleteCustomSource = dadosLista;
                    }
                }

                //instância um indivíduo novo e guarda-o
                individuo individuo = new individuo(tipo, genero, geracao, alelos, nomesPais, Sangue);
                individuo.MdiParent = this;
                individuo.Show();

                individuos.Add(individuo);
            }

            #endregion

        #endregion

        #region MenuStrip

            #region Cruzar

            public void cruzarIndividuoToolStripMenuItem_Click(object sender, EventArgs e)
                {

                    //contagem de clicados
                    int i = 0;
                    List<individuo> selecionados = new List<individuo>();
                    foreach(var individuo in individuos)
                    {
                        if (individuo.clicado)
                        {
                            selecionados.Add(individuo);
                            i++;
                        }
                        if (i > 2)
                        {
                            selecionados.Clear();
                            MessageBox.Show("Selecione apenas dois indivíduos!");
                            return;
                        }

                    }
                    // Verificação de existencia
                    if (qtInd == 0)
                    {
                        MessageBox.Show("Não há indivíduos para cruzar!");
                        return;
                    }
                    if (i == 0)
                    {
                        MessageBox.Show("Selecione os indivíduos que vão cruzar!");
                        return;
                    }
                    if (i == 1)
                    {
                        MessageBox.Show("Selecione o outro indivíduo para cruzar!");
                        return;
                    }

                    //Cruzamento
                    //Determina a geração
                    int geracaoP = selecionados[0].geracao;
                    int geracaoM = selecionados[1].geracao;
                    if (geracaoM != geracaoP)
                    {
                        geracaoP++;
                    }
                    geracaoP++;

                    //Define os alelos e a raça
                    string aleloA = "";
                    string aleloB = "";
                    string[] filhos = new string[4];
                    int cont = 0;

                    for (int p = 0; p < 2; p++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            aleloA = selecionados[0].alelos.Substring(p,1);
                            aleloB = selecionados[1].alelos.Substring(j, 1);
                            filhos[cont] = aleloA + aleloB;
                            cont++;
                        }
                    }

                    Random r = new Random();
                    string alelosFilho = filhos[r.Next(4)];
                    int alelosN = 0;
                    int raca = 0;
                
                    switch (alelosFilho)
                    {
                        case "VV":
                            alelosN = 0;
                            if (config.dominancia == 1) { raca = 1; };
                            break;
                        case "vv":
                            alelosN = 2;
                            if (config.dominancia != 1) { raca = 1; };
                            break;
                        case "Vv":
                            alelosN = 1;
                            if (config.dominancia == 1) { raca = 1; };
                            break;
                        case "vV":
                            alelosN = 1;
                            if (config.dominancia == 1) { raca = 1; };
                            break;
                    }

                    //Define o tipo sanguíneo
                    aleloA = "";
                    aleloB = "";
                    filhos = new string[4];
                    cont = 0;

                    for (int p = 0; p < 2; p++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            aleloA = selecionados[0].alelosSangue[p];
                            aleloB = selecionados[1].alelosSangue[j];
                            filhos[cont] = aleloA + aleloB;
                            cont++;
                        }
                    }
                    
                    string alelosSangueFilho = filhos[r.Next(4)];
                    string[] alelosSangue = new string[2];
                    switch (alelosSangueFilho)
                    {
                            //AB
                        case "IaIb":
                            alelosSangue[0] = "Ia";
                            alelosSangue[1] = "Ib";
                            break;
                        case "IbIa":
                            alelosSangue[0] = "Ia";
                            alelosSangue[1] = "Ib";
                            break;
                            //O
                        case "ii":
                            alelosSangue[0] = "i";
                            alelosSangue[1] = "i";
                            break;
                            //A
                        case "IaIa":
                            alelosSangue[0] = "Ia";
                            alelosSangue[1] = "Ia";                            
                            break;
                        case "Iai":
                            alelosSangue[0] = "Ia";
                            alelosSangue[1] = "i";
                            break;
                        case "iIa":
                            alelosSangue[0] = "Ia";
                            alelosSangue[1] = "i";
                            break;
                            //B
                        case "IbIb":
                            alelosSangue[0] = "Ib";
                            alelosSangue[1] = "Ib";
                            break;
                        case "Ibi":
                            alelosSangue[0] = "Ib";
                            alelosSangue[1] = "i";
                            break;
                        case "iIb":
                            alelosSangue[0] = "Ib";
                            alelosSangue[1] = "i";
                            break;
                    }

                    //Define o gênero
                    if (selecionados[0].genero == selecionados[1].genero)
                    {
                        MessageBox.Show("Cruze indivíduos de generos diferentes!");
                        return;
                    }
                    int genero = r.Next(2);
                    
                    //Atualiza os dados dos dois individuos e pega os nomes
                    string[] nomesPais = new string[2];
                    cont = 0;
                    foreach(var selecionado in selecionados)
                    {
                        nomesPais[cont] = selecionado.nome;
                        cont++;
                        selecionado.pais = true;
                        selecionado.pcbIndividuo_Click(sender, e);
                        selecionado.bloquearFatores();
                    }
                    NovoIndividuo(raca, genero, geracaoP, alelosN, nomesPais, alelosSangue);
                }

                #endregion

            #region Configurações

            private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                configuracoes configuracoes = new configuracoes();
                configuracoes.MdiParent = this;
                configuracoes.Show();
            }

            #endregion

            #region Eliminar todos os indivíduos

            private void todosOsIndivíduosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //contagem dos indivíduos vivos
                foreach (var individuo in individuos)
                {
                    if (!individuo.excluido)
                    {
                        individuo.Close();
                    }
                }
                //Deleta as gerações
                int indice = 0;
                for (int p = 0; p < dadosLista.Count; p++)
                {
                    geracoes.RemoveAt(indice);
                    dadosLista.RemoveAt(indice);
                }
                txtGeracao.AutoCompleteCustomSource = dadosLista;
                //Atualiza o fundo
                this.BackgroundImage = Properties.Resources.fundo;
            }

            #endregion

        #endregion

        #region ContextMenu

            //0 = coelhoMalhado & 1 = coelhoPreto
            //0 = masculino & 1 = feminino

            #region Criar coelho branco

            private void coelhoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (config.dominancia == 0)
	            {
		            NovoIndividuo(0, 0);
	            }
                else
	            {
                    NovoIndividuo(0, 2);
	            }
            }

            #endregion

            #region Criar coelho preto

            private void coelhoPretoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (config.dominancia == 1)
                {
                    NovoIndividuo(1, 0);
                }
                else
                {
                    NovoIndividuo(1, 2);
                }
            }

            #endregion

            #region Refresh

            private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.BackgroundImage = Properties.Resources.fundo;
            }

            #endregion

        #endregion

        #region Automático

            #region Excluir uma geração (Quando apertar Enter)

            private void txtGeracao_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode.ToString() == "Return")
                {
                    //Veficação de existência
                    if (txtGeracao.Text == "")
                    {
                        MessageBox.Show("Digite a geração que será excluída!");
                        return;
                    }

                    int i = 0;
                    //contagem dos indivíduos da geração em questão
                    foreach (var individuo in individuos)
                    {
                        if (individuo.geracaoExt == txtGeracao.Text)
                        {
                            i++;
                            individuo.Close();
                        }
                    }
                    //Verifica o número de excluídos
                    if (i == 0)
                    {
                        MessageBox.Show("Essa geração não existe!");
                        txtGeracao.Clear();
                        return;
                    }
                    try
                    {
                        int indice = 0;
                        for (int p = 0; p < geracoes.Count; p++)
                        {
                            if (geracoes[p] == txtGeracao.Text)
                            {
                                indice = p;
                            }
                        }
                        geracoes.RemoveAt(indice);

                        for (int p = 0; p < dadosLista.Count; p++)
                        {
                            if (dadosLista[p] == txtGeracao.Text)
                            {
                                indice = p;
                            }
                        }
                        dadosLista.RemoveAt(indice);
                        txtGeracao.AutoCompleteCustomSource = dadosLista;

                        txtGeracao.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Essa geração não existe!");
                        txtGeracao.Clear();
                        return;
                    }
                }
            }

            #endregion

            #region Auto atualiza o fundo ao redimensionar

            private void frmPrincipal_SizeChanged(object sender, EventArgs e)
            {
                this.BackgroundImage = Properties.Resources.fundo;
            }

            #endregion

            #region Auto Atualiza a quantidade de indivíduos

            private void verificador_Tick(object sender, EventArgs e)
            {
                lblQtInd.Text = qtInd.ToString();
                //Define a raça Dominante
                switch (config.dominancia)
                {
                    case 0:
                        lblDominante.Text = "Pelagem Branca";
                        break;
                    case 1:
                        lblDominante.Text = "Pelagem Preta";
                        break;
                }
            }

        #endregion

        #endregion

    }
}
