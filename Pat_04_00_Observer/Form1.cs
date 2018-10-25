using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pat_04_00_Observer
{
    public partial class Form1 : Form
    {
        DigitalClock digitalClock;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //digitalClock = new DigitalClock(this, new ClockTimer());
            digitalClock = new DigitalClock(panel1, new ClockTimer());

            
        }
    }
}
