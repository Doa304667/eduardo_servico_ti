namespace eduardo_servico_ti
{
    partial class cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNOMECLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCel = new System.Windows.Forms.Label();
            this.textBoxCEL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxQCL = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxACESS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxVID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPLACA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFONTE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPROC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxORCA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBoxOBS = new System.Windows.Forms.RichTextBox();
            this.comboBoxSTATUS = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSALVAR = new System.Windows.Forms.Button();
            this.buttonALT = new System.Windows.Forms.Button();
            this.buttonEX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPESQ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNOMECLIENTE
            // 
            this.textBoxNOMECLIENTE.Location = new System.Drawing.Point(123, 17);
            this.textBoxNOMECLIENTE.Name = "textBoxNOMECLIENTE";
            this.textBoxNOMECLIENTE.Size = new System.Drawing.Size(205, 20);
            this.textBoxNOMECLIENTE.TabIndex = 0;
            this.textBoxNOMECLIENTE.TextChanged += new System.EventHandler(this.textBoxNOMECLIENTE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de serviço:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(9, 17);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(108, 17);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome do cliente:";
            this.labelNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelCel);
            this.panel1.Controls.Add(this.textBoxCEL);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.textBoxNOMECLIENTE);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 86);
            this.panel1.TabIndex = 3;
            // 
            // labelCel
            // 
            this.labelCel.AutoSize = true;
            this.labelCel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCel.Location = new System.Drawing.Point(9, 43);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(51, 17);
            this.labelCel.TabIndex = 4;
            this.labelCel.Text = "Celular:";
            this.labelCel.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxCEL
            // 
            this.textBoxCEL.Location = new System.Drawing.Point(66, 43);
            this.textBoxCEL.Name = "textBoxCEL";
            this.textBoxCEL.Size = new System.Drawing.Size(157, 20);
            this.textBoxCEL.TabIndex = 3;
            this.textBoxCEL.TextChanged += new System.EventHandler(this.textBoxCEL_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.richTextBoxQCL);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBoxACESS);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxVID);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxRAM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxPLACA);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxFONTE);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxPROC);
            this.panel2.Location = new System.Drawing.Point(364, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 390);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "(AAAA-MM-DD)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data de entrada:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // richTextBoxQCL
            // 
            this.richTextBoxQCL.Location = new System.Drawing.Point(12, 239);
            this.richTextBoxQCL.Name = "richTextBoxQCL";
            this.richTextBoxQCL.Size = new System.Drawing.Size(253, 132);
            this.richTextBoxQCL.TabIndex = 14;
            this.richTextBoxQCL.Text = "";
            this.richTextBoxQCL.TextChanged += new System.EventHandler(this.richTextBoxQCL_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Queixa do cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Acessórios:";
            // 
            // textBoxACESS
            // 
            this.textBoxACESS.Location = new System.Drawing.Point(87, 147);
            this.textBoxACESS.Name = "textBoxACESS";
            this.textBoxACESS.Size = new System.Drawing.Size(178, 20);
            this.textBoxACESS.TabIndex = 11;
            this.textBoxACESS.TextChanged += new System.EventHandler(this.textBoxACESS_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Video:";
            // 
            // textBoxVID
            // 
            this.textBoxVID.Location = new System.Drawing.Point(59, 121);
            this.textBoxVID.Name = "textBoxVID";
            this.textBoxVID.Size = new System.Drawing.Size(206, 20);
            this.textBoxVID.TabIndex = 9;
            this.textBoxVID.TextChanged += new System.EventHandler(this.textBoxVID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ram:";
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(59, 95);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(206, 20);
            this.textBoxRAM.TabIndex = 7;
            this.textBoxRAM.TextChanged += new System.EventHandler(this.textBoxRAM_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Placa-Mãe:";
            // 
            // textBoxPLACA
            // 
            this.textBoxPLACA.Location = new System.Drawing.Point(87, 43);
            this.textBoxPLACA.Name = "textBoxPLACA";
            this.textBoxPLACA.Size = new System.Drawing.Size(178, 20);
            this.textBoxPLACA.TabIndex = 5;
            this.textBoxPLACA.TextChanged += new System.EventHandler(this.textBoxPLACA_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fonte:";
            // 
            // textBoxFONTE
            // 
            this.textBoxFONTE.Location = new System.Drawing.Point(59, 69);
            this.textBoxFONTE.Name = "textBoxFONTE";
            this.textBoxFONTE.Size = new System.Drawing.Size(206, 20);
            this.textBoxFONTE.TabIndex = 3;
            this.textBoxFONTE.TextChanged += new System.EventHandler(this.textBoxFONTE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Processador:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPROC
            // 
            this.textBoxPROC.Location = new System.Drawing.Point(99, 17);
            this.textBoxPROC.Name = "textBoxPROC";
            this.textBoxPROC.Size = new System.Drawing.Size(166, 20);
            this.textBoxPROC.TabIndex = 0;
            this.textBoxPROC.TextChanged += new System.EventHandler(this.textBoxPROC_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Informaçoes do dispositivo:";
            // 
            // textBoxORCA
            // 
            this.textBoxORCA.Location = new System.Drawing.Point(121, 53);
            this.textBoxORCA.Name = "textBoxORCA";
            this.textBoxORCA.Size = new System.Drawing.Size(84, 20);
            this.textBoxORCA.TabIndex = 3;
            this.textBoxORCA.TextChanged += new System.EventHandler(this.textBoxORCA_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Orçamento total:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.richTextBoxOBS);
            this.panel3.Controls.Add(this.comboBoxSTATUS);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBoxORCA);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 295);
            this.panel3.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Observações e possíveis soluções:";
            // 
            // richTextBoxOBS
            // 
            this.richTextBoxOBS.Location = new System.Drawing.Point(12, 144);
            this.richTextBoxOBS.Name = "richTextBoxOBS";
            this.richTextBoxOBS.Size = new System.Drawing.Size(316, 132);
            this.richTextBoxOBS.TabIndex = 15;
            this.richTextBoxOBS.Text = "";
            this.richTextBoxOBS.TextChanged += new System.EventHandler(this.richTextBoxOBS_TextChanged);
            // 
            // comboBoxSTATUS
            // 
            this.comboBoxSTATUS.FormattingEnabled = true;
            this.comboBoxSTATUS.Items.AddRange(new object[] {
            "Aberto",
            "Em andamento",
            "Concluído",
            "Cancelado"});
            this.comboBoxSTATUS.Location = new System.Drawing.Point(61, 26);
            this.comboBoxSTATUS.Name = "comboBoxSTATUS";
            this.comboBoxSTATUS.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSTATUS.TabIndex = 7;
            this.comboBoxSTATUS.SelectedIndexChanged += new System.EventHandler(this.comboBoxSTATUS_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Status:";
            // 
            // buttonSALVAR
            // 
            this.buttonSALVAR.Location = new System.Drawing.Point(78, 451);
            this.buttonSALVAR.Name = "buttonSALVAR";
            this.buttonSALVAR.Size = new System.Drawing.Size(171, 41);
            this.buttonSALVAR.TabIndex = 7;
            this.buttonSALVAR.Text = "Salvar";
            this.buttonSALVAR.UseVisualStyleBackColor = true;
            this.buttonSALVAR.Click += new System.EventHandler(this.buttonSALVAR_Click);
            // 
            // buttonALT
            // 
            this.buttonALT.Location = new System.Drawing.Point(255, 451);
            this.buttonALT.Name = "buttonALT";
            this.buttonALT.Size = new System.Drawing.Size(171, 41);
            this.buttonALT.TabIndex = 8;
            this.buttonALT.Text = "Alterar";
            this.buttonALT.UseVisualStyleBackColor = true;
            this.buttonALT.Click += new System.EventHandler(this.buttonALT_Click);
            // 
            // buttonEX
            // 
            this.buttonEX.Location = new System.Drawing.Point(432, 451);
            this.buttonEX.Name = "buttonEX";
            this.buttonEX.Size = new System.Drawing.Size(171, 41);
            this.buttonEX.TabIndex = 9;
            this.buttonEX.Text = "Excluir";
            this.buttonEX.UseVisualStyleBackColor = true;
            this.buttonEX.Click += new System.EventHandler(this.buttonEX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 390);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisa:";
            // 
            // textBoxPESQ
            // 
            this.textBoxPESQ.Location = new System.Drawing.Point(727, 27);
            this.textBoxPESQ.Name = "textBoxPESQ";
            this.textBoxPESQ.Size = new System.Drawing.Size(279, 20);
            this.textBoxPESQ.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPESQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEX);
            this.Controls.Add(this.buttonALT);
            this.Controls.Add(this.buttonSALVAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "cadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNOMECLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCel;
        private System.Windows.Forms.TextBox textBoxCEL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFONTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPROC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPLACA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxACESS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxVID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxQCL;
        private System.Windows.Forms.TextBox textBoxORCA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBoxOBS;
        private System.Windows.Forms.ComboBox comboBoxSTATUS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonSALVAR;
        private System.Windows.Forms.Button buttonALT;
        private System.Windows.Forms.Button buttonEX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPESQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

