using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WF_ModerUI
{
    public partial class Login : Form
    {
        Thread nt;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }


        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "moura" && txtSenha.Text == "123")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                return;
            }
            else
            {
                MessageBox.Show("Login ou Senha inválido!");
            }

        }

        private void novoForm()
        {
            Application.Run(new FormMenu());
        }
    }
}
