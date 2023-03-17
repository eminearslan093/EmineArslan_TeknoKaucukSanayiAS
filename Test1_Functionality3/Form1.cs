using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1_Functionality3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MatrixSize = 0;
        int[,] Matrix;
        private void btn_matrisgoster_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (int.Parse(txt_MatrixSize.Text) == 0 || int.Parse(txt_MatrixSize.Text) > 15)
                {
                    MessageBox.Show("Lütfen 1 - 15 arasında bir değer giriniz!");
                    txt_MatrixSize.Text = "";
                    return;
                }
                MatrixSize = int.Parse(txt_MatrixSize.Text);
                Matrix = new int[MatrixSize + 1, MatrixSize + 1];
                //satır ve stunları yazdırma 
                MatrixLineColumnCalculation();
                ////çarpma işlemi
                MatrixMultiplication();
                //Ekrana yazdırma işlemi
                PressTheScreen();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmeyen bir durum oluştu.");
            }
           

            Console.ReadKey();
        }

        private void MatrixLineColumnCalculation()
        {
            for (int i = 0; i <= MatrixSize; i++)
            {
                for (int j = 0; j <= MatrixSize; j++)
                {
                    if (i == 0)
                    {
                        Matrix[i, j] = j;
                        Matrix[j, i] = j;
                    }
                    else
                        break;
                }
            }
        }
        private void MatrixMultiplication()
        {
            for (int i = 1; i < MatrixSize + 1; i++)
            {
                for (int j = 1; j < MatrixSize + 1; j++)
                {
                    Matrix[i, j] = i * j;
                }
            }
        }

        private void PressTheScreen()
        {
            for (int i = 0; i < MatrixSize + 1; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < MatrixSize + 1; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
            }
        }

        private void txt_MatrixSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece pozitif tam sayılar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
