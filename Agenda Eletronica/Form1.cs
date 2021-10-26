using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Eletronica
{
    public partial class Form1 : Form
    {
        bool alterado;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
        }
        private Form CadastroP;
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var resultado = MessageBox.Show(this, "Você deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }

            }
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void contatoEletrônicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroP?.Close();
            CadastroP = new Form
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            panel1.Controls.Add(CadastroP);
            CadastroP.Show();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroP?.Close();
            CadastroP = new Form2
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            panel1.Controls.Add(CadastroP);
            CadastroP.Show();

        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroP?.Close();
            CadastroP = new Form1
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            panel1.Controls.Add(CadastroP);
            CadastroP.Show();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroP?.Close();
            CadastroP = new Form4
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            panel1.Controls.Add(CadastroP);
            CadastroP.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroP?.Close();
            CadastroP = new Form5
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            panel1.Controls.Add(CadastroP);
            CadastroP.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

             private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
