using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpUygulama11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxBolum.Text = (Convert.ToInt32(textBoxBolunen.Text) / Convert.ToInt32(textBoxBolen.Text)).ToString();
            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("Bir sayi 0'a bolunemez!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lutfen Sayi Giriniz!");

            }
            
        }
    }
}
