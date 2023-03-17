namespace Test1_Functionality3
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
            this.btn_MatrisCalculate = new System.Windows.Forms.Button();
            this.txt_MatrixSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_MatrisCalculate
            // 
            this.btn_MatrisCalculate.Location = new System.Drawing.Point(182, 59);
            this.btn_MatrisCalculate.Name = "btn_MatrisCalculate";
            this.btn_MatrisCalculate.Size = new System.Drawing.Size(75, 23);
            this.btn_MatrisCalculate.TabIndex = 1;
            this.btn_MatrisCalculate.Text = "button1";
            this.btn_MatrisCalculate.UseVisualStyleBackColor = true;
            this.btn_MatrisCalculate.Click += new System.EventHandler(this.btn_matrisgoster_Click);
            // 
            // txt_MatrixSize
            // 
            this.txt_MatrixSize.Location = new System.Drawing.Point(12, 12);
            this.txt_MatrixSize.Name = "txt_MatrixSize";
            this.txt_MatrixSize.Size = new System.Drawing.Size(245, 20);
            this.txt_MatrixSize.TabIndex = 2;
            this.txt_MatrixSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatrixSize_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 116);
            this.Controls.Add(this.txt_MatrixSize);
            this.Controls.Add(this.btn_MatrisCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tekno Kauçuk Sanayi A.ş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_MatrisCalculate;
        private System.Windows.Forms.TextBox txt_MatrixSize;
    }
}

