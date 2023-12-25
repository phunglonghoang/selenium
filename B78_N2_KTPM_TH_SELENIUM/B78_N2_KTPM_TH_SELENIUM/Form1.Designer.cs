
namespace B78_N2_KTPM_TH_SELENIUM
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
            this.btnOpen27 = new System.Windows.Forms.Button();
            this.btn_bai2_27 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen27
            // 
            this.btnOpen27.Location = new System.Drawing.Point(376, 55);
            this.btnOpen27.Name = "btnOpen27";
            this.btnOpen27.Size = new System.Drawing.Size(75, 23);
            this.btnOpen27.TabIndex = 0;
            this.btnOpen27.Text = "open link";
            this.btnOpen27.UseVisualStyleBackColor = true;
            this.btnOpen27.Click += new System.EventHandler(this.btnOpen27_Click);
            // 
            // btn_bai2_27
            // 
            this.btn_bai2_27.Location = new System.Drawing.Point(376, 175);
            this.btn_bai2_27.Name = "btn_bai2_27";
            this.btn_bai2_27.Size = new System.Drawing.Size(75, 23);
            this.btn_bai2_27.TabIndex = 1;
            this.btn_bai2_27.Text = "Bài 2";
            this.btn_bai2_27.UseVisualStyleBackColor = true;
            this.btn_bai2_27.Click += new System.EventHandler(this.btn_bai2_27_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bai2_27);
            this.Controls.Add(this.btnOpen27);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen27;
        private System.Windows.Forms.Button btn_bai2_27;
    }
}

