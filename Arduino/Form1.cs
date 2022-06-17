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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void transition_property_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            
        }

        private void transition_themometer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            transition_themometer.Enabled = false;
        }
    }
}
