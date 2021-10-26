using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda_Eletronica
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda_Pessoal;Data Source=DESKTOP-6ACL969\\SQLEXPRESS");
                SqlDataAdapter instrucao = new SqlDataAdapter("select * from contatos where nome like '" + textBox1.Text + " % '", conexao);

                DataTable tabela = new DataTable();
                instrucao.Fill(tabela);
                tabela.Columns[0].ColumnName = "ID";
                tabela.Columns[1].ColumnName = "nome";
                tabela.Columns[2].ColumnName = "endereço";
                tabela.Columns[3].ColumnName = "telefone";
             

                dataGridView1.DataSource = tabela;

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
