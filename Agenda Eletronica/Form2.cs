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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda_Pessoal;Data Source=DESKTOP-6ACL969\\SQLEXPRESS");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Agenda_Pessoal;Data Source=DESKTOP-6ACL969\\SQLEXPRESS");
            SqlCommand instrucoes = new SqlCommand("insert into contatos(nome,endereço,telefone,email) values(@nome, @endereço, @telefone, @email)", conexao);
            instrucoes.Parameters.Add("@nome", SqlDbType.VarChar).Value = textnome.Text;
            instrucoes.Parameters.Add("@endereço", SqlDbType.VarChar).Value = textendereco.Text;
            instrucoes.Parameters.Add("@telefone", SqlDbType.Int).Value = texttelefone.Text;
            instrucoes.Parameters.Add("@email", SqlDbType.VarChar).Value = textemail.Text;

            try
            {
                conexao.Open();
                instrucoes.ExecuteNonQuery();
                MessageBox.Show("Contatos Salvos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void texttelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}