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
    public partial class configuracoes : Form
    {

        #region construtores

        public configuracoes()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Load

        private void configuracoes_Load(object sender, EventArgs e)
        {
            cbRacaDom.SelectedIndex = config.dominancia;
        }

        #endregion

        #region Botão Salvar

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            config.dominancia = cbRacaDom.SelectedIndex;
        }

        #endregion

        #region Botão Cancelar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Quando muda o selecionado da comboBox

        private void cbRacaDom_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbRacaDom.SelectedIndex)
            {
                case 0:
                    pcbIndividuo.Image = Properties.Resources.coelho_branco;
                    break;
                case 1:
                    pcbIndividuo.Image = Properties.Resources.coelho_preto;
                    break;
            }

        }

        #endregion

    }
}
