using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GOPHScript.Properties;
using System.Net;
using System.IO;
using MetroFramework;

namespace DOPScript
{
    public partial class LoginForm : MetroForm
    {
        protected WebClient webClient;

        public LoginForm()
        {
            InitializeComponent();
            labelVersion.Text = $"v{Utils.getProgramAssembleVersion()}";
        } 

        private async void buttonHome_Click(object sender, EventArgs e)
        {
            buttonHome.Enabled = false;
            loader.Visible = true;

            await Utils.getHabboLogoImage(nickname.Text).ContinueWith((value) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    buttonHome.Enabled = true;
                    loader.Visible = false;

                    if (value.Result.Item2)
                    {
                        openHome(value.Result.Item1);
                    } else
                    {
                        MetroMessageBox.Show(this, "O utilizador em questão é inválido. Tente novamente", "Erro ao tentar entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
        }

        private void nickname_TextChanged(object sender, EventArgs e)
        {
            var input = (MetroTextBox)sender;
            buttonHome.Enabled = !string.IsNullOrEmpty(input.Text);
        }

        private void setParams()
        {
            Settings.Default.nickname = nickname.Text;
            Settings.Default.Save();
        }

        public void openHome(Bitmap _habboImage = null)
        {

            // Set Params
            setParams();

            // Hide LoginForm
            Hide();

            // Dispose Login Form
            new HomeForm(_habboImage).ShowDialog();
            Task.Run(() => {
                Invoke((MethodInvoker)delegate
                {
                    Dispose();
                });
            });
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
