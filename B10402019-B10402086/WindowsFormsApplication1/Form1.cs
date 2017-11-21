using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 g = new Class1();
            Class2 h = new Class2();

            comboBox1.Items.Clear();

            label1.Text = g.GetNumber().ToString();
            int number = g.GetNumber();

            for (int i = 2; i <= number; i++)
            {
                if (h.Prime_number(i) == false)
                {
                    comboBox1.Items.Add(i);
                }
            }
        }
    }
}
