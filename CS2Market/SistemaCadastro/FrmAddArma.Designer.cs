namespace SistemaCadastro
{
    partial class FrmAddArma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnRemoveArma = new System.Windows.Forms.Button();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(242, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adicionar Arma";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.DarkOrange;
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.Linen;
            this.txtnome.Location = new System.Drawing.Point(149, 96);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(405, 27);
            this.txtnome.TabIndex = 10;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome da Arma:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.Linen;
            this.btnFechar.Location = new System.Drawing.Point(636, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 29);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRemoveArma
            // 
            this.btnRemoveArma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveArma.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveArma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveArma.FlatAppearance.BorderSize = 2;
            this.btnRemoveArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveArma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveArma.ForeColor = System.Drawing.Color.Linen;
            this.btnRemoveArma.Image = global::SistemaCadastro.Properties.Resources.delete;
            this.btnRemoveArma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveArma.Location = new System.Drawing.Point(282, 138);
            this.btnRemoveArma.Name = "btnRemoveArma";
            this.btnRemoveArma.Size = new System.Drawing.Size(128, 53);
            this.btnRemoveArma.TabIndex = 19;
            this.btnRemoveArma.Text = "&Remover";
            this.btnRemoveArma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveArma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveArma.UseVisualStyleBackColor = false;
            this.btnRemoveArma.Click += new System.EventHandler(this.btnAddArma_Click);
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 2;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.Linen;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.f771f845_88a7_461a_b832_cc9f9679d3ff;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(425, 138);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(129, 53);
            this.BtnConfirmaCadastro.TabIndex = 14;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = false;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // FrmAddArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(673, 225);
            this.Controls.Add(this.btnRemoveArma);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BtnConfirmaCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddArma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddArma";
            this.Load += new System.EventHandler(this.FrmAddArma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRemoveArma;
    }
}