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
using DOPScript.Properties;
using System.Net;
using System.IO;
using MetroFramework;

namespace DOPScript
{
    public partial class LoginForm : MetroForm
    {
        protected WebClient webClient;
        Bitmap habboImage = null;

        public LoginForm()
        {
            InitializeComponent();
        } 

        private async void buttonHome_Click(object sender, EventArgs e)
        {
            buttonHome.Enabled = false;
            loader.Visible = true;

            await getUserImage().ContinueWith((value) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    buttonHome.Enabled = true;
                    loader.Visible = false;

                    if (value.Result)
                    {
                        openHome();
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

        private async Task<bool> getUserImage()
        {
            return await Task.Run(() =>
            {
                bool isValid = true;

                webClient = new WebClient();
                webClient.Headers
                    .Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                try
                {
                    var blobImage = $"https://www.habbo.com.br/habbo-imaging/avatarimage?img_format=gif&user={nickname.Text}&action=crr=6&direction=2&head_direction=2&gesture=std&size=l&headonly=1";

                    Stream webOperations = webClient.OpenRead(blobImage);
                    habboImage = new Bitmap(webOperations);
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError && (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotFound))
                    {
                        isValid = false;
                    }
                }
                return isValid;
            });
        }

        public void openHome()
        {

            // Set Params
            setParams();

            // Hide LoginForm
            Hide();

            // Dispose Login Form
            new HomeForm(habboImage).ShowDialog();
            Task.Run(() => {
                Invoke((MethodInvoker)delegate
                {
                    Dispose();
                });
            });
        }
    }
}
