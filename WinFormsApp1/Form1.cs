using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fact;
            if (int.TryParse(textBox1.Text, out fact) && fact > 0)
            {
                for (int i = fact - 1; i > 0; i--)
                {
                    fact *= i;
                }
                System.Windows.Forms.MessageBox.Show(fact.ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("negative/non int number entered");
            }
                
        }
    }
}