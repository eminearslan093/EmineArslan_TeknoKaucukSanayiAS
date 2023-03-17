using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1_Functionality1
{
    public partial class Frm_Functionality1 : Form
    {
        public Frm_Functionality1()
        {
            InitializeComponent();
        }

        private double Number1;
        private double Number2;
        private double Number3;
        private double Result;

        #region Texbox_KeyPress
        private void txtBox_Number1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void txtBox_Number2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void txtBox_Number3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        #endregion


        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Number1.Text) || string.IsNullOrEmpty(txtBox_Number2.Text) || string.IsNullOrEmpty(txtBox_Number3.Text))
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz...");
            }
            else
            {
              
                try
                {
                    Number1 = double.Parse(txtBox_Number1.Text);
                    Number2 = double.Parse(txtBox_Number2.Text);
                    Number3 = double.Parse(txtBox_Number3.Text);
                    Result = Calculate(Number1, Number2, Number3);
                    PressTheScreen(Result);
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen değerleri doğru girdiğinizden emin olun.");
                }
                
                
            }
        }

        private double Calculate(double num1, double num2, double num3)
        {
            return (num1 + num2) * num3;
        }
        private void PressTheScreen(double result)
        {
            txtBox_Result.Text = "("+ Number1.ToString()+ "+"+ Number2.ToString() +")"+"*"+Number3.ToString()+ "=" + result.ToString();
        }


    }
}
