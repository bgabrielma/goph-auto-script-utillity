using DOPScript.config;
using DOPScript.Properties;
using MetroFramework;
using MetroFramework.Controls;
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
        private float currentScriptVelocityState = Utils.MIN_SPEED;

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
        private void Reset()
        {
            // Clear components
            metroTopicComboBox.DataSource = null;
            metroTopicComboBox.Items.Clear();

            richScriptBoxContainer.Text = "";

            ResetText();
            Text = "Script | a aguardar...";

            // Reset script
            Script.Reset();
        }
        private void ResetTopic()
        {
            // Reset current script line
            Script.CURRENT_LINE = 0;
            Script.SHOULD_SEND_TITLE_PHRASE = true;
        }
        public void prepareScript(StreamReader streamReader)
        {
            Reset();

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
                    Script.createTopic(scriptTopic = new Script.ScriptTopic(contentLine.Replace("[topico]", "").Trim()));
                }
                else if (ScriptAttributes.LINE_PATTERN.IsMatch(contentLine))
                {
                    scriptTopic.addLine(contentLine.Replace(">", "").Trim());
                }
                else if (ScriptAttributes.IDENTIFICATION_PATTERN.IsMatch(contentLine))
                {
                    contentLine = contentLine.Replace("[script]", "").Trim();

                    ResetText();
                    Text = $"Script | {contentLine}";
                }
                else if (!ScriptAttributes.COMMENT_PATTERN.IsMatch(contentLine))
                {
                    MetroMessageBox.Show(this, "Verifique a estrutura do script e tente novamente.", "Ocorreu um erro ao importar script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    streamReader.Close();

                    Reset();
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


            if (metroTopicComboBox.Items.Count > 0)
            {
                metroTopicComboBox.SelectedIndex = 0;
                configScriptPainelInformations();
            }
        }

        public void configScriptPainelInformations()
        {
            string selectedItemTextValue = metroTopicComboBox.GetItemText(metroTopicComboBox.SelectedItem).ToUpper();
            richTextTopicoAtual.Text = !string.IsNullOrEmpty(selectedItemTextValue) ? selectedItemTextValue : "--";
            labelTopic.Text = "" + (metroTopicComboBox.SelectedIndex + 1);
            if (string.IsNullOrEmpty(scriptVelocity.Text))
            {
                scriptVelocity.Text = "4";
            }
        }


        public void addLineToRichScriptBox(string line)
        {
            richScriptBoxContainer.Text += $"{line}\n";
        }

        public void fillRichScriptBox()
        {
            richScriptBoxContainer.Text = "";
            if (metroTopicComboBox.Items.Count > 0) 
            { 
                Script.ScriptTopic currentScriptTopic = Script.scriptTopics[metroTopicComboBox.SelectedIndex];
                if (currentScriptTopic != null)
                {
                    addLineToRichScriptBox($"\n{currentScriptTopic.topicTitle}");

                    foreach(Script.ScriptTopic.ScriptLine scriptLine in currentScriptTopic.getTopicLines())
                    {
                        addLineToRichScriptBox($"\n{scriptLine.getLine()}");
                    }
                }
            }
            updateProgress();
        }

        public void updateProgress()
        {
            Script.ScriptTopic currentScriptTopic = Script.scriptTopics[metroTopicComboBox.SelectedIndex];
            labelProgress.Text = $"{((100 / currentScriptTopic.getTopicLines().Count) * Script.CURRENT_LINE)} %";
        }

        public void handleButtonsActionState(string mode = "disabled")
        {
            if (mode == "disabled")
            {
                btnStart.Enabled = btnPause.Enabled = false;
                btnStart.Style = btnPause.Style = MetroColorStyle.Silver;
            }
            else if (mode == "enabled")
            {
                btnStart.Enabled = btnPause.Enabled = true;
                btnStart.Style = btnPause.Style = MetroColorStyle.Blue;
            }
        }

        private void uploadScript_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.prepareScript(new StreamReader(fileDialog.FileName, Encoding.GetEncoding("iso-8859-1")));
            }
        }

        private void metroTopicComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            configScriptPainelInformations();
            timerScript.Interval = (int)currentScriptVelocityState * 1000;
            fillRichScriptBox();
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Reset current script line
            ResetTopic();

            float _currentScriptVelocityState = 0f;
            MetroTextBox metroTextBox = (MetroTextBox)sender;

            if (!float.TryParse(metroTextBox.Text, out _currentScriptVelocityState))
            {
                scriptVelocity.WithError = true;
            } 
            else 
            {
                currentScriptVelocityState = _currentScriptVelocityState < Utils.MIN_SPEED ? Utils.MIN_SPEED : _currentScriptVelocityState;
                scriptVelocity.WithError = _currentScriptVelocityState < Utils.MIN_SPEED || _currentScriptVelocityState > Utils.MAX_SPEED;
            }
            timerScript.Interval = (int)currentScriptVelocityState * 1000;

            // Block start button based on this input validation
            if (Script.scriptTopics.Count > 0) 
            { 
                if (scriptVelocity.WithError)
                {
                    handleButtonsActionState();
                } else
                {
                    btnStart.Style = MetroColorStyle.Blue;
                    btnStart.Enabled = true;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (
                MetroMessageBox.Show(this, "Lembre-se de preparar o seu jogo. Deixe selecionado o balão de fala do jogo. Sempre que quiser parar o script, basta clicar no botão de parar. Mantenha sempre o jogo como foco, verificando se o seu balão de fala está selecionado e, sempre que quiser parar o script, faça-o sempre após o envio de uma frase.", $"{Settings.Default.nickname}, quase tudo pronto para começar!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                btnPause.Style = MetroColorStyle.Blue;
                btnStart.Style = MetroColorStyle.Silver;
                btnStart.Enabled = false;
                btnPause.Enabled = true;

                WindowState = FormWindowState.Minimized;
                timerScript.Enabled = true;
                timerScript.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Style = MetroColorStyle.Silver;
            btnStart.Style = MetroColorStyle.Blue;
            btnPause.Enabled = false;
            btnStart.Enabled = true;

            timerScript.Enabled = false;
            timerScript.Stop();
        }

        private void sendMessage()
        {
            Script.ScriptTopic currentScriptTopic = Script.scriptTopics[metroTopicComboBox.SelectedIndex];
            string _currentLine = string.Empty;

            if (Script.CURRENT_LINE <= currentScriptTopic.getTopicLines().Count - 1) 
            {
                if (Script.SHOULD_SEND_TITLE_PHRASE)
                {
                    _currentLine = currentScriptTopic.topicTitle;
                    Script.SHOULD_SEND_TITLE_PHRASE = false;
                }
                else
                {
                    _currentLine = currentScriptTopic.getTopicLines()[Script.CURRENT_LINE].getLine();

                    // Increment script current line
                    Script.CURRENT_LINE++;
                }

                SendKeys.Send(Utils.formatSpecialLineCharacters(_currentLine));
                SendKeys.Send("+{Enter}");
                
                // Update script topic progress
                updateProgress();
            } 
            else
            {
                btnPause.PerformClick();
                WindowState = FormWindowState.Normal;
                MetroMessageBox.Show(this, $"Parabéns {Settings.Default.nickname}, este tópico foi finalizado com sucesso! Selecione o próximo para começar.", "Tópico finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset current script line
                ResetTopic();
            }
        }

        private void timerScript_Tick(object sender, EventArgs e)
        {
            sendMessage();
        }

    }
}
