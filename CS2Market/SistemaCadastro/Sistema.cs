using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;
        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBArma();
            listaCBRaridade();
            listaGridSkins();
            cbArma.Text = "";
            cbRaridade.Text = "";
        }

        void listaGridSkins()
        {
            ConectaBanco con = new ConectaBanco();
            dgSkins.DataSource = con.listaSkins();
            dgSkins.Columns["idskin"].Visible = false;
        }

        public void listaCBArma()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaArma();
            cbArma.DataSource = tabelaDados;
            cbArma.DisplayMember = "arma";
            cbArma.ValueMember = "idarma";

            cbAlteraArma.DataSource = tabelaDados;
            cbAlteraArma.DisplayMember = "arma";
            cbAlteraArma.ValueMember = "idarma";
        }

        public void listaCBRaridade()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaRaridade();
            cbRaridade.DataSource = tabelaDados;
            cbRaridade.DisplayMember = "raridade";
            cbRaridade.ValueMember = "idrar";

            cbAlteraRaridade.DataSource = tabelaDados;
            cbAlteraRaridade.DisplayMember = "raridade";
            cbAlteraRaridade.ValueMember = "idrar";
        }
      




        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgSkins.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("nome like '{0}%'", txtBusca.Text);
        }

        private void btnRemoveSkin_Click(object sender, EventArgs e)
        {
            int linha = dgSkins.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgSkins.Rows[linha].Cells["idskin"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Skin", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaSkins(id);
                if (retorno == true)
                {
                    MessageBox.Show("Skin excluida com sucesso!");
                    listaGridSkins();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            listaCBArma();
            listaCBRaridade();
        
            int linha = dgSkins.CurrentRow.Index;// pega a linha selecionada
            idAlterar = Convert.ToInt32(
                dgSkins.Rows[linha].Cells["idskin"].Value.ToString());
            txtAlteraNome.Text =
                 dgSkins.Rows[linha].Cells["nome"].Value.ToString();
            cbAlteraArma.Text =
                dgSkins.Rows[linha].Cells["arma"].Value.ToString();
            cbAlteraRaridade.Text =
                dgSkins.Rows[linha].Cells["raridade"].Value.ToString();
            txtAlteraPreco.Text =
                dgSkins.Rows[linha].Cells["preco"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;// muda aba
        }

        // Botão confirma alteração
        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Skins novaSkins = new Skins();
            novaSkins.Nome = txtAlteraNome.Text;
            novaSkins.Arma = Convert.ToInt32(cbAlteraArma.SelectedValue.ToString());
            novaSkins.Raridade = Convert.ToInt32(cbAlteraRaridade.SelectedValue.ToString());
            novaSkins.Preco = float.Parse(txtAlteraPreco.Text);
            bool retorno = con.alteraSkin(novaSkins, idAlterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso!");

            listaGridSkins();


        }


        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }

        void limpaCampos()
        {
            txtnome.Clear();
            cbArma.Text = "";
            cbRaridade.Text = "";
            txtpreco.Clear();
            txtnome.Focus();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Skins novaSkin = new Skins();

            novaSkin.Nome = txtnome.Text;
            novaSkin.Arma = Convert.ToInt32(cbArma.SelectedValue.ToString());
            novaSkin.Raridade = Convert.ToInt32(cbRaridade.SelectedValue.ToString());
            novaSkin.Preco = float.Parse(txtpreco.Text);
            bool retorno = con.insereSkin(novaSkin);
            if (retorno == false)
                MessageBox.Show(con.mensagem);

            limpaCampos();
            listaGridSkins();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void k(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAlteraPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddArma formArma = new FrmAddArma();
            this.Hide();
            formArma.ShowDialog();
            
        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void dgSkins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
