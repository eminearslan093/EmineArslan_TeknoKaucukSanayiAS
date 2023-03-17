using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using System.Security;
using System.Globalization;
using System.Data.SqlTypes;

namespace Test1_Functionality4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo dosyabilgisi = new FileInfo(dialog.FileName);
                    dialog.Filter = "Text|*.txt";
                    //label1.Text = dosyabilgisi.FullName;   // dosya yolunun tutulması

                    var sayilar = File.ReadAllLines(dosyabilgisi.FullName)
                                      .SelectMany(l => l.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                      .Select(l => float.TryParse(l, NumberStyles.Any, new CultureInfo("tr-TR"), out float sayi) ? sayi : 0)
                                      .OrderByDescending(l => l);

                    // bulduğum diziyi listview'e atama.
                    foreach (var s in sayilar)
                    {
                        listBox1.Items.Add(s.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
