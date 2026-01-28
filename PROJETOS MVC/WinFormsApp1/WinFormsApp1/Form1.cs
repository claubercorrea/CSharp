using System;
using System.Collections.Generic;   
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form

    {

        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;port=3306;username=root;password=1234;database=db_agenda";
                //cria conexao com o banco
                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO contatos (nome, telefone, email) VALUES " +
                    "('" + txtNome.Text + "', '" + txtTelefone.Text
                    + "', '" + txtEmail.Text + "')";

                //comando insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();//abrir conexao
                comando.ExecuteReader();
                MessageBox.Show("Deu tudo certo, inserido");



            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
