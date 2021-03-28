﻿namespace DOPScript
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.richScriptBoxContainer = new System.Windows.Forms.RichTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureHabboImage = new System.Windows.Forms.PictureBox();
            this.nickname = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTopicComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnStart = new MetroFramework.Controls.MetroTile();
            this.btnPause = new MetroFramework.Controls.MetroTile();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.labelProgress = new MetroFramework.Controls.MetroLabel();
            this.labelTopic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.richTextTopicoAtual = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.uploadScript = new MetroFramework.Controls.MetroTile();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.scriptVelocity = new MetroFramework.Controls.MetroTextBox();
            this.timerScript = new System.Windows.Forms.Timer(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHabboImage)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // richScriptBoxContainer
            // 
            this.richScriptBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.richScriptBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richScriptBoxContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richScriptBoxContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richScriptBoxContainer.ForeColor = System.Drawing.Color.White;
            this.richScriptBoxContainer.Location = new System.Drawing.Point(0, 18);
            this.richScriptBoxContainer.Name = "richScriptBoxContainer";
            this.richScriptBoxContainer.ReadOnly = true;
            this.richScriptBoxContainer.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richScriptBoxContainer.Size = new System.Drawing.Size(633, 498);
            this.richScriptBoxContainer.TabIndex = 0;
            this.richScriptBoxContainer.Text = "";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel1.Controls.Add(this.richScriptBoxContainer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 79);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(633, 516);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel3.Controls.Add(this.metroPanel2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(951, 79);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(162, 211);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.metroPanel2.Controls.Add(this.pictureHabboImage);
            this.metroPanel2.Controls.Add(this.nickname);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 14);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(162, 215);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureHabboImage
            // 
            this.pictureHabboImage.Location = new System.Drawing.Point(28, 3);
            this.pictureHabboImage.Name = "pictureHabboImage";
            this.pictureHabboImage.Size = new System.Drawing.Size(108, 124);
            this.pictureHabboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureHabboImage.TabIndex = 3;
            this.pictureHabboImage.TabStop = false;
            // 
            // nickname
            // 
            this.nickname.ActiveControl = null;
            this.nickname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nickname.Location = new System.Drawing.Point(23, 133);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(119, 47);
            this.nickname.Style = MetroFramework.MetroColorStyle.Blue;
            this.nickname.TabIndex = 2;
            this.nickname.Text = "Xx.Mitomasfsd.Xxxx";
            this.nickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nickname.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nickname.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.nickname.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.nickname.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(698, 274);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Tópicos";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTopicComboBox
            // 
            this.metroTopicComboBox.FormattingEnabled = true;
            this.metroTopicComboBox.ItemHeight = 23;
            this.metroTopicComboBox.Location = new System.Drawing.Point(698, 314);
            this.metroTopicComboBox.Name = "metroTopicComboBox";
            this.metroTopicComboBox.Size = new System.Drawing.Size(415, 29);
            this.metroTopicComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTopicComboBox.TabIndex = 7;
            this.metroTopicComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTopicComboBox.UseSelectable = true;
            this.metroTopicComboBox.UseStyleColors = true;
            this.metroTopicComboBox.SelectedIndexChanged += new System.EventHandler(this.metroTopicComboBox_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.ActiveControl = null;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(698, 372);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 88);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnStart.TabIndex = 8;
            this.btnStart.TileImage = ((System.Drawing.Image)(resources.GetObject("btnStart.TileImage")));
            this.btnStart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.UseTileImage = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.ActiveControl = null;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(698, 500);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(111, 92);
            this.btnPause.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPause.TabIndex = 9;
            this.btnPause.TileImage = ((System.Drawing.Image)(resources.GetObject("btnPause.TileImage")));
            this.btnPause.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPause.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPause.UseSelectable = true;
            this.btnPause.UseStyleColors = true;
            this.btnPause.UseTileImage = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.metroPanel4.Controls.Add(this.labelProgress);
            this.metroPanel4.Controls.Add(this.labelTopic);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.Controls.Add(this.richTextTopicoAtual);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 16);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(258, 208);
            this.metroPanel4.TabIndex = 10;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // labelProgress
            // 
            this.labelProgress.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelProgress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelProgress.Location = new System.Drawing.Point(146, 156);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(92, 36);
            this.labelProgress.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelProgress.TabIndex = 8;
            this.labelProgress.Text = "--";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProgress.UseCustomBackColor = true;
            this.labelProgress.UseStyleColors = true;
            // 
            // labelTopic
            // 
            this.labelTopic.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTopic.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelTopic.Location = new System.Drawing.Point(19, 156);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(68, 36);
            this.labelTopic.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "--";
            this.labelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopic.UseCustomBackColor = true;
            this.labelTopic.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(146, 125);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Progresso";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(19, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Tópico";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // richTextTopicoAtual
            // 
            this.richTextTopicoAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.richTextTopicoAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextTopicoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.richTextTopicoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.richTextTopicoAtual.Location = new System.Drawing.Point(19, 61);
            this.richTextTopicoAtual.Name = "richTextTopicoAtual";
            this.richTextTopicoAtual.ReadOnly = true;
            this.richTextTopicoAtual.Size = new System.Drawing.Size(223, 61);
            this.richTextTopicoAtual.TabIndex = 3;
            this.richTextTopicoAtual.Text = "--";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(19, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tópico atual";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroPanel5.Controls.Add(this.metroPanel4);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(855, 372);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(258, 223);
            this.metroPanel5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroPanel5.TabIndex = 11;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // uploadScript
            // 
            this.uploadScript.ActiveControl = null;
            this.uploadScript.Location = new System.Drawing.Point(698, 79);
            this.uploadScript.Name = "uploadScript";
            this.uploadScript.Size = new System.Drawing.Size(98, 85);
            this.uploadScript.Style = MetroFramework.MetroColorStyle.Silver;
            this.uploadScript.TabIndex = 12;
            this.uploadScript.TileImage = ((System.Drawing.Image)(resources.GetObject("uploadScript.TileImage")));
            this.uploadScript.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadScript.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.uploadScript.UseSelectable = true;
            this.uploadScript.UseStyleColors = true;
            this.uploadScript.UseTileImage = true;
            this.uploadScript.Click += new System.EventHandler(this.uploadScript_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "|*.txt";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(1071, 599);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 19);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "v0.0.0";
            this.labelVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(698, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(205, 25);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Velocidade (segundos)";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // scriptVelocity
            // 
            // 
            // 
            // 
            this.scriptVelocity.CustomButton.Image = null;
            this.scriptVelocity.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.scriptVelocity.CustomButton.Name = "";
            this.scriptVelocity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.scriptVelocity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.scriptVelocity.CustomButton.TabIndex = 1;
            this.scriptVelocity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.scriptVelocity.CustomButton.UseSelectable = true;
            this.scriptVelocity.CustomButton.Visible = false;
            this.scriptVelocity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.scriptVelocity.Lines = new string[0];
            this.scriptVelocity.Location = new System.Drawing.Point(700, 216);
            this.scriptVelocity.MaxLength = 32767;
            this.scriptVelocity.Name = "scriptVelocity";
            this.scriptVelocity.PasswordChar = '\0';
            this.scriptVelocity.PromptText = "Ex: 4,5";
            this.scriptVelocity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scriptVelocity.SelectedText = "";
            this.scriptVelocity.SelectionLength = 0;
            this.scriptVelocity.SelectionStart = 0;
            this.scriptVelocity.ShortcutsEnabled = true;
            this.scriptVelocity.Size = new System.Drawing.Size(74, 23);
            this.scriptVelocity.Style = MetroFramework.MetroColorStyle.Blue;
            this.scriptVelocity.TabIndex = 15;
            this.scriptVelocity.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scriptVelocity.UseSelectable = true;
            this.scriptVelocity.UseStyleColors = true;
            this.scriptVelocity.WaterMark = "Ex: 4,5";
            this.scriptVelocity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.scriptVelocity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.scriptVelocity.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // timerScript
            // 
            this.timerScript.Tick += new System.EventHandler(this.timerScript_Tick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(780, 219);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 15);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "De 4 até 10 segundos";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.WrapToLine = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(780, 253);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 15);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Tecla de Pausa (ESC)";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.WrapToLine = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 628);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.scriptVelocity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.uploadScript);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.metroTopicComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Script | a aguardar...";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHabboImage)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richScriptBoxContainer;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureHabboImage;
        private MetroFramework.Controls.MetroTile nickname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroTopicComboBox;
        private MetroFramework.Controls.MetroTile btnStart;
        private MetroFramework.Controls.MetroTile btnPause;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.RichTextBox richTextTopicoAtual;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroTile uploadScript;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Controls.MetroLabel labelVersion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox scriptVelocity;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel labelProgress;
        private MetroFramework.Controls.MetroLabel labelTopic;
        private System.Windows.Forms.Timer timerScript;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}