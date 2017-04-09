namespace MatrizEsparsa
{
    partial class frmMatrizEsparsa
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
            this.dgMatrizEsparsa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarMatrizEsparsa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numLinhas = new System.Windows.Forms.NumericUpDown();
            this.numColunas = new System.Windows.Forms.NumericUpDown();
            this.panelGerarMatriz = new System.Windows.Forms.Panel();
            this.panelInserirElemento = new System.Windows.Forms.Panel();
            this.numColunaInsercao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numLinhaInsercao = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElementoInsercao = new System.Windows.Forms.TextBox();
            this.btnInserirElemento = new System.Windows.Forms.Button();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.btnOperacoes = new System.Windows.Forms.Button();
            this.btbDesalocarMatriz = new System.Windows.Forms.Button();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.btnCelulasGuardadas = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numColunaPesquisa = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numLinhaPesquisa = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numColunaRemocao = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numLinhaRemocao = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoverCelula = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorSoma = new System.Windows.Forms.TextBox();
            this.numColunaSoma = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrizEsparsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).BeginInit();
            this.panelGerarMatriz.SuspendLayout();
            this.panelInserirElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaInsercao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaInsercao)).BeginInit();
            this.panelOpcoes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaRemocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaRemocao)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaSoma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatrizEsparsa
            // 
            this.dgMatrizEsparsa.AllowUserToAddRows = false;
            this.dgMatrizEsparsa.AllowUserToDeleteRows = false;
            this.dgMatrizEsparsa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMatrizEsparsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrizEsparsa.Location = new System.Drawing.Point(12, 103);
            this.dgMatrizEsparsa.Name = "dgMatrizEsparsa";
            this.dgMatrizEsparsa.ReadOnly = true;
            this.dgMatrizEsparsa.Size = new System.Drawing.Size(1338, 260);
            this.dgMatrizEsparsa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linhas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colunas:";
            // 
            // btnCriarMatrizEsparsa
            // 
            this.btnCriarMatrizEsparsa.Location = new System.Drawing.Point(7, 55);
            this.btnCriarMatrizEsparsa.Name = "btnCriarMatrizEsparsa";
            this.btnCriarMatrizEsparsa.Size = new System.Drawing.Size(119, 21);
            this.btnCriarMatrizEsparsa.TabIndex = 8;
            this.btnCriarMatrizEsparsa.Text = "Criar Matriz Esparsa";
            this.btnCriarMatrizEsparsa.UseVisualStyleBackColor = true;
            this.btnCriarMatrizEsparsa.Click += new System.EventHandler(this.btnCriarMatrizEsparsa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt files|*txt";
            // 
            // numLinhas
            // 
            this.numLinhas.Location = new System.Drawing.Point(80, 3);
            this.numLinhas.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.numLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLinhas.Name = "numLinhas";
            this.numLinhas.Size = new System.Drawing.Size(46, 20);
            this.numLinhas.TabIndex = 11;
            this.numLinhas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numColunas
            // 
            this.numColunas.Location = new System.Drawing.Point(80, 29);
            this.numColunas.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.numColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColunas.Name = "numColunas";
            this.numColunas.Size = new System.Drawing.Size(46, 20);
            this.numColunas.TabIndex = 12;
            this.numColunas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelGerarMatriz
            // 
            this.panelGerarMatriz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGerarMatriz.Controls.Add(this.btnCriarMatrizEsparsa);
            this.panelGerarMatriz.Controls.Add(this.label2);
            this.panelGerarMatriz.Controls.Add(this.label3);
            this.panelGerarMatriz.Controls.Add(this.numLinhas);
            this.panelGerarMatriz.Controls.Add(this.numColunas);
            this.panelGerarMatriz.Location = new System.Drawing.Point(12, 12);
            this.panelGerarMatriz.Name = "panelGerarMatriz";
            this.panelGerarMatriz.Size = new System.Drawing.Size(136, 85);
            this.panelGerarMatriz.TabIndex = 21;
            // 
            // panelInserirElemento
            // 
            this.panelInserirElemento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInserirElemento.Controls.Add(this.numColunaInsercao);
            this.panelInserirElemento.Controls.Add(this.label6);
            this.panelInserirElemento.Controls.Add(this.numLinhaInsercao);
            this.panelInserirElemento.Controls.Add(this.label5);
            this.panelInserirElemento.Controls.Add(this.label4);
            this.panelInserirElemento.Controls.Add(this.txtElementoInsercao);
            this.panelInserirElemento.Controls.Add(this.btnInserirElemento);
            this.panelInserirElemento.Location = new System.Drawing.Point(154, 12);
            this.panelInserirElemento.Name = "panelInserirElemento";
            this.panelInserirElemento.Size = new System.Drawing.Size(193, 85);
            this.panelInserirElemento.TabIndex = 22;
            // 
            // numColunaInsercao
            // 
            this.numColunaInsercao.Location = new System.Drawing.Point(150, 29);
            this.numColunaInsercao.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numColunaInsercao.Name = "numColunaInsercao";
            this.numColunaInsercao.Size = new System.Drawing.Size(33, 20);
            this.numColunaInsercao.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Coluna:";
            // 
            // numLinhaInsercao
            // 
            this.numLinhaInsercao.Location = new System.Drawing.Point(52, 29);
            this.numLinhaInsercao.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numLinhaInsercao.Name = "numLinhaInsercao";
            this.numLinhaInsercao.Size = new System.Drawing.Size(33, 20);
            this.numLinhaInsercao.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Linha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Número:";
            // 
            // txtElementoInsercao
            // 
            this.txtElementoInsercao.Location = new System.Drawing.Point(63, 5);
            this.txtElementoInsercao.Name = "txtElementoInsercao";
            this.txtElementoInsercao.Size = new System.Drawing.Size(120, 20);
            this.txtElementoInsercao.TabIndex = 22;
            // 
            // btnInserirElemento
            // 
            this.btnInserirElemento.Location = new System.Drawing.Point(1, 55);
            this.btnInserirElemento.Name = "btnInserirElemento";
            this.btnInserirElemento.Size = new System.Drawing.Size(185, 21);
            this.btnInserirElemento.TabIndex = 21;
            this.btnInserirElemento.Text = "Inserir elemento";
            this.btnInserirElemento.UseVisualStyleBackColor = true;
            this.btnInserirElemento.Click += new System.EventHandler(this.btnInserirElemento_Click);
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOpcoes.Controls.Add(this.btnOperacoes);
            this.panelOpcoes.Controls.Add(this.btbDesalocarMatriz);
            this.panelOpcoes.Controls.Add(this.btnLerArquivo);
            this.panelOpcoes.Controls.Add(this.btnCelulasGuardadas);
            this.panelOpcoes.Location = new System.Drawing.Point(549, 12);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(267, 85);
            this.panelOpcoes.TabIndex = 23;
            // 
            // btnOperacoes
            // 
            this.btnOperacoes.Location = new System.Drawing.Point(116, 7);
            this.btnOperacoes.Name = "btnOperacoes";
            this.btnOperacoes.Size = new System.Drawing.Size(144, 33);
            this.btnOperacoes.TabIndex = 21;
            this.btnOperacoes.Text = "Operações com matrizes";
            this.btnOperacoes.UseVisualStyleBackColor = true;
            this.btnOperacoes.Click += new System.EventHandler(this.btnOperacoes_Click);
            // 
            // btbDesalocarMatriz
            // 
            this.btbDesalocarMatriz.Location = new System.Drawing.Point(116, 43);
            this.btbDesalocarMatriz.Name = "btbDesalocarMatriz";
            this.btbDesalocarMatriz.Size = new System.Drawing.Size(144, 33);
            this.btbDesalocarMatriz.TabIndex = 20;
            this.btbDesalocarMatriz.Text = "Desalocar matriz";
            this.btbDesalocarMatriz.UseVisualStyleBackColor = true;
            this.btbDesalocarMatriz.Click += new System.EventHandler(this.btnDesalocarMatriz_Click);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(3, 5);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(107, 34);
            this.btnLerArquivo.TabIndex = 18;
            this.btnLerArquivo.Text = "Ler de Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnCelulasGuardadas
            // 
            this.btnCelulasGuardadas.Location = new System.Drawing.Point(3, 43);
            this.btnCelulasGuardadas.Name = "btnCelulasGuardadas";
            this.btnCelulasGuardadas.Size = new System.Drawing.Size(107, 33);
            this.btnCelulasGuardadas.TabIndex = 17;
            this.btnCelulasGuardadas.Text = "Células guardadas";
            this.btnCelulasGuardadas.UseVisualStyleBackColor = true;
            this.btnCelulasGuardadas.Click += new System.EventHandler(this.btnCelulasGuardadas_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.numColunaPesquisa);
            this.panel4.Controls.Add(this.btnPesquisar);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.numLinhaPesquisa);
            this.panel4.Location = new System.Drawing.Point(822, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 85);
            this.panel4.TabIndex = 24;
            // 
            // numColunaPesquisa
            // 
            this.numColunaPesquisa.Location = new System.Drawing.Point(151, 6);
            this.numColunaPesquisa.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numColunaPesquisa.Name = "numColunaPesquisa";
            this.numColunaPesquisa.Size = new System.Drawing.Size(33, 20);
            this.numColunaPesquisa.TabIndex = 31;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(4, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(181, 45);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Coluna:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Linha:";
            // 
            // numLinhaPesquisa
            // 
            this.numLinhaPesquisa.Location = new System.Drawing.Point(53, 6);
            this.numLinhaPesquisa.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numLinhaPesquisa.Name = "numLinhaPesquisa";
            this.numLinhaPesquisa.Size = new System.Drawing.Size(33, 20);
            this.numLinhaPesquisa.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numColunaRemocao);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numLinhaRemocao);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnRemoverCelula);
            this.panel1.Location = new System.Drawing.Point(353, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 85);
            this.panel1.TabIndex = 28;
            // 
            // numColunaRemocao
            // 
            this.numColunaRemocao.Location = new System.Drawing.Point(150, 8);
            this.numColunaRemocao.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numColunaRemocao.Name = "numColunaRemocao";
            this.numColunaRemocao.Size = new System.Drawing.Size(33, 20);
            this.numColunaRemocao.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Coluna:";
            // 
            // numLinhaRemocao
            // 
            this.numLinhaRemocao.Location = new System.Drawing.Point(53, 7);
            this.numLinhaRemocao.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numLinhaRemocao.Name = "numLinhaRemocao";
            this.numLinhaRemocao.Size = new System.Drawing.Size(33, 20);
            this.numLinhaRemocao.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Linha:";
            // 
            // btnRemoverCelula
            // 
            this.btnRemoverCelula.Location = new System.Drawing.Point(3, 34);
            this.btnRemoverCelula.Name = "btnRemoverCelula";
            this.btnRemoverCelula.Size = new System.Drawing.Size(180, 48);
            this.btnRemoverCelula.TabIndex = 21;
            this.btnRemoverCelula.Text = "Remover célula";
            this.btnRemoverCelula.UseVisualStyleBackColor = true;
            this.btnRemoverCelula.Click += new System.EventHandler(this.btnRemoverCelula_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(3, 7);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 29);
            this.btnSobre.TabIndex = 29;
            this.btnSobre.Text = "Autores";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnGitHub);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Location = new System.Drawing.Point(1258, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 80);
            this.panel2.TabIndex = 32;
            // 
            // btnGitHub
            // 
            this.btnGitHub.Location = new System.Drawing.Point(3, 41);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(75, 31);
            this.btnGitHub.TabIndex = 30;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtValorSoma);
            this.panel3.Controls.Add(this.numColunaSoma);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnSomar);
            this.panel3.Location = new System.Drawing.Point(1020, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 80);
            this.panel3.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Número:";
            // 
            // txtValorSoma
            // 
            this.txtValorSoma.Location = new System.Drawing.Point(63, 29);
            this.txtValorSoma.Name = "txtValorSoma";
            this.txtValorSoma.Size = new System.Drawing.Size(64, 20);
            this.txtValorSoma.TabIndex = 33;
            // 
            // numColunaSoma
            // 
            this.numColunaSoma.Location = new System.Drawing.Point(63, 5);
            this.numColunaSoma.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numColunaSoma.Name = "numColunaSoma";
            this.numColunaSoma.Size = new System.Drawing.Size(33, 20);
            this.numColunaSoma.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Coluna:";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(2, 52);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(158, 21);
            this.btnSomar.TabIndex = 30;
            this.btnSomar.Text = "Somar na coluna";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 375);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelOpcoes);
            this.Controls.Add(this.panelInserirElemento);
            this.Controls.Add(this.panelGerarMatriz);
            this.Controls.Add(this.dgMatrizEsparsa);
            this.Name = "frmMatrizEsparsa";
            this.ShowIcon = false;
            this.Text = "Matriz Esparsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMatrizEsparsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrizEsparsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColunas)).EndInit();
            this.panelGerarMatriz.ResumeLayout(false);
            this.panelGerarMatriz.PerformLayout();
            this.panelInserirElemento.ResumeLayout(false);
            this.panelInserirElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaInsercao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaInsercao)).EndInit();
            this.panelOpcoes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaRemocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLinhaRemocao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColunaSoma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgMatrizEsparsa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarMatrizEsparsa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numLinhas;
        private System.Windows.Forms.NumericUpDown numColunas;
        private System.Windows.Forms.Panel panelGerarMatriz;
        private System.Windows.Forms.Panel panelInserirElemento;
        private System.Windows.Forms.NumericUpDown numColunaInsercao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numLinhaInsercao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElementoInsercao;
        private System.Windows.Forms.Button btnInserirElemento;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.Button btnCelulasGuardadas;
        private System.Windows.Forms.Button btbDesalocarMatriz;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numColunaPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numLinhaPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numColunaRemocao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numLinhaRemocao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoverCelula;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnOperacoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorSoma;
        private System.Windows.Forms.NumericUpDown numColunaSoma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSomar;
    }
}

