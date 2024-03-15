using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Class1 araba=new Class1();
            araba.marka = "ford";
            araba.renk = "beyaz";
            araba.model = "focus";
            label1.Text = araba.renk;
            label2.Text = araba.model;
                label3.Text = araba.renk;
        }
    }
}
