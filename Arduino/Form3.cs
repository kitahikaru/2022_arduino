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
                serialPort2.PortName = "COM8";
                serialPort2.Open();
                serialPort2.Write("K");  //temp_measure

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

        }
    }
}
