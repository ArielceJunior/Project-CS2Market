namespace SistemaCadastro
{
    partial class Sistema
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.btnAddArma = new System.Windows.Forms.Button();
            this.cbRaridade = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveSkin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgSkins = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.cbAlteraRaridade = new System.Windows.Forms.ComboBox();
            this.cbAlteraArma = new System.Windows.Forms.ComboBox();
            this.txtAlteraPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lupinha = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSkins)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(19, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 278);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.Orange;
            this.tabCadastrar.Controls.Add(this.btnAddArma);
            this.tabCadastrar.Controls.Add(this.cbRaridade);
            this.tabCadastrar.Controls.Add(this.label11);
            this.tabCadastrar.Controls.Add(this.cbArma);
            this.tabCadastrar.Controls.Add(this.txtpreco);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtnome);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 26);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(664, 248);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            this.tabCadastrar.Click += new System.EventHandler(this.tabCadastrar_Click);
            // 
            // btnAddArma
            // 
            this.btnAddArma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddArma.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddArma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddArma.FlatAppearance.BorderSize = 2;
            this.btnAddArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArma.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArma.ForeColor = System.Drawing.Color.Linen;
            this.btnAddArma.Image = global::SistemaCadastro.Properties.Resources.plus__2_;
            this.btnAddArma.Location = new System.Drawing.Point(267, 175);
            this.btnAddArma.Name = "btnAddArma";
            this.btnAddArma.Size = new System.Drawing.Size(207, 50);
            this.btnAddArma.TabIndex = 18;
            this.btnAddArma.Text = "&Adicionar Arma";
            this.btnAddArma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddArma.UseVisualStyleBackColor = false;
            this.btnAddArma.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbRaridade
            // 
            this.cbRaridade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbRaridade.BackColor = System.Drawing.Color.DarkOrange;
            this.cbRaridade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbRaridade.ForeColor = System.Drawing.Color.Linen;
            this.cbRaridade.FormattingEnabled = true;
            this.cbRaridade.Location = new System.Drawing.Point(157, 93);
            this.cbRaridade.Margin = new System.Windows.Forms.Padding(2);
            this.cbRaridade.Name = "cbRaridade";
            this.cbRaridade.Size = new System.Drawing.Size(480, 29);
            this.cbRaridade.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(95, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Preço:";
            // 
            // cbArma
            // 
            this.cbArma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbArma.BackColor = System.Drawing.Color.DarkOrange;
            this.cbArma.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbArma.ForeColor = System.Drawing.Color.Linen;
            this.cbArma.FormattingEnabled = true;
            this.cbArma.Location = new System.Drawing.Point(157, 58);
            this.cbArma.Margin = new System.Windows.Forms.Padding(2);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(480, 29);
            this.cbArma.TabIndex = 10;
            this.cbArma.SelectedIndexChanged += new System.EventHandler(this.cbGenero_SelectedIndexChanged);
            // 
            // txtpreco
            // 
            this.txtpreco.BackColor = System.Drawing.Color.DarkOrange;
            this.txtpreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtpreco.ForeColor = System.Drawing.Color.Linen;
            this.txtpreco.Location = new System.Drawing.Point(157, 133);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(480, 27);
            this.txtpreco.TabIndex = 12;
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnConfirmaCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 2;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Linen;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.f771f845_88a7_461a_b832_cc9f9679d3ff;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(480, 175);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Padding = new System.Windows.Forms.Padding(2);
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(157, 50);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = false;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.DarkOrange;
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnome.ForeColor = System.Drawing.Color.Linen;
            this.txtnome.Location = new System.Drawing.Point(157, 21);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(480, 29);
            this.txtnome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(67, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raridade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(95, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(37, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome da Skin:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.Orange;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.btnRemoveSkin);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtBusca);
            this.tabBuscar.Controls.Add(this.dgSkins);
            this.tabBuscar.Location = new System.Drawing.Point(4, 26);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(664, 248);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.Linen;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(550, 10);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 39);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveSkin
            // 
            this.btnRemoveSkin.FlatAppearance.BorderColor = System.Drawing.Color.Linen;
            this.btnRemoveSkin.FlatAppearance.BorderSize = 2;
            this.btnRemoveSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSkin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveSkin.ForeColor = System.Drawing.Color.Linen;
            this.btnRemoveSkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSkin.Location = new System.Drawing.Point(432, 10);
            this.btnRemoveSkin.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveSkin.Name = "btnRemoveSkin";
            this.btnRemoveSkin.Padding = new System.Windows.Forms.Padding(3);
            this.btnRemoveSkin.Size = new System.Drawing.Size(100, 39);
            this.btnRemoveSkin.TabIndex = 14;
            this.btnRemoveSkin.Text = "Remover";
            this.btnRemoveSkin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveSkin.UseVisualStyleBackColor = true;
            this.btnRemoveSkin.Click += new System.EventHandler(this.btnRemoveSkin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(1, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome da Skin:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.DarkOrange;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBusca.ForeColor = System.Drawing.Color.Linen;
            this.txtBusca.Location = new System.Drawing.Point(143, 16);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(270, 27);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgSkins
            // 
            this.dgSkins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSkins.BackgroundColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSkins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSkins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSkins.Location = new System.Drawing.Point(42, 55);
            this.dgSkins.Margin = new System.Windows.Forms.Padding(2);
            this.dgSkins.Name = "dgSkins";
            this.dgSkins.ReadOnly = true;
            this.dgSkins.RowHeadersWidth = 51;
            this.dgSkins.RowTemplate.Height = 29;
            this.dgSkins.Size = new System.Drawing.Size(598, 189);
            this.dgSkins.TabIndex = 0;
            this.dgSkins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSkins_CellContentClick);
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.Color.Orange;
            this.tabAlterar.Controls.Add(this.cbAlteraRaridade);
            this.tabAlterar.Controls.Add(this.cbAlteraArma);
            this.tabAlterar.Controls.Add(this.txtAlteraPreco);
            this.tabAlterar.Controls.Add(this.label7);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Location = new System.Drawing.Point(4, 26);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Size = new System.Drawing.Size(664, 248);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            // 
            // cbAlteraRaridade
            // 
            this.cbAlteraRaridade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAlteraRaridade.BackColor = System.Drawing.Color.DarkOrange;
            this.cbAlteraRaridade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAlteraRaridade.ForeColor = System.Drawing.Color.Linen;
            this.cbAlteraRaridade.FormattingEnabled = true;
            this.cbAlteraRaridade.Location = new System.Drawing.Point(158, 101);
            this.cbAlteraRaridade.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlteraRaridade.Name = "cbAlteraRaridade";
            this.cbAlteraRaridade.Size = new System.Drawing.Size(480, 29);
            this.cbAlteraRaridade.TabIndex = 24;
            // 
            // cbAlteraArma
            // 
            this.cbAlteraArma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbAlteraArma.BackColor = System.Drawing.Color.DarkOrange;
            this.cbAlteraArma.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbAlteraArma.ForeColor = System.Drawing.Color.Linen;
            this.cbAlteraArma.FormattingEnabled = true;
            this.cbAlteraArma.Location = new System.Drawing.Point(158, 61);
            this.cbAlteraArma.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlteraArma.Name = "cbAlteraArma";
            this.cbAlteraArma.Size = new System.Drawing.Size(480, 29);
            this.cbAlteraArma.TabIndex = 23;
            // 
            // txtAlteraPreco
            // 
            this.txtAlteraPreco.BackColor = System.Drawing.Color.DarkOrange;
            this.txtAlteraPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlteraPreco.ForeColor = System.Drawing.Color.Linen;
            this.txtAlteraPreco.Location = new System.Drawing.Point(158, 144);
            this.txtAlteraPreco.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlteraPreco.Name = "txtAlteraPreco";
            this.txtAlteraPreco.Size = new System.Drawing.Size(480, 27);
            this.txtAlteraPreco.TabIndex = 20;
            this.txtAlteraPreco.TextChanged += new System.EventHandler(this.txtAlteraPreco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Linen;
            this.label7.Location = new System.Drawing.Point(90, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Preço:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.BackColor = System.Drawing.Color.DarkOrange;
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.ForeColor = System.Drawing.Color.Linen;
            this.txtAlteraNome.Location = new System.Drawing.Point(158, 22);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(480, 29);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Linen;
            this.label8.Location = new System.Drawing.Point(62, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Raridade:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(90, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Arma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(25, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome da Skin:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 2;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.Linen;
            this.btnConfirmaAlteracao.Image = global::SistemaCadastro.Properties.Resources.check;
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(418, 185);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(220, 49);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "&Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = false;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(544, 26);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(272, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gerenciamento de Skins";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lupinha
            // 
            this.lupinha.BackColor = System.Drawing.Color.Transparent;
            this.lupinha.Image = global::SistemaCadastro.Properties.Resources.lupa;
            this.lupinha.Location = new System.Drawing.Point(639, 109);
            this.lupinha.Name = "lupinha";
            this.lupinha.Size = new System.Drawing.Size(38, 35);
            this.lupinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lupinha.TabIndex = 11;
            this.lupinha.TabStop = false;
            this.lupinha.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SistemaCadastro.Properties.Resources.CS2Market__2_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 213);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::SistemaCadastro.Properties.Resources.square;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1074, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.Linen;
            this.btnFechar.Location = new System.Drawing.Point(691, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 29);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(726, 525);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lupinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSkins)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.DataGridView dgSkins;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnRemoveSkin;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.TextBox txtAlteraPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.ComboBox cbAlteraArma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbRaridade;
        private System.Windows.Forms.ComboBox cbAlteraRaridade;
        private System.Windows.Forms.Button btnAddArma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lupinha;
        private System.Windows.Forms.Button btnFechar;
    }
}