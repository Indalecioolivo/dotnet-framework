using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Livro umLivro = new Livro();

            umLivro.setTitulo(inputTitulo.Text);
            umLivro.setAutor(inputAutor.Text);
            umLivro.setEditora(inputEditora.Text);
            umLivro.setAnoEdicao(inputAnoEdicao.Text);
            umLivro.setLocal(inputLocal.Text);

            LivroBLL.validarDados(umLivro);

            if (Error.getError())
            {
                MessageBox.Show(Error.getMens());
            }
            else
            {
                MessageBox.Show("Livro Cadastrado com sucesso.");
                inputTitulo.Text = "";
                inputAutor.Text = "";
                inputEditora.Text = "";
                inputAnoEdicao.Text = "";
                inputLocal.Text = "";

                umLivro.resetPropriedades();

            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Livro umLivro = new Livro();
            inputTitulo.Text = "";
            inputAutor.Text = "";
            inputEditora.Text = "";
            inputAnoEdicao.Text = "";
            inputLocal.Text = "";

            umLivro.resetPropriedades();
        }
    }
}
