namespace WinFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 arana= new Class1();
            arana.renk = "kýrmýzý";
            arana.marka = "merco";
            arana.model = "a3";
            label1.Text = arana.renk;
            label2.Text = arana.marka;
            label3.Text = arana.model;
        }
    }
}