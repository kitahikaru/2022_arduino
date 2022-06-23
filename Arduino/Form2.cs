using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arduino
{
    public partial class Form2 : Form
    {
        Function function = new Function();
        string mozi_data = "", temp_data = "",lf_data="";
        int select_index,lf_digit;
        int flag;
        //int ss_flag; //start stop_flag


        public Form2()
        {
            InitializeComponent();
        }

        private void start_serial_Click(object sender, EventArgs e)
        {
            if (led_control.SelectedIndex == 3 || led_control.SelectedIndex == 4)
            {
                Button_disable();
            }
            try
            {
                serialPort1.PortName = com_box.SelectedItem.ToString();
                serialPort1.Open();
                select_index = led_control.SelectedIndex;
                serialPort1.Write(function.Set_led_control(select_index));
                if (lf_digit!=-1)
                {
                    serialPort1.Write(lf_data);
                    serialPort1.Write(lflick_param.Text);
                }
            }
            catch (Exception)
            {
                Console.Write("arduinoに接続しているか\n有効なncomを選択しているかを確認してください．\n");
                flag = 0;
                serialPort1.Close();
            }
            //serialPort1.Close();
        }

        private void com_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            switch (select_index)
            {
                case 3:
                    mozi_data = serialPort1.ReadTo("\n");
                    flag = 0;
                    break;
                case 4:
                    temp_data = serialPort1.ReadTo("\n");
                    flag = 0;
                    break;
            }

        }

        private void led_control_SelectedIndexChanged(object sender, EventArgs e)
        {

            serialPort1.Close();
        }

        private void lon_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 0;
            start_serial.PerformClick();
            serialPort1.Close();
        }

        private void lof_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 1;
            start_serial.PerformClick();
            serialPort1.Close();
        }

        private void lflick_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 2;
            lf_data = lflick_param.Text;
            lf_digit = int.Parse(lf_data);
            lf_digit = function.digit(lf_digit);
            lf_data = lf_digit.ToString();
            start_serial.PerformClick();
            serialPort1.Close();
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            flag = 1;
            led_control.SelectedIndex = 3;
            start_serial.PerformClick();
            while (flag == 1)
            {
            }
            test_txt.Text = (mozi_data);
            Button_enable();
            serialPort1.Close();
        }

        private void temp_button_Click(object sender, EventArgs e)
        {
            flag = 1;
            led_control.SelectedIndex = 4;
            start_serial.PerformClick();
            while (flag == 1)
            {
            }
            temp_txt.Text = (temp_data);
            Button_enable();
            serialPort1.Close();
        }

        private void Button_disable()
        {
            lon_button.Enabled = false;
            lof_button.Enabled = false;
            lflick_button.Enabled = false;
            test_button.Enabled = false;
            temp_button.Enabled = false;
            start_serial.Enabled = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Button_enable()
        {
            lon_button.Enabled = true;
            lof_button.Enabled = true;
            lflick_button.Enabled = true;
            test_button.Enabled = true;
            temp_button.Enabled = true;
            start_serial.Enabled = true;
        }
    }
}