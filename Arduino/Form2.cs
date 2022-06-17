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
        Function function = new Function(); //*
        string mozi_data="",temp_data="";
        int select_index;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void start_serial_Click(object sender, EventArgs e)
        {
            if (start_serial.Enabled)
            {
                try
                {
                    
                    serialPort1.PortName = com_box.SelectedItem.ToString();
                    serialPort1.Open();
                    serialPort1.Write(function.Set_led_control(led_control.SelectedIndex));
                    start_serial.Enabled = false;
                    select_index = led_control.SelectedIndex;
                }
                catch(Exception)
                {
                    Console.Write("arduinoに接続しているか\n有効なncomを選択しているかを確認してください．\n");
                    serialPort1.Close();
                    start_serial.Enabled = true;
                }
            }
        }

        private void com_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            start_serial.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }
            switch (select_index)
            {
                case 3:
                    mozi_data = serialPort1.ReadTo("\n");
                    break;
                case 4:
                    temp_data = serialPort1.ReadTo("\n");
                    break;
            }
            /*if (select_index== 3)
            {
                mozi_data = serialPort1.ReadTo("\n");
                if (mozi_data != "hello world")
                {
                    mozi_data = "";
                }
            }
            else if (select_index == 4)
            {
                temp_data = serialPort1.ReadTo("\n");
            }*/

        }

        private void led_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            serialPort1.Close();
            start_serial.Enabled = true;
        }

        private void lon_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 0;
            start_serial.PerformClick();
        }

        private void lof_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 1;
            start_serial.PerformClick();
        }

        private void lflick_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 2;
            start_serial.PerformClick();
            
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 3;
            start_serial.PerformClick();
            Thread.Sleep(1000);
            test_txt.Text = (mozi_data);
        }

        private void temp_button_Click(object sender, EventArgs e)
        {
            led_control.SelectedIndex = 4;
            start_serial.PerformClick();
            Thread.Sleep(1000);
            temp_txt.Text = (temp_data);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
           /* string PortList = serialPort1.PortName;
            com_box.Items.Add(PortList);*/
            /*if (led_control.SelectedIndex == 3)
            {
                test_txt.Text = (mozi_data);
            }
            else if(led_control.SelectedIndex == 4)
            {
                temp_txt.Text = (temp_data);
            }*/
        }
    }
}
