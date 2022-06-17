namespace Arduino
{
    partial class Form2
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.start_serial = new System.Windows.Forms.Button();
            this.com_box = new System.Windows.Forms.ComboBox();
            this.led_control = new System.Windows.Forms.ComboBox();
            this.explanation_01 = new System.Windows.Forms.Label();
            this.explanation_02 = new System.Windows.Forms.Label();
            this.test_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.test_debug = new System.Windows.Forms.Label();
            this.temp_txt = new System.Windows.Forms.TextBox();
            this.temp_button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.lflick_button = new System.Windows.Forms.Button();
            this.lof_button = new System.Windows.Forms.Button();
            this.lon_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // start_serial
            // 
            this.start_serial.BackColor = System.Drawing.Color.White;
            this.start_serial.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_serial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.start_serial.Location = new System.Drawing.Point(37, 26);
            this.start_serial.Name = "start_serial";
            this.start_serial.Size = new System.Drawing.Size(122, 85);
            this.start_serial.TabIndex = 0;
            this.start_serial.Text = "シリアル通信開始";
            this.start_serial.UseVisualStyleBackColor = false;
            this.start_serial.Click += new System.EventHandler(this.start_serial_Click);
            // 
            // com_box
            // 
            this.com_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_box.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.com_box.FormattingEnabled = true;
            this.com_box.Items.AddRange(new object[] {
            "COM1",
            "COM8",
            "COM3"});
            this.com_box.Location = new System.Drawing.Point(367, 62);
            this.com_box.Name = "com_box";
            this.com_box.Size = new System.Drawing.Size(120, 39);
            this.com_box.TabIndex = 1;
            this.com_box.SelectedIndexChanged += new System.EventHandler(this.com_box_SelectedIndexChanged);
            // 
            // led_control
            // 
            this.led_control.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.led_control.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.led_control.FormattingEnabled = true;
            this.led_control.Items.AddRange(new object[] {
            "lon",
            "loff",
            "lflick",
            "test",
            "temp"});
            this.led_control.Location = new System.Drawing.Point(206, 62);
            this.led_control.Name = "led_control";
            this.led_control.Size = new System.Drawing.Size(120, 39);
            this.led_control.TabIndex = 2;
            this.led_control.SelectedIndexChanged += new System.EventHandler(this.led_control_SelectedIndexChanged);
            // 
            // explanation_01
            // 
            this.explanation_01.AutoSize = true;
            this.explanation_01.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.explanation_01.Location = new System.Drawing.Point(223, 35);
            this.explanation_01.Name = "explanation_01";
            this.explanation_01.Size = new System.Drawing.Size(74, 24);
            this.explanation_01.TabIndex = 3;
            this.explanation_01.Text = "制御方法";
            // 
            // explanation_02
            // 
            this.explanation_02.AutoSize = true;
            this.explanation_02.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.explanation_02.Location = new System.Drawing.Point(382, 35);
            this.explanation_02.Name = "explanation_02";
            this.explanation_02.Size = new System.Drawing.Size(74, 24);
            this.explanation_02.TabIndex = 4;
            this.explanation_02.Text = "com選択";
            // 
            // test_txt
            // 
            this.test_txt.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.test_txt.Location = new System.Drawing.Point(205, 230);
            this.test_txt.Name = "test_txt";
            this.test_txt.Size = new System.Drawing.Size(122, 39);
            this.test_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(223, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "現在の温度";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // test_debug
            // 
            this.test_debug.AutoSize = true;
            this.test_debug.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.test_debug.Location = new System.Drawing.Point(252, 203);
            this.test_debug.Name = "test_debug";
            this.test_debug.Size = new System.Drawing.Size(39, 24);
            this.test_debug.TabIndex = 7;
            this.test_debug.Text = "test";
            // 
            // temp_txt
            // 
            this.temp_txt.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp_txt.Location = new System.Drawing.Point(205, 300);
            this.temp_txt.Name = "temp_txt";
            this.temp_txt.Size = new System.Drawing.Size(122, 39);
            this.temp_txt.TabIndex = 8;
            // 
            // temp_button
            // 
            this.temp_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temp_button.Location = new System.Drawing.Point(37, 299);
            this.temp_button.Name = "temp_button";
            this.temp_button.Size = new System.Drawing.Size(122, 38);
            this.temp_button.TabIndex = 9;
            this.temp_button.Text = "temp";
            this.temp_button.UseVisualStyleBackColor = true;
            this.temp_button.Click += new System.EventHandler(this.temp_button_Click);
            // 
            // test_button
            // 
            this.test_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.test_button.Location = new System.Drawing.Point(37, 231);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(122, 38);
            this.test_button.TabIndex = 10;
            this.test_button.Text = "test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // lflick_button
            // 
            this.lflick_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lflick_button.Location = new System.Drawing.Point(367, 160);
            this.lflick_button.Name = "lflick_button";
            this.lflick_button.Size = new System.Drawing.Size(122, 40);
            this.lflick_button.TabIndex = 11;
            this.lflick_button.Text = "lflick";
            this.lflick_button.UseVisualStyleBackColor = true;
            this.lflick_button.Click += new System.EventHandler(this.lflick_button_Click);
            // 
            // lof_button
            // 
            this.lof_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lof_button.Location = new System.Drawing.Point(205, 160);
            this.lof_button.Name = "lof_button";
            this.lof_button.Size = new System.Drawing.Size(122, 38);
            this.lof_button.TabIndex = 12;
            this.lof_button.Text = "loff";
            this.lof_button.UseVisualStyleBackColor = true;
            this.lof_button.Click += new System.EventHandler(this.lof_button_Click);
            // 
            // lon_button
            // 
            this.lon_button.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lon_button.Location = new System.Drawing.Point(37, 159);
            this.lon_button.Name = "lon_button";
            this.lon_button.Size = new System.Drawing.Size(122, 37);
            this.lon_button.TabIndex = 13;
            this.lon_button.Text = "lon";
            this.lon_button.UseVisualStyleBackColor = true;
            this.lon_button.Click += new System.EventHandler(this.lon_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(512, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lon_button);
            this.Controls.Add(this.lof_button);
            this.Controls.Add(this.lflick_button);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.temp_button);
            this.Controls.Add(this.temp_txt);
            this.Controls.Add(this.test_debug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_txt);
            this.Controls.Add(this.explanation_02);
            this.Controls.Add(this.explanation_01);
            this.Controls.Add(this.led_control);
            this.Controls.Add(this.com_box);
            this.Controls.Add(this.start_serial);
            this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button start_serial;
        private System.Windows.Forms.ComboBox com_box;
        private System.Windows.Forms.ComboBox led_control;
        private System.Windows.Forms.Label explanation_01;
        private System.Windows.Forms.Label explanation_02;
        private System.Windows.Forms.TextBox test_txt;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label test_debug;
        private System.Windows.Forms.TextBox temp_txt;
        private System.Windows.Forms.Button temp_button;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Button lflick_button;
        private System.Windows.Forms.Button lof_button;
        private System.Windows.Forms.Button lon_button;
        private System.Windows.Forms.Button button1;
    }
}