using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form3 : Form
    {
        string temp_data;
        int s_mode = 0,cnt=0,p_flag=0,load_cnt;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                temp_progress.Value = 0;
                start_button.Enabled = false;
                serialPort2.Close();
                state_ss.Text = ("実行中");
                serialPort2.PortName = "COM8";
                serialPort2.Open();
                if (s_mode==1)
                {

                    serialPort2.Write("Kt");
                }
                else
                {
                    serialPort2.Write("Ko");  //temp_measure
                }
                
            }
            catch (Exception)
            {
                Console.Write("有効なcomに設定されているかを確認してください\n");
                serialPort2.Close();
            }
        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            temp_data = serialPort2.ReadTo("\n");
            if (temp_data=="*****\r")
            {
                load_cnt++;
                if (load_cnt == 10)
                {
                    load_cnt = 0;
                    p_flag = 1;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt % 100==0)
            {
                cnt = 0;
                if (s_mode == 1)
                {
                    textBox1.Text = (temp_data);
                }
                if (temp_data != null)
                {
                    textBox1.Text = (temp_data);
                }
            }
            if (p_flag == 1)
            {
                p_flag = 0;
                temp_progress.Increment(1);
                temp_data = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = true;
            serialPort2.Close();
            state_ss.Text = ("停止中");
        }



        private void mode_1sec_Click(object sender, EventArgs e)
        {
            s_mode = 0;
            view_enable.Text = ("1sec_cycle");
        }

        private void mode_1000avg_Click(object sender, EventArgs e)
        {
            s_mode = 1;
            view_enable.Text = ("1000avg");
        }
    }
}
