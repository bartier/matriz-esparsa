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
            this.btnCriarMatriz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMatrizEsparsa = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrizEsparsa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarMatriz
            // 
            this.btnCriarMatriz.Location = new System.Drawing.Point(12, 36);
            this.btnCriarMatriz.Name = "btnCriarMatriz";
            this.btnCriarMatriz.Size = new System.Drawing.Size(89, 23);
            this.btnCriarMatriz.TabIndex = 0;
            this.btnCriarMatriz.Text = "Criar matriz";
            this.btnCriarMatriz.UseVisualStyleBackColor = true;
            this.btnCriarMatriz.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarMatrizToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // criarMatrizToolStripMenuItem
            // 
            this.criarMatrizToolStripMenuItem.Name = "criarMatrizToolStripMenuItem";
            this.criarMatrizToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.criarMatrizToolStripMenuItem.Text = "Criar matriz";
            this.criarMatrizToolStripMenuItem.Click += new System.EventHandler(this.btnCriarMatriz_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // dgMatrizEsparsa
            // 
            this.dgMatrizEsparsa.AllowUserToAddRows = false;
            this.dgMatrizEsparsa.AllowUserToDeleteRows = false;
            this.dgMatrizEsparsa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMatrizEsparsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrizEsparsa.Location = new System.Drawing.Point(12, 65);
            this.dgMatrizEsparsa.Name = "dgMatrizEsparsa";
            this.dgMatrizEsparsa.ReadOnly = true;
            this.dgMatrizEsparsa.Size = new System.Drawing.Size(399, 235);
            this.dgMatrizEsparsa.TabIndex = 2;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 312);
            this.Controls.Add(this.dgMatrizEsparsa);
            this.Controls.Add(this.btnCriarMatriz);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMatrizEsparsa";
            this.ShowIcon = false;
            this.Text = "Matriz Esparsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrizEsparsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarMatriz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgMatrizEsparsa;
        private System.Windows.Forms.ToolStripMenuItem criarMatrizToolStripMenuItem;
    }
}

