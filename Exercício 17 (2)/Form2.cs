using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_17__2_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(2);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Registos.Items.Clear();
            foreach (Utilizador dados in Utilizador.listaUtilizadores)
            { 
            Registos.Items.Add(dados.Nome);
            }
        }
    }
}
