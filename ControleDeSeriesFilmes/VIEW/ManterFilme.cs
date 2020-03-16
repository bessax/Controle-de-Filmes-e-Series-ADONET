using ControleDeSeriesFilmes.CONTROLLER;
using ControleDeSeriesFilmes.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeSeriesFilmes.VIEW
{
    public partial class ManterFilme : Form
    {
        FrmFilmes formfilmes;
        Filme filme;
        int tipo;

        public ManterFilme()
        {
            InitializeComponent();
        }

        public ManterFilme(int tipo, FrmFilmes formfilmes,Object filme)
        {
            
            InitializeComponent();

            // Desabilitar o campo código.
            this.txtCodigo.Enabled = false;

            //Para saber se é update ou insert
            this.tipo = tipo;

            // Os dados do filme
            this.filme = (Filme) filme;

            //Refereência a tela anterior;
            this.formfilmes = formfilmes;


            if (tipo == 1)
            {
                this.Text += " CADASTRAR FILME]";               
                
            }
            else if(tipo==2)
            {
                this.Text += " ATUALIZAR FILME]";
                this.btnSalvar.Text = "Update";
            }
            else
            {
                this.Text += " DELETAR FILME]";
                this.btnSalvar.Text = "Deletar";
            }
            
           
        }

        private void ManterFilme_Load(object sender, EventArgs e)
        {
            if ((this.tipo == 2) || (this.tipo == 3))
            {
                txtNome.Text = this.filme.Nome;
                txtCodigo.Text = Convert.ToString(this.filme.Id);
                txtDiretor.Text = this.filme.Diretor;
                txtEstudio.Text = this.filme.Estudio;
                txtClass.Text = this.filme.Classificacao;
                txtDuracao.Text = Convert.ToString(this.filme.Duracao);
            }
           

        } 

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.tipo == 1)
            {
                try
                {
                    if (Controller.InsertFilme(txtNome.Text, txtDiretor.Text, Convert.ToInt32(txtDuracao.Text), txtClass.Text, txtEstudio.Text) == 1)
                    {
                        MessageBox.Show("Filme Inserido com sucesso.");
                        formfilmes.CarregarGrid();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro .:" + ex.Message);
                }
            }
            else if (this.tipo == 2)
            {
                try
                {
                    carregarDadosDoFilme();

                    if (Controller.UpdateFilme(this.filme) == 1)
                    {
                        MessageBox.Show("Filme Atualizado com sucesso.");
                        this.formfilmes.CarregarGrid();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro .:" + ex.Message);
                }

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        carregarDadosDoFilme();
                        if (Controller.DeleteFilme(this.filme.Id) == 1)
                        {
                            MessageBox.Show("Filme Deletado com sucesso.");
                            this.formfilmes.CarregarGrid();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro .:" + ex.Message);
                    }
                }

                this.Close();
            }
        }

        private void carregarDadosDoFilme()
        {
            this.filme.Nome = txtNome.Text;
            this.filme.Id = Convert.ToInt32(txtCodigo.Text);
            this.filme.Diretor = txtDiretor.Text;
            this.filme.Estudio = txtEstudio.Text;
            this.filme.Classificacao = txtClass.Text;
            this.filme.Duracao = Convert.ToInt32(txtDuracao.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
