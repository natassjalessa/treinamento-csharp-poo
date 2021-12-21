namespace prjHeranca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesPro = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLivro = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageCD = new System.Windows.Forms.TabPage();
            this.btnListarCD = new System.Windows.Forms.Button();
            this.btnVenderCD = new System.Windows.Forms.Button();
            this.btnComprarCD = new System.Windows.Forms.Button();
            this.btnCadastrarCD = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageDVD = new System.Windows.Forms.TabPage();
            this.btnListarDVD = new System.Windows.Forms.Button();
            this.btnVenderDVD = new System.Windows.Forms.Button();
            this.btnComprarDVD = new System.Windows.Forms.Button();
            this.btnCadastrarDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLivro.SuspendLayout();
            this.tabPageCD.SuspendLayout();
            this.tabPageDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // txtDesPro
            // 
            this.txtDesPro.Location = new System.Drawing.Point(12, 37);
            this.txtDesPro.Name = "txtDesPro";
            this.txtDesPro.Size = new System.Drawing.Size(556, 31);
            this.txtDesPro.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 105);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(556, 31);
            this.txtGenero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gênero:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(12, 178);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(556, 31);
            this.txtEstoque.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde em Estoque:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(12, 249);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(556, 31);
            this.txtPreco.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLivro);
            this.tabControl1.Controls.Add(this.tabPageCD);
            this.tabControl1.Controls.Add(this.tabPageDVD);
            this.tabControl1.Location = new System.Drawing.Point(12, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 308);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageLivro
            // 
            this.tabPageLivro.Controls.Add(this.btnListar);
            this.tabPageLivro.Controls.Add(this.btnVender);
            this.tabPageLivro.Controls.Add(this.btnComprar);
            this.tabPageLivro.Controls.Add(this.btnCadastrar);
            this.tabPageLivro.Controls.Add(this.txtEdicao);
            this.tabPageLivro.Controls.Add(this.label7);
            this.tabPageLivro.Controls.Add(this.txtEditora);
            this.tabPageLivro.Controls.Add(this.label6);
            this.tabPageLivro.Controls.Add(this.txtAutor);
            this.tabPageLivro.Controls.Add(this.label5);
            this.tabPageLivro.Location = new System.Drawing.Point(4, 34);
            this.tabPageLivro.Name = "tabPageLivro";
            this.tabPageLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLivro.Size = new System.Drawing.Size(548, 270);
            this.tabPageLivro.TabIndex = 0;
            this.tabPageLivro.Text = "Livro";
            this.tabPageLivro.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(39, 214);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 34);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(399, 214);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(112, 34);
            this.btnVender.TabIndex = 17;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(281, 214);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(112, 34);
            this.btnComprar.TabIndex = 16;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(163, 214);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(3, 165);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(229, 31);
            this.txtEdicao.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edição:";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(3, 97);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(229, 31);
            this.txtEditora.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editora:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(6, 31);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(229, 31);
            this.txtAutor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autor:";
            // 
            // tabPageCD
            // 
            this.tabPageCD.Controls.Add(this.btnListarCD);
            this.tabPageCD.Controls.Add(this.btnVenderCD);
            this.tabPageCD.Controls.Add(this.btnComprarCD);
            this.tabPageCD.Controls.Add(this.btnCadastrarCD);
            this.tabPageCD.Controls.Add(this.txtOrigem);
            this.tabPageCD.Controls.Add(this.label8);
            this.tabPageCD.Controls.Add(this.txtGravadora);
            this.tabPageCD.Controls.Add(this.label9);
            this.tabPageCD.Controls.Add(this.txtArtista);
            this.tabPageCD.Controls.Add(this.label10);
            this.tabPageCD.Location = new System.Drawing.Point(4, 34);
            this.tabPageCD.Name = "tabPageCD";
            this.tabPageCD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCD.Size = new System.Drawing.Size(548, 270);
            this.tabPageCD.TabIndex = 1;
            this.tabPageCD.Text = "CD";
            this.tabPageCD.UseVisualStyleBackColor = true;
            // 
            // btnListarCD
            // 
            this.btnListarCD.Location = new System.Drawing.Point(19, 230);
            this.btnListarCD.Name = "btnListarCD";
            this.btnListarCD.Size = new System.Drawing.Size(112, 34);
            this.btnListarCD.TabIndex = 27;
            this.btnListarCD.Text = "Listar";
            this.btnListarCD.UseVisualStyleBackColor = true;
            this.btnListarCD.Click += new System.EventHandler(this.btnListarCD_Click);
            // 
            // btnVenderCD
            // 
            this.btnVenderCD.Location = new System.Drawing.Point(375, 230);
            this.btnVenderCD.Name = "btnVenderCD";
            this.btnVenderCD.Size = new System.Drawing.Size(112, 34);
            this.btnVenderCD.TabIndex = 26;
            this.btnVenderCD.Text = "Vender";
            this.btnVenderCD.UseVisualStyleBackColor = true;
            this.btnVenderCD.Click += new System.EventHandler(this.btnVenderCD_Click);
            // 
            // btnComprarCD
            // 
            this.btnComprarCD.Location = new System.Drawing.Point(254, 230);
            this.btnComprarCD.Name = "btnComprarCD";
            this.btnComprarCD.Size = new System.Drawing.Size(112, 34);
            this.btnComprarCD.TabIndex = 25;
            this.btnComprarCD.Text = "Comprar";
            this.btnComprarCD.UseVisualStyleBackColor = true;
            this.btnComprarCD.Click += new System.EventHandler(this.btnComprarCD_Click);
            // 
            // btnCadastrarCD
            // 
            this.btnCadastrarCD.Location = new System.Drawing.Point(137, 230);
            this.btnCadastrarCD.Name = "btnCadastrarCD";
            this.btnCadastrarCD.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrarCD.TabIndex = 24;
            this.btnCadastrarCD.Text = "Cadastrar";
            this.btnCadastrarCD.UseVisualStyleBackColor = true;
            this.btnCadastrarCD.Click += new System.EventHandler(this.btnCadastrarCD_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(6, 176);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(229, 31);
            this.txtOrigem.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "País de Origem:";
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(6, 108);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(229, 31);
            this.txtGravadora.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gravadora:";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(9, 42);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(229, 31);
            this.txtArtista.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Artista:";
            // 
            // tabPageDVD
            // 
            this.tabPageDVD.Controls.Add(this.btnListarDVD);
            this.tabPageDVD.Controls.Add(this.btnVenderDVD);
            this.tabPageDVD.Controls.Add(this.btnComprarDVD);
            this.tabPageDVD.Controls.Add(this.btnCadastrarDVD);
            this.tabPageDVD.Controls.Add(this.txtCensura);
            this.tabPageDVD.Controls.Add(this.label11);
            this.tabPageDVD.Controls.Add(this.txtDuracao);
            this.tabPageDVD.Controls.Add(this.label12);
            this.tabPageDVD.Controls.Add(this.txtDiretor);
            this.tabPageDVD.Controls.Add(this.label13);
            this.tabPageDVD.Location = new System.Drawing.Point(4, 34);
            this.tabPageDVD.Name = "tabPageDVD";
            this.tabPageDVD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDVD.Size = new System.Drawing.Size(548, 270);
            this.tabPageDVD.TabIndex = 2;
            this.tabPageDVD.Text = "DVD";
            this.tabPageDVD.UseVisualStyleBackColor = true;
            // 
            // btnListarDVD
            // 
            this.btnListarDVD.Location = new System.Drawing.Point(362, 217);
            this.btnListarDVD.Name = "btnListarDVD";
            this.btnListarDVD.Size = new System.Drawing.Size(112, 34);
            this.btnListarDVD.TabIndex = 36;
            this.btnListarDVD.Text = "Listar";
            this.btnListarDVD.UseVisualStyleBackColor = true;
            this.btnListarDVD.Click += new System.EventHandler(this.btnListarDVD_Click);
            // 
            // btnVenderDVD
            // 
            this.btnVenderDVD.Location = new System.Drawing.Point(244, 217);
            this.btnVenderDVD.Name = "btnVenderDVD";
            this.btnVenderDVD.Size = new System.Drawing.Size(112, 34);
            this.btnVenderDVD.TabIndex = 35;
            this.btnVenderDVD.Text = "Vender";
            this.btnVenderDVD.UseVisualStyleBackColor = true;
            this.btnVenderDVD.Click += new System.EventHandler(this.btnVenderDVD_Click);
            // 
            // btnComprarDVD
            // 
            this.btnComprarDVD.Location = new System.Drawing.Point(123, 217);
            this.btnComprarDVD.Name = "btnComprarDVD";
            this.btnComprarDVD.Size = new System.Drawing.Size(112, 34);
            this.btnComprarDVD.TabIndex = 34;
            this.btnComprarDVD.Text = "Comprar";
            this.btnComprarDVD.UseVisualStyleBackColor = true;
            this.btnComprarDVD.Click += new System.EventHandler(this.btnComprarDVD_Click);
            // 
            // btnCadastrarDVD
            // 
            this.btnCadastrarDVD.Location = new System.Drawing.Point(6, 217);
            this.btnCadastrarDVD.Name = "btnCadastrarDVD";
            this.btnCadastrarDVD.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrarDVD.TabIndex = 33;
            this.btnCadastrarDVD.Text = "Cadastrar";
            this.btnCadastrarDVD.UseVisualStyleBackColor = true;
            this.btnCadastrarDVD.Click += new System.EventHandler(this.btnCadastrarDVD_Click);
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(6, 168);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(229, 31);
            this.txtCensura.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Censura:";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(6, 100);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(229, 31);
            this.txtDuracao.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Duração:";
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(9, 34);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(229, 31);
            this.txtDiretor.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Diretor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 616);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesPro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLivro.ResumeLayout(false);
            this.tabPageLivro.PerformLayout();
            this.tabPageCD.ResumeLayout(false);
            this.tabPageCD.PerformLayout();
            this.tabPageDVD.ResumeLayout(false);
            this.tabPageDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDesPro;
        private TextBox txtGenero;
        private Label label2;
        private TextBox txtEstoque;
        private Label label3;
        private TextBox txtPreco;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPageLivro;
        private TextBox txtEditora;
        private Label label6;
        private TextBox txtAutor;
        private Label label5;
        private TabPage tabPageCD;
        private TabPage tabPageDVD;
        private TextBox txtEdicao;
        private Label label7;
        private Button btnVender;
        private Button btnComprar;
        private Button btnCadastrar;
        private Button btnVenderCD;
        private Button btnComprarCD;
        private Button btnCadastrarCD;
        private TextBox txtOrigem;
        private Label label8;
        private TextBox txtGravadora;
        private Label label9;
        private TextBox txtArtista;
        private Label label10;
        private Button btnVenderDVD;
        private Button btnComprarDVD;
        private Button btnCadastrarDVD;
        private TextBox txtCensura;
        private Label label11;
        private TextBox txtDuracao;
        private Label label12;
        private TextBox txtDiretor;
        private Label label13;
        private Button btnListar;
        private Button btnListarCD;
        private Button btnListarDVD;
    }
}