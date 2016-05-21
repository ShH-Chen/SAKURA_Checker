using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SAKURA;
using System.IO;

namespace SAKURA_Checker
{

    public partial class MainForm : Form
    {
        private appState state = appState.Idle;
        private RandGen rand;
        private Controller ctrl;
        private ControllerArgs args;
        private Stopwatch sw = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
            comboBox_target.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            updateFormEnabling();
            ctrl = new Controller();
            Random randa = new Random();
            rand = new RandGen(randa.Next(4324324), randa.Next(434343));
        }

        private void checkBox_56bitkey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_56bitkey.Checked)
            {
                byte[] key = Utils.stringToByteArray(textBox_key.Text);
                for (int i = 0; i <= 8; i++)
                {
                    key[i] = (byte)i;
                }
                textBox_key.Text = Utils.byteArrayToString(key);
            }
        }

        private void button_changekey_Click(object sender, EventArgs e)
        {
            textBox_key.Text = Utils.byteArrayToString(rand.generateKey(checkBox_56bitkey.Checked));
        }

        private void button_changeplaintext_Click(object sender, EventArgs e)
        {
            int bytenum = 16;
            if (args.Algorithm == "AES") bytenum = 16;
            else if (args.Algorithm == "DES") bytenum = 8;
            textBox_plaintext.Text = Utils.byteArrayToString(rand.generatePlaintext(bytenum));
        }

        private void button_single_Click(object sender, EventArgs e)
        {
            state = appState.Running;
            updateFormEnabling();
            run(true);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            state = appState.Running;
            updateFormEnabling();
            run(false);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            state = appState.Stop;
            updateFormEnabling();
            ctrl.Cancel();
        }

        private void textBox_key_Leave(object sender, EventArgs e)
        {
            textBox_key.Text = Utils.formHexlString(textBox_key.Text);
        }

        private void textBox_plaintext_Leave(object sender, EventArgs e)
        {
            textBox_plaintext.Text = Utils.formHexlString(textBox_plaintext.Text);
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ControllerArgs args = (ControllerArgs)e.UserState;

            sw.Stop();
            if (args.current_trace == 1 | args.last || sw.ElapsedMilliseconds >= 30)
            {
                textBox_rtraces.Text = args.current_trace.ToString();
                textBox_relapsed.Text = args.elapsed.ToString("f3");
                textBox_rplaintext.Text = Utils.byteArrayToString(args.plaintext);
                textBox_ranswer.Text = Utils.byteArrayToString(args.answer);
                textBox_rciphertext.Text = Utils.byteArrayToString(args.ciphertext);
                textBox_rdifference.Text = Utils.byteArrayToString(args.difference);
                if (toolStripProgressBar_progress.ProgressBar != null)
                {
                    toolStripProgressBar_progress.Value = e.ProgressPercentage;
                }
                sw.Reset();

                textBox_rtraces.Update();
                textBox_relapsed.Update();
                textBox_rplaintext.Update();
                textBox_ranswer.Update();
                textBox_rciphertext.Update();
                textBox_rdifference.Update();
            }
            sw.Start();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                statusMessage("Cancelled.");
                toolStripProgressBar_progress.Value = 0;
            }
            else
            {
                ControllerArgs res = (ControllerArgs)e.Result;

                if (res.error)
                {
                    statusMessage("Error.");
                    toolStripProgressBar_progress.Value = 0;
                }
                else
                {
                    statusMessage("Completed.");
                }
            }

            if (!args.single)
            {
                rand.restartPlaintextPrng();
            }

            ctrl.Close();
            sw.Stop();
            state = appState.Idle;
            updateFormEnabling();
            toolStripProgressBar_progress.Style = ProgressBarStyle.Blocks;
        }

        private void updateFormEnabling()
        {
            switch (state)
            {
                case appState.Idle:
                    textBox_interface.Enabled = true;
                    comboBox_target.Enabled = true;
                    textBox_traces.Enabled = true;
                    checkBox_endless.Enabled = true;
                    textBox_key.Enabled = true;
                    button_changekey.Enabled = true;
                    checkBox_56bitkey.Enabled = true;
                    textBox_plaintext.Enabled = true;
                    button_changeplaintext.Enabled = true;
                    checkBox_randomgeneration.Enabled = true;
                    textBox_wait.Enabled = true;
                    button_single.Enabled = true;
                    button_start.Enabled = true;
                    button_stop.Enabled = false;
                    checkBox_continueiferror.Enabled = true;

                    checkBox_check.Enabled = true;
                    checkBox_rewrite.Enabled = true;
                    textBox_path.Enabled = true;
                    textBox_CurrentNum.Enabled = true;
                    comboBox1.Enabled = true;
                    break;

                case appState.Start:
                    textBox_interface.Enabled = false;
                    comboBox_target.Enabled = false;
                    textBox_traces.Enabled = false;
                    checkBox_endless.Enabled = false;
                    textBox_key.Enabled = false;
                    button_changekey.Enabled = false;
                    checkBox_56bitkey.Enabled = false;
                    textBox_plaintext.Enabled = false;
                    button_changeplaintext.Enabled = false;
                    checkBox_randomgeneration.Enabled = false;
                    textBox_wait.Enabled = false;
                    button_single.Enabled = false;
                    button_start.Enabled = false;
                    button_stop.Enabled = true;
                    checkBox_continueiferror.Enabled = false;

                    checkBox_check.Enabled = false;
                    checkBox_rewrite.Enabled = false;
                    textBox_path.Enabled = false;
                    textBox_CurrentNum.Enabled = false;
                    comboBox1.Enabled = false;
                    break;

                case appState.Running:
                    textBox_interface.Enabled = false;
                    comboBox_target.Enabled = false;
                    textBox_traces.Enabled = false;
                    checkBox_endless.Enabled = false;
                    textBox_key.Enabled = false;
                    button_changekey.Enabled = false;
                    checkBox_56bitkey.Enabled = false;
                    textBox_plaintext.Enabled = false;
                    button_changeplaintext.Enabled = false;
                    checkBox_randomgeneration.Enabled = false;
                    textBox_wait.Enabled = false;
                    button_single.Enabled = false;
                    button_start.Enabled = false;
                    button_stop.Enabled = true;
                    checkBox_continueiferror.Enabled = false;

                    checkBox_check.Enabled = false;
                    checkBox_rewrite.Enabled = false;
                    textBox_path.Enabled = false;
                    textBox_CurrentNum.Enabled = false;
                    comboBox1.Enabled = false;
                    break;

                case appState.Stop:
                    textBox_interface.Enabled = false;
                    comboBox_target.Enabled = false;
                    textBox_traces.Enabled = false;
                    checkBox_endless.Enabled = false;
                    textBox_key.Enabled = false;
                    button_changekey.Enabled = false;
                    checkBox_56bitkey.Enabled = false;
                    textBox_plaintext.Enabled = false;
                    button_changeplaintext.Enabled = false;
                    checkBox_randomgeneration.Enabled = false;
                    textBox_wait.Enabled = false;
                    button_single.Enabled = false;
                    button_start.Enabled = false;
                    button_stop.Enabled = false;
                    checkBox_continueiferror.Enabled = false;

                    checkBox_check.Enabled = false;
                    checkBox_rewrite.Enabled = false;
                    textBox_path.Enabled = false;
                    textBox_CurrentNum.Enabled = false;
                    comboBox1.Enabled = false;
                    break;
            }
        }

        private void statusMessage(string message)
        {
            toolStripStatusLabel_message.Text = message;
        }

        private enum appState : int
        {
            Idle = 0,
            Start,
            Running,
            Stop
        }

        private void run(bool single)
        {
            args = new ControllerArgs();

            try
            {
                uint port = 0;
                if (String.Compare("USB", textBox_interface.Text.Substring(0, 3), true) == 0)
                {
                    if (!uint.TryParse(textBox_interface.Text.Substring(3), out port))
                    {
                        throw new Exception("Error: Invalid Interface.");
                    }
                }
                else
                {
                    throw new Exception("Error: Invalid Interface.");
                }

                ctrl.Open(port);
                ctrl.AddProgressChangedEventHandler(new ProgressChangedEventHandler(worker_ProgressChanged));
                ctrl.AddCompletedEventHandler(new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted));

                args.single = single;
                args.traces = Convert.ToInt64(textBox_traces.Text);
                args.endless = checkBox_endless.Checked;
                if (!args.single)
                {
                    rand.restartPlaintextPrng();
                }

                sw.Start();
                statusMessage("Running...");

                toolStripProgressBar_progress.Value = 0;
                if (args.endless)
                {
                    toolStripProgressBar_progress.Style = ProgressBarStyle.Marquee;
                }
                else
                {
                    toolStripProgressBar_progress.Style = ProgressBarStyle.Blocks;
                }

                args.key = Utils.stringToByteArray(textBox_key.Text);
                args.plaintext = Utils.stringToByteArray(textBox_plaintext.Text);
                args.randomGeneration = checkBox_randomgeneration.Checked;
                args.wait = Convert.ToInt32(textBox_wait.Text);
                args.continueIfError = checkBox_continueiferror.Checked;
                args.check = !checkBox_check.Checked;
                args.path = textBox_path.Text;
                args.CurrentNum = Convert.ToInt64(textBox_CurrentNum.Text);
                args.Algorithm = comboBox1.SelectedItem.ToString();
                if (checkBox_rewrite.Checked)
                {
                    FileStream fs_ct = new FileStream("ciphertext.txt", FileMode.Create);
                    fs_ct.Close();
                    FileStream fs_key = new FileStream("key.txt", FileMode.Create);
                    fs_key.Close();
                    FileStream fs_pt = new FileStream("plaintext.txt", FileMode.Create);
                    fs_pt.Close();
                }

                if (Directory.Exists(args.path + "\\backup") == false)
                {
                    Directory.CreateDirectory(args.path + "\\backup");
                }

                //随机数生成，在每次重新run的时候重新随机获取种子
                Random randc = new Random();
                RandGen randb = new RandGen(randc.Next(887667), randc.Next(434343));
                args.rand = randb;


                ctrl.Run(args);
            }
            catch (Exception ex)
            {
                statusMessage(ex.Message);
                toolStripProgressBar_progress.Value = 0;
                toolStripProgressBar_progress.Style = ProgressBarStyle.Blocks;
                state = appState.Idle;
                updateFormEnabling();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_openfold_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Select Fold";
            if (textBox_path.Text != "")
            {
                //设置此次默认目录为上一次选中目录
                dialog.SelectedPath = textBox_path.Text;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                textBox_path.Text = foldPath;
                //MessageBox.Show("Selected Fold:" + textBox_path.Text, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本：1.0.0 ReleaseTime: 2016/5/19 16:07\n"+
                            "\t把所有文件移入一个文件中,增加异常处理" );
        }
    }
}
