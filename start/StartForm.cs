using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace start
{
    public partial class StartForm : Form
    {
        public List<RadioButton> radioButtons;

        public StartForm()
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>()
            {
                radioButton1, radioButton2, radioButton3, radioButton4,
            };
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
