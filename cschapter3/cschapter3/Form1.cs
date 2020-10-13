using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cschapter3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = talker.BlahBlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("The mmessage length is " + len);//줄바꿈 문자도 length에 포함됨.
        }
    }
}
