using ControleDeSeriesFilmes.CONTROLLER;
using ControleDeSeriesFilmes.MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleDeSeriesFilmes.VIEW
{
    public partial class FrmFilmes : Form
    {
        public FrmFilmes()
        {
            InitializeComponent();
        }

        private void FrmFilmes_Load(object sender, EventArgs e)
        {
            this.CarregarGrid();
        }

        private void iNSERIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManterFilme manutencao = new ManterFilme(1,this,null);
            manutencao.ShowDialog();
        }

        public void CarregarGrid()
        {
            List<Filme> filmes = Controller.GetFilmes();
            dgvFilmes.DataSource = null;
            dgvFilmes.Rows.Clear();
            dgvFilmes.DataSource = filmes;
            dgvFilmes.EndEdit();        
            toolStripStatusLabel1.Text = "Quantidade de Registros .: " + dgvFilmes.Rows.Count;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(dgvFilmes.CurrentRow.Cells[0].Value.ToString());
            filme.Diretor = dgvFilmes.CurrentRow.Cells[3].Value.ToString();
            filme.Duracao = Convert.ToInt32(dgvFilmes.CurrentRow.Cells[5].Value.ToString());
            filme.Classificacao = dgvFilmes.CurrentRow.Cells[2].Value.ToString();
            filme.Nome = dgvFilmes.CurrentRow.Cells[1].Value.ToString();
            filme.Estudio = dgvFilmes.CurrentRow.Cells[4].Value.ToString();
            ManterFilme manutencao = new ManterFilme(2, this, filme);
            manutencao.ShowDialog();
        }

        private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(dgvFilmes.CurrentRow.Cells[0].Value.ToString());
            filme.Diretor = dgvFilmes.CurrentRow.Cells[3].Value.ToString();
            filme.Duracao = Convert.ToInt32(dgvFilmes.CurrentRow.Cells[5].Value.ToString());
            filme.Classificacao = dgvFilmes.CurrentRow.Cells[2].Value.ToString();
            filme.Nome = dgvFilmes.CurrentRow.Cells[1].Value.ToString();
            filme.Estudio = dgvFilmes.CurrentRow.Cells[4].Value.ToString();
            ManterFilme manutencao = new ManterFilme(3, this, filme);
            manutencao.ShowDialog();
        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
