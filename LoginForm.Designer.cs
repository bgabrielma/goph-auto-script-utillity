namespace DOPScript
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nickname = new MetroFramework.Controls.MetroTextBox();
            this.buttonHome = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.loader = new MetroFramework.Controls.MetroProgressSpinner();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(315, 277);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nickname";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // nickname
            // 
            // 
            // 
            // 
            this.nickname.CustomButton.Image = null;
            this.nickname.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.nickname.CustomButton.Name = "";
            this.nickname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.nickname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nickname.CustomButton.TabIndex = 1;
            this.nickname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nickname.CustomButton.UseSelectable = true;
            this.nickname.CustomButton.Visible = false;
            this.nickname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nickname.Lines = new string[0];
            this.nickname.Location = new System.Drawing.Point(315, 315);
            this.nickname.MaxLength = 32767;
            this.nickname.Name = "nickname";
            this.nickname.PasswordChar = '\0';
            this.nickname.PromptText = "Insira seu nickname";
            this.nickname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nickname.SelectedText = "";
            this.nickname.SelectionLength = 0;
            this.nickname.SelectionStart = 0;
            this.nickname.ShortcutsEnabled = true;
            this.nickname.Size = new System.Drawing.Size(278, 30);
            this.nickname.Style = MetroFramework.MetroColorStyle.Yellow;
            this.nickname.TabIndex = 2;
            this.nickname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nickname.UseSelectable = true;
            this.nickname.UseStyleColors = true;
            this.nickname.WaterMark = "Insira seu nickname";
            this.nickname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nickname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nickname.TextChanged += new System.EventHandler(this.nickname_TextChanged);
            // 
            // buttonHome
            // 
            this.buttonHome.ActiveControl = null;
            this.buttonHome.Enabled = false;
            this.buttonHome.Location = new System.Drawing.Point(354, 374);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(207, 65);
            this.buttonHome.Style = MetroFramework.MetroColorStyle.Yellow;
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "Entrar agora";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonHome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonHome.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.buttonHome.UseMnemonic = false;
            this.buttonHome.UseSelectable = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(788, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "GOPH© - 2021";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(26, 442);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 15);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Criado por:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 464);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(219, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = ",SrGabriel - github.com/bgabrielma";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loader
            // 
            this.loader.Location = new System.Drawing.Point(567, 390);
            this.loader.Maximum = 100;
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(32, 32);
            this.loader.Speed = 2.5F;
            this.loader.Style = MetroFramework.MetroColorStyle.Yellow;
            this.loader.TabIndex = 7;
            this.loader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loader.UseSelectable = true;
            this.loader.Value = 39;
            this.loader.Visible = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(812, 58);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 19);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v0.0.0";
            this.labelVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(655, 464);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(238, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Instituto de Sistemas e Tecnologias (IST)";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(655, 442);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(95, 15);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Propriedade de:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 500);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Grupo Organizado de Polícias Habbianas";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nickname;
        private MetroFramework.Controls.MetroTile buttonHome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroProgressSpinner loader;
        private MetroFramework.Controls.MetroLabel labelVersion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}

