﻿namespace SAKURA_Checker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBox_target = new System.Windows.Forms.ComboBox();
            this.label_interface = new System.Windows.Forms.Label();
            this.label_target = new System.Windows.Forms.Label();
            this.label_traces = new System.Windows.Forms.Label();
            this.textBox_traces = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.label_plaintext = new System.Windows.Forms.Label();
            this.checkBox_endless = new System.Windows.Forms.CheckBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.button_changekey = new System.Windows.Forms.Button();
            this.textBox_plaintext = new System.Windows.Forms.TextBox();
            this.button_changeplaintext = new System.Windows.Forms.Button();
            this.checkBox_randomgeneration = new System.Windows.Forms.CheckBox();
            this.label_wait = new System.Windows.Forms.Label();
            this.textBox_wait = new System.Windows.Forms.TextBox();
            this.button_single = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.checkBox_continueiferror = new System.Windows.Forms.CheckBox();
            this.label_rtraces = new System.Windows.Forms.Label();
            this.textBox_rtraces = new System.Windows.Forms.TextBox();
            this.label_rplaintext = new System.Windows.Forms.Label();
            this.label_rciphertext = new System.Windows.Forms.Label();
            this.label_ranswer = new System.Windows.Forms.Label();
            this.label_rdifference = new System.Windows.Forms.Label();
            this.label_relapsed = new System.Windows.Forms.Label();
            this.textBox_rplaintext = new System.Windows.Forms.TextBox();
            this.textBox_rciphertext = new System.Windows.Forms.TextBox();
            this.textBox_ranswer = new System.Windows.Forms.TextBox();
            this.textBox_rdifference = new System.Windows.Forms.TextBox();
            this.checkBox_56bitkey = new System.Windows.Forms.CheckBox();
            this.textBox_relapsed = new System.Windows.Forms.TextBox();
            this.label_waitms = new System.Windows.Forms.Label();
            this.label_relapsed_ms = new System.Windows.Forms.Label();
            this.textBox_interface = new System.Windows.Forms.TextBox();
            this.statusStrip_status = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_rewrite = new System.Windows.Forms.CheckBox();
            this.checkBox_check = new System.Windows.Forms.CheckBox();
            this.label_path = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_openfold = new System.Windows.Forms.Button();
            this.labelCurrentNum = new System.Windows.Forms.Label();
            this.textBox_CurrentNum = new System.Windows.Forms.TextBox();
            this.button_about = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_target
            // 
            this.comboBox_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_target.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_target.FormattingEnabled = true;
            this.comboBox_target.Items.AddRange(new object[] {
            "SAKURA-G Quick Start"});
            this.comboBox_target.Location = new System.Drawing.Point(212, 76);
            this.comboBox_target.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox_target.Name = "comboBox_target";
            this.comboBox_target.Size = new System.Drawing.Size(779, 42);
            this.comboBox_target.TabIndex = 3;
            // 
            // label_interface
            // 
            this.label_interface.AutoSize = true;
            this.label_interface.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_interface.Location = new System.Drawing.Point(19, 27);
            this.label_interface.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_interface.Name = "label_interface";
            this.label_interface.Size = new System.Drawing.Size(159, 36);
            this.label_interface.TabIndex = 0;
            this.label_interface.Text = "Interface";
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_target.Location = new System.Drawing.Point(19, 83);
            this.label_target.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(111, 36);
            this.label_target.TabIndex = 2;
            this.label_target.Text = "Target";
            // 
            // label_traces
            // 
            this.label_traces.AutoSize = true;
            this.label_traces.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_traces.Location = new System.Drawing.Point(19, 207);
            this.label_traces.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_traces.Name = "label_traces";
            this.label_traces.Size = new System.Drawing.Size(127, 36);
            this.label_traces.TabIndex = 4;
            this.label_traces.Text = "#Traces";
            // 
            // textBox_traces
            // 
            this.textBox_traces.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_traces.Location = new System.Drawing.Point(212, 200);
            this.textBox_traces.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_traces.Name = "textBox_traces";
            this.textBox_traces.Size = new System.Drawing.Size(228, 42);
            this.textBox_traces.TabIndex = 5;
            this.textBox_traces.Text = "50000";
            this.textBox_traces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_key.Location = new System.Drawing.Point(19, 263);
            this.label_key.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(63, 36);
            this.label_key.TabIndex = 7;
            this.label_key.Text = "Key";
            // 
            // label_plaintext
            // 
            this.label_plaintext.AutoSize = true;
            this.label_plaintext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaintext.Location = new System.Drawing.Point(19, 319);
            this.label_plaintext.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_plaintext.Name = "label_plaintext";
            this.label_plaintext.Size = new System.Drawing.Size(159, 36);
            this.label_plaintext.TabIndex = 11;
            this.label_plaintext.Text = "Plaintext";
            // 
            // checkBox_endless
            // 
            this.checkBox_endless.AutoSize = true;
            this.checkBox_endless.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_endless.Location = new System.Drawing.Point(460, 204);
            this.checkBox_endless.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox_endless.Name = "checkBox_endless";
            this.checkBox_endless.Size = new System.Drawing.Size(159, 40);
            this.checkBox_endless.TabIndex = 6;
            this.checkBox_endless.Text = "Endless";
            this.checkBox_endless.UseVisualStyleBackColor = true;
            // 
            // textBox_key
            // 
            this.textBox_key.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.Location = new System.Drawing.Point(212, 256);
            this.textBox_key.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(779, 42);
            this.textBox_key.TabIndex = 8;
            this.textBox_key.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            this.textBox_key.Leave += new System.EventHandler(this.textBox_key_Leave);
            // 
            // button_changekey
            // 
            this.button_changekey.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changekey.Location = new System.Drawing.Point(1010, 254);
            this.button_changekey.Margin = new System.Windows.Forms.Padding(7);
            this.button_changekey.Name = "button_changekey";
            this.button_changekey.Size = new System.Drawing.Size(135, 52);
            this.button_changekey.TabIndex = 9;
            this.button_changekey.Text = "Change";
            this.button_changekey.UseVisualStyleBackColor = true;
            this.button_changekey.Click += new System.EventHandler(this.button_changekey_Click);
            // 
            // textBox_plaintext
            // 
            this.textBox_plaintext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_plaintext.Location = new System.Drawing.Point(212, 312);
            this.textBox_plaintext.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_plaintext.Name = "textBox_plaintext";
            this.textBox_plaintext.Size = new System.Drawing.Size(779, 42);
            this.textBox_plaintext.TabIndex = 12;
            this.textBox_plaintext.Text = "00 11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF";
            this.textBox_plaintext.Leave += new System.EventHandler(this.textBox_plaintext_Leave);
            // 
            // button_changeplaintext
            // 
            this.button_changeplaintext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_changeplaintext.Location = new System.Drawing.Point(1010, 310);
            this.button_changeplaintext.Margin = new System.Windows.Forms.Padding(7);
            this.button_changeplaintext.Name = "button_changeplaintext";
            this.button_changeplaintext.Size = new System.Drawing.Size(135, 52);
            this.button_changeplaintext.TabIndex = 13;
            this.button_changeplaintext.Text = "Change";
            this.button_changeplaintext.UseVisualStyleBackColor = true;
            this.button_changeplaintext.Click += new System.EventHandler(this.button_changeplaintext_Click);
            // 
            // checkBox_randomgeneration
            // 
            this.checkBox_randomgeneration.AutoSize = true;
            this.checkBox_randomgeneration.Checked = true;
            this.checkBox_randomgeneration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_randomgeneration.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_randomgeneration.Location = new System.Drawing.Point(1160, 317);
            this.checkBox_randomgeneration.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox_randomgeneration.Name = "checkBox_randomgeneration";
            this.checkBox_randomgeneration.Size = new System.Drawing.Size(319, 40);
            this.checkBox_randomgeneration.TabIndex = 14;
            this.checkBox_randomgeneration.Text = "Random Generation";
            this.checkBox_randomgeneration.UseVisualStyleBackColor = true;
            // 
            // label_wait
            // 
            this.label_wait.AutoSize = true;
            this.label_wait.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wait.Location = new System.Drawing.Point(19, 375);
            this.label_wait.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_wait.Name = "label_wait";
            this.label_wait.Size = new System.Drawing.Size(79, 36);
            this.label_wait.TabIndex = 15;
            this.label_wait.Text = "Wait";
            // 
            // textBox_wait
            // 
            this.textBox_wait.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_wait.Location = new System.Drawing.Point(212, 369);
            this.textBox_wait.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_wait.Name = "textBox_wait";
            this.textBox_wait.Size = new System.Drawing.Size(228, 42);
            this.textBox_wait.TabIndex = 16;
            this.textBox_wait.Text = "100";
            this.textBox_wait.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_single
            // 
            this.button_single.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_single.Location = new System.Drawing.Point(23, 434);
            this.button_single.Margin = new System.Windows.Forms.Padding(7);
            this.button_single.Name = "button_single";
            this.button_single.Size = new System.Drawing.Size(175, 52);
            this.button_single.TabIndex = 18;
            this.button_single.Text = "Single";
            this.button_single.UseVisualStyleBackColor = true;
            this.button_single.Click += new System.EventHandler(this.button_single_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(212, 434);
            this.button_start.Margin = new System.Windows.Forms.Padding(7);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(175, 52);
            this.button_start.TabIndex = 19;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.Location = new System.Drawing.Point(401, 434);
            this.button_stop.Margin = new System.Windows.Forms.Padding(7);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(175, 52);
            this.button_stop.TabIndex = 20;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // checkBox_continueiferror
            // 
            this.checkBox_continueiferror.AutoSize = true;
            this.checkBox_continueiferror.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_continueiferror.Location = new System.Drawing.Point(590, 441);
            this.checkBox_continueiferror.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox_continueiferror.Name = "checkBox_continueiferror";
            this.checkBox_continueiferror.Size = new System.Drawing.Size(319, 40);
            this.checkBox_continueiferror.TabIndex = 21;
            this.checkBox_continueiferror.Text = "Continue if error";
            this.checkBox_continueiferror.UseVisualStyleBackColor = true;
            // 
            // label_rtraces
            // 
            this.label_rtraces.AutoSize = true;
            this.label_rtraces.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rtraces.Location = new System.Drawing.Point(19, 506);
            this.label_rtraces.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_rtraces.Name = "label_rtraces";
            this.label_rtraces.Size = new System.Drawing.Size(127, 36);
            this.label_rtraces.TabIndex = 22;
            this.label_rtraces.Text = "#Traces";
            // 
            // textBox_rtraces
            // 
            this.textBox_rtraces.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rtraces.Location = new System.Drawing.Point(212, 499);
            this.textBox_rtraces.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_rtraces.Name = "textBox_rtraces";
            this.textBox_rtraces.ReadOnly = true;
            this.textBox_rtraces.Size = new System.Drawing.Size(228, 42);
            this.textBox_rtraces.TabIndex = 23;
            this.textBox_rtraces.Text = "0";
            this.textBox_rtraces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_rplaintext
            // 
            this.label_rplaintext.AutoSize = true;
            this.label_rplaintext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rplaintext.Location = new System.Drawing.Point(19, 618);
            this.label_rplaintext.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_rplaintext.Name = "label_rplaintext";
            this.label_rplaintext.Size = new System.Drawing.Size(159, 36);
            this.label_rplaintext.TabIndex = 27;
            this.label_rplaintext.Text = "Plaintext";
            // 
            // label_rciphertext
            // 
            this.label_rciphertext.AutoSize = true;
            this.label_rciphertext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rciphertext.Location = new System.Drawing.Point(19, 675);
            this.label_rciphertext.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_rciphertext.Name = "label_rciphertext";
            this.label_rciphertext.Size = new System.Drawing.Size(175, 36);
            this.label_rciphertext.TabIndex = 29;
            this.label_rciphertext.Text = "Ciphertext";
            // 
            // label_ranswer
            // 
            this.label_ranswer.AutoSize = true;
            this.label_ranswer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ranswer.Location = new System.Drawing.Point(19, 731);
            this.label_ranswer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_ranswer.Name = "label_ranswer";
            this.label_ranswer.Size = new System.Drawing.Size(111, 36);
            this.label_ranswer.TabIndex = 31;
            this.label_ranswer.Text = "Answer";
            // 
            // label_rdifference
            // 
            this.label_rdifference.AutoSize = true;
            this.label_rdifference.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rdifference.Location = new System.Drawing.Point(19, 787);
            this.label_rdifference.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_rdifference.Name = "label_rdifference";
            this.label_rdifference.Size = new System.Drawing.Size(175, 36);
            this.label_rdifference.TabIndex = 33;
            this.label_rdifference.Text = "Difference";
            // 
            // label_relapsed
            // 
            this.label_relapsed.AutoSize = true;
            this.label_relapsed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_relapsed.Location = new System.Drawing.Point(19, 562);
            this.label_relapsed.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_relapsed.Name = "label_relapsed";
            this.label_relapsed.Size = new System.Drawing.Size(127, 36);
            this.label_relapsed.TabIndex = 24;
            this.label_relapsed.Text = "Elapsed";
            // 
            // textBox_rplaintext
            // 
            this.textBox_rplaintext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rplaintext.Location = new System.Drawing.Point(212, 611);
            this.textBox_rplaintext.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_rplaintext.Name = "textBox_rplaintext";
            this.textBox_rplaintext.ReadOnly = true;
            this.textBox_rplaintext.Size = new System.Drawing.Size(779, 42);
            this.textBox_rplaintext.TabIndex = 28;
            // 
            // textBox_rciphertext
            // 
            this.textBox_rciphertext.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rciphertext.Location = new System.Drawing.Point(212, 668);
            this.textBox_rciphertext.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_rciphertext.Name = "textBox_rciphertext";
            this.textBox_rciphertext.ReadOnly = true;
            this.textBox_rciphertext.Size = new System.Drawing.Size(779, 42);
            this.textBox_rciphertext.TabIndex = 30;
            // 
            // textBox_ranswer
            // 
            this.textBox_ranswer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ranswer.Location = new System.Drawing.Point(212, 724);
            this.textBox_ranswer.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_ranswer.Name = "textBox_ranswer";
            this.textBox_ranswer.ReadOnly = true;
            this.textBox_ranswer.Size = new System.Drawing.Size(779, 42);
            this.textBox_ranswer.TabIndex = 32;
            // 
            // textBox_rdifference
            // 
            this.textBox_rdifference.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_rdifference.Location = new System.Drawing.Point(212, 780);
            this.textBox_rdifference.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_rdifference.Name = "textBox_rdifference";
            this.textBox_rdifference.ReadOnly = true;
            this.textBox_rdifference.Size = new System.Drawing.Size(779, 42);
            this.textBox_rdifference.TabIndex = 34;
            // 
            // checkBox_56bitkey
            // 
            this.checkBox_56bitkey.AutoSize = true;
            this.checkBox_56bitkey.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.checkBox_56bitkey.Location = new System.Drawing.Point(1160, 265);
            this.checkBox_56bitkey.Margin = new System.Windows.Forms.Padding(7);
            this.checkBox_56bitkey.Name = "checkBox_56bitkey";
            this.checkBox_56bitkey.Size = new System.Drawing.Size(191, 40);
            this.checkBox_56bitkey.TabIndex = 10;
            this.checkBox_56bitkey.Text = "56bit Key";
            this.checkBox_56bitkey.UseVisualStyleBackColor = true;
            this.checkBox_56bitkey.CheckedChanged += new System.EventHandler(this.checkBox_56bitkey_CheckedChanged);
            // 
            // textBox_relapsed
            // 
            this.textBox_relapsed.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBox_relapsed.Location = new System.Drawing.Point(212, 555);
            this.textBox_relapsed.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_relapsed.Name = "textBox_relapsed";
            this.textBox_relapsed.ReadOnly = true;
            this.textBox_relapsed.Size = new System.Drawing.Size(228, 42);
            this.textBox_relapsed.TabIndex = 25;
            this.textBox_relapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_waitms
            // 
            this.label_waitms.AutoSize = true;
            this.label_waitms.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_waitms.Location = new System.Drawing.Point(460, 375);
            this.label_waitms.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_waitms.Name = "label_waitms";
            this.label_waitms.Size = new System.Drawing.Size(47, 36);
            this.label_waitms.TabIndex = 17;
            this.label_waitms.Text = "ms";
            // 
            // label_relapsed_ms
            // 
            this.label_relapsed_ms.AutoSize = true;
            this.label_relapsed_ms.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_relapsed_ms.Location = new System.Drawing.Point(445, 555);
            this.label_relapsed_ms.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_relapsed_ms.Name = "label_relapsed_ms";
            this.label_relapsed_ms.Size = new System.Drawing.Size(38, 42);
            this.label_relapsed_ms.TabIndex = 26;
            this.label_relapsed_ms.Text = "s";
            // 
            // textBox_interface
            // 
            this.textBox_interface.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_interface.Location = new System.Drawing.Point(212, 20);
            this.textBox_interface.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_interface.Name = "textBox_interface";
            this.textBox_interface.Size = new System.Drawing.Size(228, 42);
            this.textBox_interface.TabIndex = 1;
            this.textBox_interface.Text = "USB0";
            // 
            // statusStrip_status
            // 
            this.statusStrip_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_progress,
            this.toolStripStatusLabel_message});
            this.statusStrip_status.Location = new System.Drawing.Point(0, 841);
            this.statusStrip_status.Name = "statusStrip_status";
            this.statusStrip_status.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.statusStrip_status.Size = new System.Drawing.Size(1500, 42);
            this.statusStrip_status.SizingGrip = false;
            this.statusStrip_status.TabIndex = 35;
            this.statusStrip_status.Text = "statusStrip1";
            // 
            // toolStripProgressBar_progress
            // 
            this.toolStripProgressBar_progress.MarqueeAnimationSpeed = 20;
            this.toolStripProgressBar_progress.Name = "toolStripProgressBar_progress";
            this.toolStripProgressBar_progress.Size = new System.Drawing.Size(117, 36);
            this.toolStripProgressBar_progress.Step = 1;
            // 
            // toolStripStatusLabel_message
            // 
            this.toolStripStatusLabel_message.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.toolStripStatusLabel_message.Name = "toolStripStatusLabel_message";
            this.toolStripStatusLabel_message.Size = new System.Drawing.Size(0, 37);
            // 
            // checkBox_rewrite
            // 
            this.checkBox_rewrite.AutoSize = true;
            this.checkBox_rewrite.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.checkBox_rewrite.Location = new System.Drawing.Point(590, 375);
            this.checkBox_rewrite.Name = "checkBox_rewrite";
            this.checkBox_rewrite.Size = new System.Drawing.Size(159, 40);
            this.checkBox_rewrite.TabIndex = 36;
            this.checkBox_rewrite.Text = "rewrite";
            this.checkBox_rewrite.UseVisualStyleBackColor = true;
            // 
            // checkBox_check
            // 
            this.checkBox_check.AutoSize = true;
            this.checkBox_check.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.checkBox_check.Location = new System.Drawing.Point(590, 509);
            this.checkBox_check.Name = "checkBox_check";
            this.checkBox_check.Size = new System.Drawing.Size(159, 40);
            this.checkBox_check.TabIndex = 37;
            this.checkBox_check.Text = "uncheck";
            this.checkBox_check.UseVisualStyleBackColor = true;
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_path.Location = new System.Drawing.Point(19, 144);
            this.label_path.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(79, 36);
            this.label_path.TabIndex = 38;
            this.label_path.Text = "Path";
            // 
            // textBox_path
            // 
            this.textBox_path.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_path.Location = new System.Drawing.Point(212, 138);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(779, 42);
            this.textBox_path.TabIndex = 39;
            this.textBox_path.Text = "D:\\powertrace";
            // 
            // button_openfold
            // 
            this.button_openfold.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openfold.Location = new System.Drawing.Point(1005, 138);
            this.button_openfold.Margin = new System.Windows.Forms.Padding(7);
            this.button_openfold.Name = "button_openfold";
            this.button_openfold.Size = new System.Drawing.Size(77, 45);
            this.button_openfold.TabIndex = 40;
            this.button_openfold.Text = "...";
            this.button_openfold.UseVisualStyleBackColor = true;
            this.button_openfold.Click += new System.EventHandler(this.button_openfold_Click);
            // 
            // labelCurrentNum
            // 
            this.labelCurrentNum.AutoSize = true;
            this.labelCurrentNum.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentNum.Location = new System.Drawing.Point(652, 203);
            this.labelCurrentNum.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCurrentNum.Name = "labelCurrentNum";
            this.labelCurrentNum.Size = new System.Drawing.Size(175, 36);
            this.labelCurrentNum.TabIndex = 41;
            this.labelCurrentNum.Text = "CurrentNum";
            // 
            // textBox_CurrentNum
            // 
            this.textBox_CurrentNum.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CurrentNum.Location = new System.Drawing.Point(831, 198);
            this.textBox_CurrentNum.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_CurrentNum.Name = "textBox_CurrentNum";
            this.textBox_CurrentNum.Size = new System.Drawing.Size(160, 42);
            this.textBox_CurrentNum.TabIndex = 42;
            this.textBox_CurrentNum.Text = "0";
            this.textBox_CurrentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_about
            // 
            this.button_about.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.button_about.Location = new System.Drawing.Point(1160, 27);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(122, 51);
            this.button_about.TabIndex = 43;
            this.button_about.Text = "about";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AES",
            "DES"});
            this.comboBox1.Location = new System.Drawing.Point(844, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 42);
            this.comboBox1.TabIndex = 44;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 883);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.textBox_CurrentNum);
            this.Controls.Add(this.labelCurrentNum);
            this.Controls.Add(this.button_openfold);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.checkBox_check);
            this.Controls.Add(this.checkBox_rewrite);
            this.Controls.Add(this.statusStrip_status);
            this.Controls.Add(this.textBox_interface);
            this.Controls.Add(this.label_relapsed_ms);
            this.Controls.Add(this.label_waitms);
            this.Controls.Add(this.textBox_relapsed);
            this.Controls.Add(this.checkBox_56bitkey);
            this.Controls.Add(this.textBox_rdifference);
            this.Controls.Add(this.textBox_ranswer);
            this.Controls.Add(this.textBox_rciphertext);
            this.Controls.Add(this.textBox_rplaintext);
            this.Controls.Add(this.label_relapsed);
            this.Controls.Add(this.label_rdifference);
            this.Controls.Add(this.label_ranswer);
            this.Controls.Add(this.label_rciphertext);
            this.Controls.Add(this.label_rplaintext);
            this.Controls.Add(this.textBox_rtraces);
            this.Controls.Add(this.label_rtraces);
            this.Controls.Add(this.checkBox_continueiferror);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_single);
            this.Controls.Add(this.textBox_wait);
            this.Controls.Add(this.label_wait);
            this.Controls.Add(this.checkBox_randomgeneration);
            this.Controls.Add(this.button_changeplaintext);
            this.Controls.Add(this.textBox_plaintext);
            this.Controls.Add(this.button_changekey);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.checkBox_endless);
            this.Controls.Add(this.label_plaintext);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_traces);
            this.Controls.Add(this.label_traces);
            this.Controls.Add(this.label_target);
            this.Controls.Add(this.label_interface);
            this.Controls.Add(this.comboBox_target);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Text = "SAKURA Checker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip_status.ResumeLayout(false);
            this.statusStrip_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_target;
        private System.Windows.Forms.Label label_interface;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.Label label_traces;
        private System.Windows.Forms.TextBox textBox_traces;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_plaintext;
        private System.Windows.Forms.CheckBox checkBox_endless;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Button button_changekey;
        private System.Windows.Forms.TextBox textBox_plaintext;
        private System.Windows.Forms.Button button_changeplaintext;
        private System.Windows.Forms.CheckBox checkBox_randomgeneration;
        private System.Windows.Forms.Label label_wait;
        private System.Windows.Forms.TextBox textBox_wait;
        private System.Windows.Forms.Button button_single;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.CheckBox checkBox_continueiferror;
        private System.Windows.Forms.Label label_rtraces;
        private System.Windows.Forms.TextBox textBox_rtraces;
        private System.Windows.Forms.Label label_rplaintext;
        private System.Windows.Forms.Label label_rciphertext;
        private System.Windows.Forms.Label label_ranswer;
        private System.Windows.Forms.Label label_rdifference;
        private System.Windows.Forms.Label label_relapsed;
        private System.Windows.Forms.TextBox textBox_rplaintext;
        private System.Windows.Forms.TextBox textBox_rciphertext;
        private System.Windows.Forms.TextBox textBox_ranswer;
        private System.Windows.Forms.TextBox textBox_rdifference;
        private System.Windows.Forms.CheckBox checkBox_56bitkey;
        private System.Windows.Forms.TextBox textBox_relapsed;
        private System.Windows.Forms.Label label_waitms;
        private System.Windows.Forms.Label label_relapsed_ms;
        private System.Windows.Forms.TextBox textBox_interface;
        private System.Windows.Forms.StatusStrip statusStrip_status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_message;
        private System.Windows.Forms.CheckBox checkBox_rewrite;
        private System.Windows.Forms.CheckBox checkBox_check;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_openfold;
        private System.Windows.Forms.Label labelCurrentNum;
        private System.Windows.Forms.TextBox textBox_CurrentNum;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

