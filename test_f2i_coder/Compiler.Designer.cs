﻿namespace f2i_coder
{
    partial class Compiler
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
            this.loadFIleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFIleButton
            // 
            this.loadFIleButton.Location = new System.Drawing.Point(12, 12);
            this.loadFIleButton.Name = "loadFIleButton";
            this.loadFIleButton.Size = new System.Drawing.Size(167, 29);
            this.loadFIleButton.TabIndex = 0;
            this.loadFIleButton.Text = "Load file";
            this.loadFIleButton.UseVisualStyleBackColor = true;
            this.loadFIleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compile File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadFIleButton);
            this.MaximizeBox = false;
            this.Name = "Compiler";
            this.ShowIcon = false;
            this.Text = "f2i - compiler";
            this.Load += new System.EventHandler(this.Compiler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button loadFIleButton;
        private Button button1;
    }
}