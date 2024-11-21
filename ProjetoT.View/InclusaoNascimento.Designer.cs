namespace Teste.ProjetoT.View {
    partial class InclusaoNascimento {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            InNascimento = new TabControl();
            DadosRegistro = new TabPage();
            button1 = new Button();
            groupBox3 = new GroupBox();
            txtIdadeMae = new TextBox();
            txtCidadeMae = new TextBox();
            txtNomeMae = new TextBox();
            txtDataNascMae = new MaskedTextBox();
            txtUfMae = new ComboBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            txtIdadePai = new TextBox();
            txtCidadePai = new TextBox();
            txtNomePai = new TextBox();
            txtDataNascPai = new MaskedTextBox();
            txtUfPai = new ComboBox();
            label12 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtSexoRegistrado = new ComboBox();
            txtNomeRegistrado = new TextBox();
            txtHoraNasc = new MaskedTextBox();
            txtDataNascReg = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DadosLivro = new TabPage();
            button2 = new Button();
            groupBox4 = new GroupBox();
            txtDnv3 = new MaskedTextBox();
            txtDnv2 = new MaskedTextBox();
            txtDnv1 = new MaskedTextBox();
            txtDataRegistro = new MaskedTextBox();
            txtNumRegistro = new TextBox();
            txtNumPag = new TextBox();
            txtNumLivro = new TextBox();
            txtNomeLivro = new TextBox();
            CheckPrazo = new CheckBox();
            label19 = new Label();
            label13 = new Label();
            label18 = new Label();
            label14 = new Label();
            label17 = new Label();
            label15 = new Label();
            label16 = new Label();
            toolTip1 = new ToolTip(components);
            InNascimento.SuspendLayout();
            DadosRegistro.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            DadosLivro.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // InNascimento
            // 
            InNascimento.Controls.Add(DadosRegistro);
            InNascimento.Controls.Add(DadosLivro);
            InNascimento.Dock = DockStyle.Fill;
            InNascimento.Location = new Point(0, 0);
            InNascimento.Name = "InNascimento";
            InNascimento.SelectedIndex = 0;
            InNascimento.Size = new Size(800, 498);
            InNascimento.TabIndex = 0;
            // 
            // DadosRegistro
            // 
            DadosRegistro.Controls.Add(button1);
            DadosRegistro.Controls.Add(groupBox3);
            DadosRegistro.Controls.Add(groupBox2);
            DadosRegistro.Controls.Add(groupBox1);
            DadosRegistro.Location = new Point(4, 29);
            DadosRegistro.Name = "DadosRegistro";
            DadosRegistro.Padding = new Padding(3);
            DadosRegistro.Size = new Size(792, 465);
            DadosRegistro.TabIndex = 0;
            DadosRegistro.Text = "Dados do nascido";
            DadosRegistro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(661, 414);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 1;
            button1.Text = "Próxima aba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtIdadeMae);
            groupBox3.Controls.Add(txtCidadeMae);
            groupBox3.Controls.Add(txtNomeMae);
            groupBox3.Controls.Add(txtDataNascMae);
            groupBox3.Controls.Add(txtUfMae);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(3, 255);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(789, 134);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados da mãe";
            // 
            // txtIdadeMae
            // 
            txtIdadeMae.Location = new Point(373, 57);
            txtIdadeMae.Name = "txtIdadeMae";
            txtIdadeMae.Size = new Size(37, 27);
            txtIdadeMae.TabIndex = 11;
            // 
            // txtCidadeMae
            // 
            txtCidadeMae.Location = new Point(255, 91);
            txtCidadeMae.Name = "txtCidadeMae";
            txtCidadeMae.Size = new Size(346, 27);
            txtCidadeMae.TabIndex = 2;
            // 
            // txtNomeMae
            // 
            txtNomeMae.CharacterCasing = CharacterCasing.Upper;
            txtNomeMae.Location = new Point(255, 19);
            txtNomeMae.Name = "txtNomeMae";
            txtNomeMae.Size = new Size(507, 27);
            txtNomeMae.TabIndex = 0;
            txtNomeMae.MouseClick += txtNomeMae_MouseClick;
            // 
            // txtDataNascMae
            // 
            txtDataNascMae.Location = new Point(255, 58);
            txtDataNascMae.Mask = "00/00/0000";
            txtDataNascMae.Name = "txtDataNascMae";
            txtDataNascMae.Size = new Size(112, 27);
            txtDataNascMae.TabIndex = 1;
            txtDataNascMae.ValidatingType = typeof(DateTime);
            txtDataNascMae.TypeValidationCompleted += txtDataNascMae_TypeValidationCompleted;
            txtDataNascMae.MouseClick += txtDataNascMae_MouseClick;
            // 
            // txtUfMae
            // 
            txtUfMae.FormattingEnabled = true;
            txtUfMae.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtUfMae.Location = new Point(643, 91);
            txtUfMae.Name = "txtUfMae";
            txtUfMae.Size = new Size(45, 28);
            txtUfMae.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 58);
            label10.Name = "label10";
            label10.Size = new Size(225, 23);
            label10.TabIndex = 9;
            label10.Text = "Data de nascimento da mãe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(607, 96);
            label8.Name = "label8";
            label8.Size = new Size(30, 23);
            label8.TabIndex = 7;
            label8.Text = "UF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(130, 23);
            label9.Name = "label9";
            label9.Size = new Size(119, 23);
            label9.TabIndex = 8;
            label9.Text = "Nome da mãe";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 90);
            label11.Name = "label11";
            label11.Size = new Size(242, 23);
            label11.TabIndex = 10;
            label11.Text = "Cidade de nascimento da mãe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdadePai);
            groupBox2.Controls.Add(txtCidadePai);
            groupBox2.Controls.Add(txtNomePai);
            groupBox2.Controls.Add(txtDataNascPai);
            groupBox2.Controls.Add(txtUfPai);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(3, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(786, 120);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do pai";
            // 
            // txtIdadePai
            // 
            txtIdadePai.Location = new Point(373, 44);
            txtIdadePai.Name = "txtIdadePai";
            txtIdadePai.Size = new Size(37, 27);
            txtIdadePai.TabIndex = 12;
            // 
            // txtCidadePai
            // 
            txtCidadePai.Location = new Point(255, 83);
            txtCidadePai.Name = "txtCidadePai";
            txtCidadePai.Size = new Size(346, 27);
            txtCidadePai.TabIndex = 2;
            // 
            // txtNomePai
            // 
            txtNomePai.CharacterCasing = CharacterCasing.Upper;
            txtNomePai.Location = new Point(255, 14);
            txtNomePai.Name = "txtNomePai";
            txtNomePai.Size = new Size(507, 27);
            txtNomePai.TabIndex = 0;
            // 
            // txtDataNascPai
            // 
            txtDataNascPai.Location = new Point(255, 44);
            txtDataNascPai.Mask = "00/00/0000";
            txtDataNascPai.Name = "txtDataNascPai";
            txtDataNascPai.Size = new Size(112, 27);
            txtDataNascPai.TabIndex = 1;
            txtDataNascPai.ValidatingType = typeof(DateTime);
            txtDataNascPai.TypeValidationCompleted += txtDataNascPai_TypeValidationCompleted;
            txtDataNascPai.MouseClick += txtDataNascPai_MouseClick;
            txtDataNascPai.TextChanged += txtDataNascPai_TextChanged;
            txtDataNascPai.KeyDown += txtDataNascPai_KeyDown;
            txtDataNascPai.Leave += txtDataNascPai_Leave;
            // 
            // txtUfPai
            // 
            txtUfPai.FormattingEnabled = true;
            txtUfPai.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtUfPai.Location = new Point(643, 82);
            txtUfPai.Name = "txtUfPai";
            txtUfPai.Size = new Size(45, 28);
            txtUfPai.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(607, 84);
            label12.Name = "label12";
            label12.Size = new Size(30, 23);
            label12.TabIndex = 11;
            label12.Text = "UF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 48);
            label6.Name = "label6";
            label6.Size = new Size(216, 23);
            label6.TabIndex = 5;
            label6.Text = "Data de nascimento do pai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 84);
            label7.Name = "label7";
            label7.Size = new Size(233, 23);
            label7.TabIndex = 6;
            label7.Text = "Cidade de nascimento do pai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(130, 14);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 4;
            label5.Text = "Nome do pai";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSexoRegistrado);
            groupBox1.Controls.Add(txtNomeRegistrado);
            groupBox1.Controls.Add(txtHoraNasc);
            groupBox1.Controls.Add(txtDataNascReg);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 120);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nascido";
            // 
            // txtSexoRegistrado
            // 
            txtSexoRegistrado.FormattingEnabled = true;
            txtSexoRegistrado.Items.AddRange(new object[] { "Masculino", "Feminino" });
            txtSexoRegistrado.Location = new Point(255, 52);
            txtSexoRegistrado.Name = "txtSexoRegistrado";
            txtSexoRegistrado.Size = new Size(153, 28);
            txtSexoRegistrado.TabIndex = 1;
            // 
            // txtNomeRegistrado
            // 
            txtNomeRegistrado.CharacterCasing = CharacterCasing.Upper;
            txtNomeRegistrado.Location = new Point(255, 22);
            txtNomeRegistrado.Name = "txtNomeRegistrado";
            txtNomeRegistrado.Size = new Size(507, 27);
            txtNomeRegistrado.TabIndex = 0;
            // 
            // txtHoraNasc
            // 
            txtHoraNasc.Location = new Point(643, 81);
            txtHoraNasc.Mask = "90:00";
            txtHoraNasc.Name = "txtHoraNasc";
            txtHoraNasc.Size = new Size(45, 27);
            txtHoraNasc.TabIndex = 4;
            txtHoraNasc.ValidatingType = typeof(DateTime);
            // 
            // txtDataNascReg
            // 
            txtDataNascReg.Location = new Point(255, 85);
            txtDataNascReg.Mask = "00/00/0000";
            txtDataNascReg.Name = "txtDataNascReg";
            txtDataNascReg.Size = new Size(112, 27);
            txtDataNascReg.TabIndex = 2;
            txtDataNascReg.ValidatingType = typeof(DateTime);
            txtDataNascReg.TypeValidationCompleted += txtDataNascReg_TypeValidationCompleted;
            txtDataNascReg.MouseClick += txtDataNascReg_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome do registrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 57);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 1;
            label2.Text = "Sexo do registrado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 89);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 2;
            label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(473, 85);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 3;
            label4.Text = "Hora de nascimento";
            // 
            // DadosLivro
            // 
            DadosLivro.Controls.Add(button2);
            DadosLivro.Controls.Add(groupBox4);
            DadosLivro.Location = new Point(4, 29);
            DadosLivro.Name = "DadosLivro";
            DadosLivro.Padding = new Padding(3);
            DadosLivro.Size = new Size(792, 465);
            DadosLivro.TabIndex = 1;
            DadosLivro.Text = "Dados do registro";
            DadosLivro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(660, 410);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 8;
            button2.Text = "Incluir registro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDnv3);
            groupBox4.Controls.Add(txtDnv2);
            groupBox4.Controls.Add(txtDnv1);
            groupBox4.Controls.Add(txtDataRegistro);
            groupBox4.Controls.Add(txtNumRegistro);
            groupBox4.Controls.Add(txtNumPag);
            groupBox4.Controls.Add(txtNumLivro);
            groupBox4.Controls.Add(txtNomeLivro);
            groupBox4.Controls.Add(CheckPrazo);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label16);
            groupBox4.Location = new Point(3, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(793, 159);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dados do registro";
            // 
            // txtDnv3
            // 
            txtDnv3.Location = new Point(275, 98);
            txtDnv3.Mask = "00";
            txtDnv3.Name = "txtDnv3";
            txtDnv3.Size = new Size(28, 27);
            txtDnv3.TabIndex = 15;
            txtDnv3.ValidatingType = typeof(int);
            txtDnv3.MouseClick += txtDnv3_MouseClick;
            // 
            // txtDnv2
            // 
            txtDnv2.Location = new Point(198, 98);
            txtDnv2.Mask = "00000000";
            txtDnv2.Name = "txtDnv2";
            txtDnv2.Size = new Size(71, 27);
            txtDnv2.TabIndex = 14;
            txtDnv2.ValidatingType = typeof(int);
            txtDnv2.MouseClick += txtDnv2_MouseClick;
            // 
            // txtDnv1
            // 
            txtDnv1.Location = new Point(164, 98);
            txtDnv1.Mask = "00";
            txtDnv1.Name = "txtDnv1";
            txtDnv1.Size = new Size(28, 27);
            txtDnv1.TabIndex = 13;
            txtDnv1.ValidatingType = typeof(int);
            txtDnv1.MouseClick += txtDnv1_MouseClick;
            // 
            // txtDataRegistro
            // 
            txtDataRegistro.Location = new Point(425, 58);
            txtDataRegistro.Mask = "00/00/0000";
            txtDataRegistro.Name = "txtDataRegistro";
            txtDataRegistro.Size = new Size(90, 27);
            txtDataRegistro.TabIndex = 12;
            txtDataRegistro.ValidatingType = typeof(DateTime);
            txtDataRegistro.TypeValidationCompleted += txtDataRegistro_TypeValidationCompleted;
            txtDataRegistro.MouseClick += txtDataRegistro_MouseClick;
            // 
            // txtNumRegistro
            // 
            txtNumRegistro.Location = new Point(718, 62);
            txtNumRegistro.Name = "txtNumRegistro";
            txtNumRegistro.Size = new Size(54, 27);
            txtNumRegistro.TabIndex = 11;
            // 
            // txtNumPag
            // 
            txtNumPag.Location = new Point(718, 19);
            txtNumPag.Name = "txtNumPag";
            txtNumPag.Size = new Size(54, 27);
            txtNumPag.TabIndex = 10;
            // 
            // txtNumLivro
            // 
            txtNumLivro.Location = new Point(425, 19);
            txtNumLivro.Name = "txtNumLivro";
            txtNumLivro.Size = new Size(50, 27);
            txtNumLivro.TabIndex = 9;
            // 
            // txtNomeLivro
            // 
            txtNomeLivro.Location = new Point(164, 62);
            txtNomeLivro.Name = "txtNomeLivro";
            txtNomeLivro.Size = new Size(55, 27);
            txtNomeLivro.TabIndex = 8;
            // 
            // CheckPrazo
            // 
            CheckPrazo.AutoSize = true;
            CheckPrazo.Location = new Point(174, 29);
            CheckPrazo.Name = "CheckPrazo";
            CheckPrazo.Size = new Size(18, 17);
            CheckPrazo.TabIndex = 7;
            CheckPrazo.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(38, 23);
            label19.Name = "label19";
            label19.Size = new Size(120, 23);
            label19.TabIndex = 6;
            label19.Text = "Feito no prazo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(35, 62);
            label13.Name = "label13";
            label13.Size = new Size(123, 23);
            label13.TabIndex = 0;
            label13.Text = "Nome do Livro";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(20, 98);
            label18.Name = "label18";
            label18.Size = new Size(138, 23);
            label18.TabIndex = 5;
            label18.Text = "Número da DNV";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(275, 23);
            label14.Name = "label14";
            label14.Size = new Size(135, 23);
            label14.TabIndex = 1;
            label14.Text = "Número do livro";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(277, 62);
            label17.Name = "label17";
            label17.Size = new Size(133, 23);
            label17.TabIndex = 4;
            label17.Text = "Data de registro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(558, 23);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 2;
            label15.Text = "Número da página";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(551, 62);
            label16.Name = "label16";
            label16.Size = new Size(161, 23);
            label16.TabIndex = 3;
            label16.Text = "Número do registro";
            // 
            // InclusaoNascimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(InNascimento);
            Name = "InclusaoNascimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InclusaoNascimento";
            InNascimento.ResumeLayout(false);
            DadosRegistro.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DadosLivro.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl InNascimento;
        private TabPage DadosRegistro;
        private TabPage DadosLivro;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Label label11;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label19;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox txtUfMae;
        private ComboBox txtUfPai;
        private MaskedTextBox txtDataNascMae;
        private MaskedTextBox txtDataNascPai;
        private MaskedTextBox txtHoraNasc;
        private MaskedTextBox txtDataNascReg;
        private TextBox txtNomeRegistrado;
        private ComboBox txtSexoRegistrado;
        private CheckBox CheckPrazo;
        private TextBox txtNumRegistro;
        private TextBox txtNumPag;
        private TextBox txtNumLivro;
        private TextBox txtNomeLivro;
        private MaskedTextBox txtDataRegistro;
        private MaskedTextBox txtDnv1;
        private MaskedTextBox txtDnv3;
        private MaskedTextBox txtDnv2;
        private TextBox txtCidadePai;
        private TextBox txtNomePai;
        private TextBox txtCidadeMae;
        private TextBox txtNomeMae;
        private Button button1;
        private Button button2;
        private TextBox txtIdadeMae;
        private TextBox txtIdadePai;
        public ToolTip toolTip1;
    }
}