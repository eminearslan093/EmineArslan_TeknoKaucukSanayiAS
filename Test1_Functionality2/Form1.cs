using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1_Functionality2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 

        private void PressTheScreen()
        {

        }
        private void btn_PressTheScreen_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 200; i++)
            {
                try
                {
                    NumberControl(i);
                }
                catch (Exception)
                {

                    MessageBox.Show("Beklenmedik bir hata oluştu.");
                }

            }
        }

        private void NumberControl(int i)
        {
            if (i >= 100)
            {
                if (i % 15 == 0)
                {
                    txt_Screen.Text += eType.zagzig + "  ";
                }
                else if (i % 3 == 0)
                {
                    txt_Screen.Text += eType.zig + "  ";
                }
                else if (i % 5 == 0)
                {
                    txt_Screen.Text += eType.zag + "  ";
                }
                else
                {
                    txt_Screen.Text += i.ToString() + "  ";
                }
            }
            else
            {
                if (i % 15 == 0)
                {
                    txt_Screen.Text += eType.zigzag + "  ";
                }
                else if (i % 3 == 0)
                {
                    txt_Screen.Text += eType.zig + "  ";
                }
                else if (i % 5 == 0)
                {
                    txt_Screen.Text += eType.zag + "  ";
                }
                else
                {
                    txt_Screen.Text += i.ToString() + "  ";
                }
            }
        }
    }
}
