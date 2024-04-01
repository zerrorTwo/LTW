using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class Login : Form
    {
        int ktra;
        public Login()
        {
            InitializeComponent();
            ktra = 0;
            panelLg.BaseColor = Color.FromArgb(140, Color.Black);
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ktra == 0)
            {
                panelLg.Height += 50;
                btnLogin.Visible = false;
                ktra++;
                tBComfirmPass.Visible = true;
                btnRegister.Visible = false;
                btnComfimRegis.Visible = true;
                lbRegister.Visible = true;
            }
        }

        private void gunaTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelLg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tBUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            panelLg.Height -= 50;
            tBComfirmPass.Visible = false;
            tBUserName.Text = "";
            tBPassword.Text = "";
            btnComfimRegis.Visible = false;
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            lbRegister.Visible= false;
            ktra = 0;
        }
    }
}
