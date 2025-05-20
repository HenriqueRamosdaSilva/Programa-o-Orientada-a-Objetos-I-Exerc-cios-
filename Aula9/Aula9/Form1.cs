using System;
using System.Windows.Forms;
using Npgsql;


namespace Aula9
{


    public partial class Form1 : Form
    {
        private string connString =
        "Host=localhost;Username=postgres;Password=PostgreSQL123;Database=Aula9";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome.");
                return;
            }
            using (var conn = new
            NpgsqlConnection(connString))
            {
                conn.Open();
                string insertSql = "INSERT INTO usuarios(nome) VALUES(@nome)";
                using (var cmd = new
                NpgsqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("nome",
                    nome);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Nome salvo com sucesso!");
            txtNome.Clear();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();
            using (var conn = new
            NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT nome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql,
                conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listUsuarios.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
