namespace Arduino
{
    partial class Form3
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
            System.Windows.Forms.Timer timer1;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.state_ss = new System.Windows.Forms.RichTextBox();
            this.temp_progress = new System.Windows.Forms.ProgressBar();
            this.mode_1sec = new System.Windows.Forms.Button();
            this.mode_1000avg = new System.Windows.Forms.Button();
            this.view_enable = new System.Windows.Forms.RichTextBox();
            this.ebable_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(92, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start_button.Location = new System.Drawing.Point(33, 161);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(94, 81);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "開始";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stop_button.Location = new System.Drawing.Point(137, 161);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(86, 81);
            this.stop_button.TabIndex = 2;
            this.stop_button.Text = "停止";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(188, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "℃";
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // state_ss
            // 
            this.state_ss.BackColor = System.Drawing.SystemColors.Control;
            this.state_ss.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.state_ss.Location = new System.Drawing.Point(280, 16);
            this.state_ss.Margin = new System.Windows.Forms.Padding(4);
            this.state_ss.Name = "state_ss";
            this.state_ss.ReadOnly = true;
            this.state_ss.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.state_ss.Size = new System.Drawing.Size(33, 132);
            this.state_ss.TabIndex = 5;
            this.state_ss.Text = "";
            // 
            // temp_progress
            // 
            this.temp_progress.Location = new System.Drawing.Point(33, 272);
            this.temp_progress.Name = "temp_progress";
            this.temp_progress.Size = new System.Drawing.Size(190, 23);
            this.temp_progress.TabIndex = 6;
            // 
            // mode_1sec
            // 
            this.mode_1sec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mode_1sec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mode_1sec.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mode_1sec.ForeColor = System.Drawing.Color.White;
            this.mode_1sec.Location = new System.Drawing.Point(249, 233);
            this.mode_1sec.Name = "mode_1sec";
            this.mode_1sec.Size = new System.Drawing.Size(52, 62);
            this.mode_1sec.TabIndex = 7;
            this.mode_1sec.Text = "1sec_temp";
            this.mode_1sec.UseVisualStyleBackColor = false;
            this.mode_1sec.Click += new System.EventHandler(this.mode_1sec_Click);
            // 
            // mode_1000avg
            // 
            this.mode_1000avg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mode_1000avg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mode_1000avg.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mode_1000avg.ForeColor = System.Drawing.Color.White;
            this.mode_1000avg.Location = new System.Drawing.Point(307, 233);
            this.mode_1000avg.Name = "mode_1000avg";
            this.mode_1000avg.Size = new System.Drawing.Size(52, 62);
            this.mode_1000avg.TabIndex = 8;
            this.mode_1000avg.Text = "1000_avg";
            this.mode_1000avg.UseVisualStyleBackColor = false;
            this.mode_1000avg.Click += new System.EventHandler(this.mode_1000avg_Click);
            // 
            // view_enable
            // 
            this.view_enable.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.view_enable.Location = new System.Drawing.Point(249, 180);
            this.view_enable.Margin = new System.Windows.Forms.Padding(4);
            this.view_enable.Name = "view_enable";
            this.view_enable.ReadOnly = true;
            this.view_enable.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.view_enable.Size = new System.Drawing.Size(110, 37);
            this.view_enable.TabIndex = 9;
            this.view_enable.Text = "";
            // 
            // ebable_text
            // 
            this.ebable_text.AutoSize = true;
            this.ebable_text.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ebable_text.Location = new System.Drawing.Point(264, 152);
            this.ebable_text.Name = "ebable_text";
            this.ebable_text.Size = new System.Drawing.Size(90, 24);
            this.ebable_text.TabIndex = 10;
            this.ebable_text.Text = "有効モード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(31, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "mode:1000avg進行状況";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(387, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ebable_text);
            this.Controls.Add(this.view_enable);
            this.Controls.Add(this.mode_1000avg);
            this.Controls.Add(this.mode_1sec);
            this.Controls.Add(this.temp_progress);
            this.Controls.Add(this.state_ss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.RichTextBox state_ss;
        private System.Windows.Forms.Button mode_1sec;
        private System.Windows.Forms.Button mode_1000avg;
        private System.Windows.Forms.RichTextBox view_enable;
        private System.Windows.Forms.Label ebable_text;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar temp_progress;
    }
}