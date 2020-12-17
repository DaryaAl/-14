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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Table.Row;
            numericUpDown2.Value = Table.Column;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table.Row = Convert.ToInt32(numericUpDown2.Value);
            Table.Column = Convert.ToInt32(numericUpDown1.Value);
            Close();
        }
    }
}
