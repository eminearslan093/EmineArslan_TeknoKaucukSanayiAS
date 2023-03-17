namespace Test1_Functionality5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_ShowFibronacci = new System.Windows.Forms.TextBox();
            this.txt_fibronacciOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaçıncı sıradaki fibonacci değerini görmek istiyorsunuz?";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 74);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(268, 23);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "Hesapla";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_ShowFibronacci
            // 
            this.txt_ShowFibronacci.Enabled = false;
            this.txt_ShowFibronacci.Location = new System.Drawing.Point(12, 122);
            this.txt_ShowFibronacci.Name = "txt_ShowFibronacci";
            this.txt_ShowFibronacci.Size = new System.Drawing.Size(268, 20);
            this.txt_ShowFibronacci.TabIndex = 6;
            // 
            // txt_fibronacciOrder
            // 
            this.txt_fibronacciOrder.Location = new System.Drawing.Point(12, 37);
            this.txt_fibronacciOrder.Name = "txt_fibronacciOrder";
            this.txt_fibronacciOrder.Size = new System.Drawing.Size(268, 20);
            this.txt_fibronacciOrder.TabIndex = 5;
            this.txt_fibronacciOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fibronacciOrder_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 206);
            this.Controls.Add(this.txt_ShowFibronacci);
            this.Controls.Add(this.txt_fibronacciOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_ShowFibronacci;
        private System.Windows.Forms.TextBox txt_fibronacciOrder;
    }
}

