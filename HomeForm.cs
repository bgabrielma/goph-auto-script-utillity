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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            configure();
        }
        private void configure()
        {
            Text = $"Home - {Settings.Default.nickname}";
        }
    }
}
