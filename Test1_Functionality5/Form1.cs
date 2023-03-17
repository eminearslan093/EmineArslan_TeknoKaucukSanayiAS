using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test1_Functionality5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Fibonacci_Hesapla(int sayi)
        {

            if (sayi == 1)
                return 0;
            else if (sayi == 2)
                return 1;
            else if (sayi == 3)
                return 1;
   
            else

                return Fibonacci_Hesapla(sayi - 1) + Fibonacci_Hesapla(sayi - 2);
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            
            try
            {
                txt_ShowFibronacci.Text = string.Empty;

                if (int.Parse(txt_fibronacciOrder.Text) > 0 && int.Parse(txt_fibronacciOrder.Text) <= 35)
                {
                    //Thread.Sleep(5000);  
                    txt_ShowFibronacci.Text += Fibonacci_Hesapla
                   (Convert.ToInt32(txt_fibronacciOrder.Text))
                   .ToString();
                   
                }
                else
                {
                    MessageBox.Show("Lütfen 0 büyük 35 ten küçük bir değer giriniz.");
                    return;
                }
               
            }
            catch
            {
                MessageBox.Show("Geçerli bir sayı Giriniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_ShowFibronacci.Text = "Sonuç";
        }

        private void txt_fibronacciOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
