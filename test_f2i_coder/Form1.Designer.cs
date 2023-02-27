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
            this.load_image_button = new System.Windows.Forms.Button();
            this.image_container = new System.Windows.Forms.PictureBox();
            this.file_text = new System.Windows.Forms.Label();
            this.pixel_text = new System.Windows.Forms.Label();
            this.file_time = new System.Windows.Forms.Label();
            this.pixel_time = new System.Windows.Forms.Label();
            this.dim = new System.Windows.Forms.Label();
            this.img_dim = new System.Windows.Forms.Label();
            this.decode_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_container)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_image_button
            // 
            this.load_image_button.Location = new System.Drawing.Point(256, 165);
            this.load_image_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load_image_button.Name = "load_image_button";
            this.load_image_button.Size = new System.Drawing.Size(145, 22);
            this.load_image_button.TabIndex = 0;
            this.load_image_button.Text = "Load image";
            this.load_image_button.UseVisualStyleBackColor = true;
            this.load_image_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // image_container
            // 
            this.image_container.Location = new System.Drawing.Point(3, 3);
            this.image_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image_container.Name = "image_container";
            this.image_container.Size = new System.Drawing.Size(240, 240);
            this.image_container.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_container.TabIndex = 1;
            this.image_container.TabStop = false;
            // 
            // file_text
            // 
            this.file_text.AutoSize = true;
            this.file_text.Location = new System.Drawing.Point(256, 9);
            this.file_text.Name = "file_text";
            this.file_text.Size = new System.Drawing.Size(81, 15);
            this.file_text.TabIndex = 2;
            this.file_text.Text = "File load took:";
            // 
            // pixel_text
            // 
            this.pixel_text.AutoSize = true;
            this.pixel_text.Location = new System.Drawing.Point(256, 50);
            this.pixel_text.Name = "pixel_text";
            this.pixel_text.Size = new System.Drawing.Size(73, 15);
            this.pixel_text.TabIndex = 3;
            this.pixel_text.Text = "Data read in:";
            // 
            // file_time
            // 
            this.file_time.AutoSize = true;
            this.file_time.Location = new System.Drawing.Point(402, 9);
            this.file_time.Name = "file_time";
            this.file_time.Size = new System.Drawing.Size(0, 15);
            this.file_time.TabIndex = 4;
            // 
            // pixel_time
            // 
            this.pixel_time.AutoSize = true;
            this.pixel_time.Location = new System.Drawing.Point(402, 50);
            this.pixel_time.Name = "pixel_time";
            this.pixel_time.Size = new System.Drawing.Size(0, 15);
            this.pixel_time.TabIndex = 5;
            // 
            // dim
            // 
            this.dim.AutoSize = true;
            this.dim.Location = new System.Drawing.Point(256, 93);
            this.dim.Name = "dim";
            this.dim.Size = new System.Drawing.Size(110, 15);
            this.dim.TabIndex = 9;
            this.dim.Text = "Image dimensions: ";
            // 
            // img_dim
            // 
            this.img_dim.AutoSize = true;
            this.img_dim.Location = new System.Drawing.Point(402, 93);
            this.img_dim.Name = "img_dim";
            this.img_dim.Size = new System.Drawing.Size(0, 15);
            this.img_dim.TabIndex = 10;
            // 
            // decode_btn
            // 
            this.decode_btn.Location = new System.Drawing.Point(407, 165);
            this.decode_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decode_btn.Name = "decode_btn";
            this.decode_btn.Size = new System.Drawing.Size(145, 22);
            this.decode_btn.TabIndex = 11;
            this.decode_btn.Text = "Decode image";
            this.decode_btn.UseVisualStyleBackColor = true;
            this.decode_btn.Click += new System.EventHandler(this.decode_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.image_container);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 251);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.decode_btn);
            this.Controls.Add(this.img_dim);
            this.Controls.Add(this.dim);
            this.Controls.Add(this.pixel_time);
            this.Controls.Add(this.file_time);
            this.Controls.Add(this.pixel_text);
            this.Controls.Add(this.file_text);
            this.Controls.Add(this.load_image_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "f2i - decompiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_container)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button load_image_button;
        private PictureBox image_container;
        private Label file_text;
        private Label pixel_text;
        private Label file_time;
        private Label pixel_time;
        private Label dim;
        private Label img_dim;
        private Button decode_btn;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
    }
}