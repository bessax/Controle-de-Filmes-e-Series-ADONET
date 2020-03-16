namespace ControleDeSeriesFilmes.VIEW
{
    partial class FrmFilmes
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
            this.mnsFilmes = new System.Windows.Forms.MenuStrip();
            this.iNSERIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.stsFilmes = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.stsFilmes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsFilmes
            // 
            this.mnsFilmes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERIRToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.dELETARToolStripMenuItem,
            this.cANCELARToolStripMenuItem});
            this.mnsFilmes.Location = new System.Drawing.Point(0, 0);
            this.mnsFilmes.Name = "mnsFilmes";
            this.mnsFilmes.Size = new System.Drawing.Size(662, 24);
            this.mnsFilmes.TabIndex = 0;
            this.mnsFilmes.Text = "menuStrip1";
            // 
            // iNSERIRToolStripMenuItem
            // 
            this.iNSERIRToolStripMenuItem.Image = global::ControleDeSeriesFilmes.Properties.Resources.add2;
            this.iNSERIRToolStripMenuItem.Name = "iNSERIRToolStripMenuItem";
            this.iNSERIRToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.iNSERIRToolStripMenuItem.Text = "INSERIR";
            this.iNSERIRToolStripMenuItem.Click += new System.EventHandler(this.iNSERIRToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Image = global::ControleDeSeriesFilmes.Properties.Resources.add;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // dELETARToolStripMenuItem
            // 
            this.dELETARToolStripMenuItem.Image = global::ControleDeSeriesFilmes.Properties.Resources.delete2;
            this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
            this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dELETARToolStripMenuItem.Text = "DELETAR";
            this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
            // 
            // cANCELARToolStripMenuItem
            // 
            this.cANCELARToolStripMenuItem.Image = global::ControleDeSeriesFilmes.Properties.Resources.exit;
            this.cANCELARToolStripMenuItem.Name = "cANCELARToolStripMenuItem";
            this.cANCELARToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cANCELARToolStripMenuItem.Text = "CANCELAR";
            this.cANCELARToolStripMenuItem.Click += new System.EventHandler(this.cANCELARToolStripMenuItem_Click);
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.AllowUserToAddRows = false;
            this.dgvFilmes.AllowUserToDeleteRows = false;
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(0, 27);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.ReadOnly = true;
            this.dgvFilmes.Size = new System.Drawing.Size(661, 297);
            this.dgvFilmes.TabIndex = 1;
            // 
            // stsFilmes
            // 
            this.stsFilmes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsFilmes.Location = new System.Drawing.Point(0, 319);
            this.stsFilmes.Name = "stsFilmes";
            this.stsFilmes.Size = new System.Drawing.Size(662, 22);
            this.stsFilmes.TabIndex = 2;
            this.stsFilmes.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 341);
            this.Controls.Add(this.stsFilmes);
            this.Controls.Add(this.dgvFilmes);
            this.Controls.Add(this.mnsFilmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsFilmes;
            this.Name = "FrmFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[CADASTRO DE FILMES]";
            this.Load += new System.EventHandler(this.FrmFilmes_Load);
            this.mnsFilmes.ResumeLayout(false);
            this.mnsFilmes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.stsFilmes.ResumeLayout(false);
            this.stsFilmes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsFilmes;
        private System.Windows.Forms.ToolStripMenuItem iNSERIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.StatusStrip stsFilmes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}