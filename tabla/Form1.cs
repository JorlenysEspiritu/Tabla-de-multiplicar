using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {

                int numero = int.Parse(txt_numero.Text);
                int resultado = numero * i;
                ltb_Calculos.Items.Add($"{numero} x {i} = {resultado}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_numero.Clear();
            ltb_Calculos.Items.Clear();
        }
    }
}
