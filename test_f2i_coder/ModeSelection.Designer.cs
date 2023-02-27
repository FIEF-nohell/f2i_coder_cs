namespace f2i_coder
{
    partial class f2i
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
            this.compile_btn = new System.Windows.Forms.Button();
            this.decompile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compile_btn
            // 
            this.compile_btn.Location = new System.Drawing.Point(12, 26);
            this.compile_btn.Name = "compile_btn";
            this.compile_btn.Size = new System.Drawing.Size(164, 29);
            this.compile_btn.TabIndex = 0;
            this.compile_btn.Text = "compile file";
            this.compile_btn.UseVisualStyleBackColor = true;
            this.compile_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // decompile_btn
            // 
            this.decompile_btn.Location = new System.Drawing.Point(235, 26);
            this.decompile_btn.Name = "decompile_btn";
            this.decompile_btn.Size = new System.Drawing.Size(164, 29);
            this.decompile_btn.TabIndex = 1;
            this.decompile_btn.Text = "decompile file";
            this.decompile_btn.UseVisualStyleBackColor = true;
            this.decompile_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // f2i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 80);
            this.Controls.Add(this.decompile_btn);
            this.Controls.Add(this.compile_btn);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 127);
            this.Name = "f2i";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "f2i - file to image converter";
            this.ResumeLayout(false);

        }

        #endregion

        private Button compile_btn;
        private Button decompile_btn;
    }
}