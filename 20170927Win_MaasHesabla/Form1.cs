using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170927Win_MaasHesabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hesabla_Click(object sender, EventArgs e)
        {
            float netice;
            netice = float.Parse(txt_ay.Text)*float.Parse(txt_Maas.Text);
            MessageBox.Show("Sizin alacağınız maaş = " + netice.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = 85;
            string c = "95";
            int b;
            b = (int)a;
            b = Int32.Parse(c);
            MessageBox.Show(b.ToString());
        }
    }
}
