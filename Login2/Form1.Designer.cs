namespace Login2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnCriarBancoDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(583, 309);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 27);
            this.txtID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(570, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Blue;
            this.btnEncerrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.White;
            this.btnEncerrar.Location = new System.Drawing.Point(840, 435);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(120, 49);
            this.btnEncerrar.TabIndex = 0;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocalizarDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLocalizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocalizarDados.Location = new System.Drawing.Point(849, 363);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(120, 49);
            this.btnLocalizarDados.TabIndex = 0;
            this.btnLocalizarDados.Text = "Localizar Dados";
            this.btnLocalizarDados.UseVisualStyleBackColor = false;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExcluirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirDados.Location = new System.Drawing.Point(723, 363);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(120, 49);
            this.btnExcluirDados.TabIndex = 0;
            this.btnExcluirDados.Text = "Excluir Dados";
            this.btnExcluirDados.UseVisualStyleBackColor = false;
            this.btnExcluirDados.Click += new System.EventHandler(this.btnExcluirDados_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizarDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarDados.Location = new System.Drawing.Point(597, 363);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(120, 49);
            this.btnAtualizarDados.TabIndex = 0;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = false;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIncluirDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnIncluirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirDados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIncluirDados.Location = new System.Drawing.Point(471, 363);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(120, 49);
            this.btnIncluirDados.TabIndex = 0;
            this.btnIncluirDados.Text = "Incluir Dados";
            this.btnIncluirDados.UseVisualStyleBackColor = false;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExibirDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExibirDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExibirDados.Location = new System.Drawing.Point(345, 363);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(120, 49);
            this.btnExibirDados.TabIndex = 0;
            this.btnExibirDados.Text = "Exibir Dados";
            this.btnExibirDados.UseVisualStyleBackColor = false;
            this.btnExibirDados.Click += new System.EventHandler(this.btnExibirDados_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(119, 310);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 27);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCriarTabela.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCriarTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarTabela.Location = new System.Drawing.Point(219, 363);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(120, 49);
            this.btnCriarTabela.TabIndex = 0;
            this.btnCriarTabela.Text = "Criar Tabela";
            this.btnCriarTabela.UseVisualStyleBackColor = false;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // btnCriarBancoDados
            // 
            this.btnCriarBancoDados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCriarBancoDados.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCriarBancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarBancoDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarBancoDados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarBancoDados.Location = new System.Drawing.Point(93, 363);
            this.btnCriarBancoDados.Name = "btnCriarBancoDados";
            this.btnCriarBancoDados.Size = new System.Drawing.Size(120, 49);
            this.btnCriarBancoDados.TabIndex = 0;
            this.btnCriarBancoDados.Text = "Criar Banco de Dados";
            this.btnCriarBancoDados.UseVisualStyleBackColor = false;
            this.btnCriarBancoDados.Click += new System.EventHandler(this.btnCriarBancoDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(588, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF / RG:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(758, 309);
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 27);
            this.txtTelefone.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtRelatorio);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEncerrar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnLocalizarDados);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnExcluirDados);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAtualizarDados);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnIncluirDados);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.btnExibirDados);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.btnCriarTabela);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.btnCriarBancoDados);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 535);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.BackColor = System.Drawing.Color.LightCyan;
            this.txtRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorio.Location = new System.Drawing.Point(93, 28);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(450, 215);
            this.txtRelatorio.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(878, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exportar Para Excel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(93, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exportar para Word";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1072, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(769, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 535);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnCriarBancoDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRelatorio;
    }
}