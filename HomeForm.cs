using DOPScript.config;
using DOPScript.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

            labelVersion.Text = $"v{Utils.getProgramAssembleVersion()}";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            configure();
        }
        private void configure()
        {
            nickname.Text = Settings.Default.nickname;
        }
        public void prepareScript(StreamReader streamReader)
        {
            Script.Reset();
            richScriptBoxContainer.Text = "";

            string contentLine = null;
            Script.ScriptTopic scriptTopic = new Script.ScriptTopic();

            while ((contentLine = streamReader.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(contentLine))
                {
                    continue;
                }

                if (ScriptAttributes.TOPIC_PATTERN.IsMatch(contentLine))
                {
                    contentLine = contentLine.Replace("[topico]", "").Trim();

                    Script.createTopic(scriptTopic = new Script.ScriptTopic(contentLine));
                    addLineToRichScriptBox($"\n{contentLine}\n\n");
                }
                else if (ScriptAttributes.LINE_PATTERN.IsMatch(contentLine))
                {
                    contentLine = contentLine.Replace(">", "").Trim();

                    scriptTopic.addLine(contentLine);
                    addLineToRichScriptBox($"{contentLine}\n");
                }
                else if (ScriptAttributes.IDENTIFICATION_PATTERN.IsMatch(contentLine))
                {
                    contentLine = contentLine.Replace("[script]", "").Trim();

                    ResetText();
                    Text = $"Script | {contentLine}";
                }
                else if (ScriptAttributes.COMMENT_PATTERN.IsMatch(contentLine))
                {
                    addLineToRichScriptBox(contentLine);
                }
                else
                {
                    MetroMessageBox.Show(this, "Verifique a estrutura do script e tente novamente.", "Ocorreu um erro ao importar script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Text = "Script | a aguadar...";
                    streamReader.Close();
                    return;
                }
            }
            fillMetroTopicBox();
            streamReader.Close();
        }

        public void fillMetroTopicBox()
        {
            var dicScriptTopics = Script.scriptTopics.ToDictionary(x => x.key, y => y.topicTitle);
            metroTopicComboBox.DataSource = new BindingSource(dicScriptTopics, null);
            metroTopicComboBox.DisplayMember = "Value";
            metroTopicComboBox.ValueMember = "Key";
        }

        public void addLineToRichScriptBox(string line)
        {
            richScriptBoxContainer.Text += $"{line}\n";
        }

        private void uploadScript_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.prepareScript(new StreamReader(fileDialog.FileName, Encoding.GetEncoding("utf-8")));
            }
        }
    }
}
