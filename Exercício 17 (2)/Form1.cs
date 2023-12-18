using System.Drawing.Text;

namespace Exercício_17__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string PreencheuNome = "";
            string PreencheuEmail = "";
            string PreencheuPass = "";
            if (txtNome.Text == "") PreencheuNome = "Nome ";
            if (txtEmail.Text == "") PreencheuEmail = "Email ";
            if (txtPassword.Text == "") PreencheuPass = "Password ";
            if (PreencheuNome + PreencheuEmail + PreencheuPass == "")
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                Utilizador.AdicionarRegisto(nome,email,password);
                MessageBox.Show("Utilizador " + nome + " registado com sucesso");
                txtNome.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
            }
            else
                MessageBox.Show("Não preencheu " + PreencheuNome + PreencheuEmail + PreencheuPass,"",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
        }

        private void btnVerRegistos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}