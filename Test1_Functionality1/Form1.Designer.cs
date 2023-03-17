namespace Test1_Functionality1
{
    partial class Frm_Functionality1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txtBox_Number1 = new System.Windows.Forms.TextBox();
            this.txtBox_Number3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Number2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.txtBox_Result);
            this.groupBox2.Location = new System.Drawing.Point(360, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 212);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuç";
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.Location = new System.Drawing.Point(28, 26);
            this.txtBox_Result.Multiline = true;
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.ReadOnly = true;
            this.txtBox_Result.Size = new System.Drawing.Size(190, 95);
            this.txtBox_Result.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.txtBox_Number1);
            this.groupBox1.Controls.Add(this.txtBox_Number3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_Number2);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı 1: ";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(148, 152);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(96, 23);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Hesapla";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txtBox_Number1
            // 
            this.txtBox_Number1.Location = new System.Drawing.Point(64, 23);
            this.txtBox_Number1.Name = "txtBox_Number1";
            this.txtBox_Number1.Size = new System.Drawing.Size(180, 20);
            this.txtBox_Number1.TabIndex = 0;
            this.txtBox_Number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Number1_KeyPress);
            // 
            // txtBox_Number3
            // 
            this.txtBox_Number3.Location = new System.Drawing.Point(64, 101);
            this.txtBox_Number3.Name = "txtBox_Number3";
            this.txtBox_Number3.Size = new System.Drawing.Size(180, 20);
            this.txtBox_Number3.TabIndex = 1;
            this.txtBox_Number3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Number3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayı 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2: ";
            // 
            // txtBox_Number2
            // 
            this.txtBox_Number2.Location = new System.Drawing.Point(64, 62);
            this.txtBox_Number2.Name = "txtBox_Number2";
            this.txtBox_Number2.Size = new System.Drawing.Size(180, 20);
            this.txtBox_Number2.TabIndex = 2;
            this.txtBox_Number2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Number2_KeyPress);
            // 
            // Frm_Functionality1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(658, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Functionality1";
            this.Text = "Tekno Kauçuk Sanayi A.Ş.";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txtBox_Number1;
        private System.Windows.Forms.TextBox txtBox_Number3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Number2;
    }
}

