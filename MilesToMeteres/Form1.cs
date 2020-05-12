using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToMeteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int miles;
            bool success = int.TryParse(this.textBox1.Text, out miles);
            if (success) this.label2.Text = "Километры: "+ (miles * 1.61).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}