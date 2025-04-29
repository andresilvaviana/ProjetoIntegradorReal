using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetoIntegradorReal
{
    public partial class Entrar: Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            foreach (Usuario user in Usuario.ListaUsuario)
            {
                if ((user.Nome == txtNome.Text) && (user.Senha == txtSenha.Text))
                {
                    MessageBox.Show(
                        "Usuario Autenticado com Sucesso!",
                        "Sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );

                    MenuPrincipal form = new MenuPrincipal();
                    form.ShowDialog();

                    return;
                }
            }
            MessageBox.Show("Usuario Não Autenticado!","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);

            txtNome.Clear();
            txtSenha.Clear();
            return;

        }

        private void Entrar_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Nome = "admin";
            us.Senha = "admin";


            Usuario us2 = new Usuario();
            us2.Codigo = 137;
            us2.Nome = "theo";
            us2.Senha = "0800";


            Usuario us3 = new Usuario();
            us3.Codigo = 002;
            us3.Nome = "andre";
            us3.Senha = "1995";


            Usuario us4 = new Usuario();
            us4.Codigo = 003;
            us4.Nome = "kauany";
            us4.Senha = "2504";


            Usuario us5 = new Usuario();
            us5.Codigo = 004;
            us5.Nome = "jessica";
            us5.Senha = "1234";

            Usuario.ListaUsuario.Add(us);
            Usuario.ListaUsuario.Add(us2);
            Usuario.ListaUsuario.Add(us3);
            Usuario.ListaUsuario.Add(us4);
            Usuario.ListaUsuario.Add(us5);
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
