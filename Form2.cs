using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "123")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                textBox1.Focus();
                textBox1.Clear();
            }
        }

        //
        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }
    }
}
