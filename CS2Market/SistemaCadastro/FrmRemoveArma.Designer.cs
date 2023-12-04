namespace SistemaCadastro
{
    partial class FrmRemoveArma
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
            this.dgArmas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnRemoveArma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArmas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(259, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remover Arma";
            // 
            // dgArmas
            // 
            this.dgArmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArmas.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgArmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArmas.Location = new System.Drawing.Point(19, 160);
            this.dgArmas.Margin = new System.Windows.Forms.Padding(2);
            this.dgArmas.Name = "dgArmas";
            this.dgArmas.ReadOnly = true;
            this.dgArmas.RowHeadersWidth = 51;
            this.dgArmas.RowTemplate.Height = 29;
            this.dgArmas.Size = new System.Drawing.Size(604, 189);
            this.dgArmas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome da Arma:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.DarkOrange;
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBusca.ForeColor = System.Drawing.Color.Bisque;
            this.txtBusca.Location = new System.Drawing.Point(154, 122);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(342, 27);
            this.txtBusca.TabIndex = 8;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnRemoveArma
            // 
            this.btnRemoveArma.FlatAppearance.BorderSize = 2;
            this.btnRemoveArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveArma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveArma.ForeColor = System.Drawing.Color.Linen;
            this.btnRemoveArma.Location = new System.Drawing.Point(531, 119);
            this.btnRemoveArma.Name = "btnRemoveArma";
            this.btnRemoveArma.Size = new System.Drawing.Size(92, 33);
            this.btnRemoveArma.TabIndex = 15;
            this.btnRemoveArma.Text = "Remover";
            this.btnRemoveArma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveArma.UseVisualStyleBackColor = true;
            this.btnRemoveArma.Click += new System.EventHandler(this.btnRemoveSkin_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFechar.FlatAppearance.BorderSize = 2;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Linen;
            this.btnFechar.Location = new System.Drawing.Point(641, 16);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 27);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmRemoveArma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(680, 375);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRemoveArma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgArmas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRemoveArma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemoveArma";
            this.Load += new System.EventHandler(this.FrmRemoveArma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnRemoveArma;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgArmas;
    }
}