namespace test_f2i_coder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.load_image_button = new System.Windows.Forms.Button();
            this.decode_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_image_button
            // 
            this.load_image_button.Location = new System.Drawing.Point(12, 12);
            this.load_image_button.Name = "load_image_button";
            this.load_image_button.Size = new System.Drawing.Size(166, 29);
            this.load_image_button.TabIndex = 0;
            this.load_image_button.Text = "Load image";
            this.load_image_button.UseVisualStyleBackColor = true;
            this.load_image_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // decode_btn
            // 
            this.decode_btn.Location = new System.Drawing.Point(184, 12);
            this.decode_btn.Name = "decode_btn";
            this.decode_btn.Size = new System.Drawing.Size(166, 29);
            this.decode_btn.TabIndex = 11;
            this.decode_btn.Text = "Decode image";
            this.decode_btn.UseVisualStyleBackColor = true;
            this.decode_btn.Click += new System.EventHandler(this.decode_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "output";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(12, 482);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(38, 20);
            this.info_lbl.TabIndex = 16;
            this.info_lbl.Text = "Info:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 511);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decode_btn);
            this.Controls.Add(this.load_image_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "f2i - decompiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button load_image_button;
        private Button decode_btn;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label info_lbl;
    }
}