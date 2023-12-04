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
    public partial class FrmRemoveArma : Form
    {
        public FrmRemoveArma()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgArmas.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("nome like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveArma_Click(object sender, EventArgs e)
        {
            int linha = dgArmas.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgArmas.Rows[linha].Cells["idskin"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Arma", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaArma(id);
                if (retorno == true)
                {
                    MessageBox.Show("Arma excluida com sucesso!");
                    listaGridArmas();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }
        void listaGridArmas()
        {
            ConectaBanco con = new ConectaBanco();
            dgArmas.DataSource = con.listaArma();
            dgArmas.Columns["idarma"].Visible = false;
        }

        private void FrmRemoveArma_Load(object sender, EventArgs e)
        {
            listaGridArmas();
        }

        private void btnRemoveSkin_Click(object sender, EventArgs e)
        {
            int linha = dgArmas.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgArmas.Rows[linha].Cells["idarma"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Arma", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaArma(id);
                if (retorno == true)
                {
                    MessageBox.Show("Arma excluida com sucesso!");
                    listaGridArmas();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FrmAddArma formAddArma = new FrmAddArma();
            this.Hide();
            formAddArma.ShowDialog();
            this.Close();

        }
        
    }
}
