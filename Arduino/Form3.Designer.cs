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
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(108, 77);
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
            this.start_button.Location = new System.Drawing.Point(71, 172);
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
            this.stop_button.Location = new System.Drawing.Point(175, 172);
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
            this.label1.Location = new System.Drawing.Point(226, 89);
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
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // state_ss
            // 
            this.state_ss.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.state_ss.Location = new System.Drawing.Point(305, 13);
            this.state_ss.Margin = new System.Windows.Forms.Padding(4);
            this.state_ss.Name = "state_ss";
            this.state_ss.ReadOnly = true;
            this.state_ss.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.state_ss.Size = new System.Drawing.Size(36, 132);
            this.state_ss.TabIndex = 5;
            this.state_ss.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(354, 292);
            this.Controls.Add(this.state_ss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.textBox1);
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
    }
}