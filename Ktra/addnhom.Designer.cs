﻿namespace Ktra
{
    partial class addnhom
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
            this.tbaddnamenhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbaddnamenhom
            // 
            this.tbaddnamenhom.Location = new System.Drawing.Point(157, 41);
            this.tbaddnamenhom.Name = "tbaddnamenhom";
            this.tbaddnamenhom.Size = new System.Drawing.Size(177, 20);
            this.tbaddnamenhom.TabIndex = 0;
            this.tbaddnamenhom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tên nhóm";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(259, 79);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // addnhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 114);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaddnamenhom);
            this.Name = "addnhom";
            this.Text = "addnhom";
            this.Load += new System.EventHandler(this.addnhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbaddnamenhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
    }
}