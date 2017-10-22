using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorovaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int colKor = 0;
            if (!int.TryParse(textBox1.Text, out colKor)) MessageBox.Show("Вы ввели не число, введите число.");
            {
                string vs = Korova.Program.CowCounter(colKor);
                label2.Text = "Вы ввели: " + vs;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
