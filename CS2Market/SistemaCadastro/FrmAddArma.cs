using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddArma : Form
    {
        public FrmAddArma()
        {
            InitializeComponent();
        }

        private void FrmAddArma_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Sistema sistema = new Sistema();
            this.Hide();
            sistema.ShowDialog();
            this.Close();
        }
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereArma(txtnome.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Arma adicionada com sucesso!");
            txtnome.Clear();
            txtnome.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArma_Click(object sender, EventArgs e)
        {
            FrmRemoveArma formRemArma = new FrmRemoveArma();
            this.Hide();
            formRemArma.ShowDialog();
        }
    }
}
