using DOPScript.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DOPScript
{
    public partial class HomeForm : MetroForm
    {
        private Bitmap habboImage;

        public HomeForm(Bitmap habboImage)
        {
            InitializeComponent();
            this.habboImage = habboImage;

            // Update habbo image component
            pictureHabboImage.Image = habboImage;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            configure();
        }
        private void configure()
        {
            Text = $"DOP | Militar {Settings.Default.nickname}";
            nickname.Text = Settings.Default.nickname;
        }
    }
}
