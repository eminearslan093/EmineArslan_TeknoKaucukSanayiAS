namespace Test1_Functionality2
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
            this.btn_PressTheScreen = new System.Windows.Forms.Button();
            this.txt_Screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_PressTheScreen
            // 
            this.btn_PressTheScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PressTheScreen.Location = new System.Drawing.Point(23, 301);
            this.btn_PressTheScreen.Name = "btn_PressTheScreen";
            this.btn_PressTheScreen.Size = new System.Drawing.Size(447, 23);
            this.btn_PressTheScreen.TabIndex = 1;
            this.btn_PressTheScreen.Text = "PressTheScreen";
            this.btn_PressTheScreen.UseVisualStyleBackColor = true;
            this.btn_PressTheScreen.Click += new System.EventHandler(this.btn_PressTheScreen_Click);
            // 
            // txt_Screen
            // 
            this.txt_Screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Screen.Enabled = false;
            this.txt_Screen.Location = new System.Drawing.Point(23, 12);
            this.txt_Screen.Multiline = true;
            this.txt_Screen.Name = "txt_Screen";
            this.txt_Screen.Size = new System.Drawing.Size(447, 254);
            this.txt_Screen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(498, 350);
            this.Controls.Add(this.txt_Screen);
            this.Controls.Add(this.btn_PressTheScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tekno Kauçuk Sanayi A.ş.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PressTheScreen;
        private System.Windows.Forms.TextBox txt_Screen;
    }
}

