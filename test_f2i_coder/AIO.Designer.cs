namespace f2i_coder
{
    partial class AIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIO));
            this.compiler_title = new System.Windows.Forms.Label();
            this.decompiler_title = new System.Windows.Forms.Label();
            this.c_select_file = new System.Windows.Forms.Button();
            this.c_compile_data = new System.Windows.Forms.Button();
            this.c_save_image = new System.Windows.Forms.Button();
            this.d_save_file = new System.Windows.Forms.Button();
            this.d_decompile_data = new System.Windows.Forms.Button();
            this.d_select_file = new System.Windows.Forms.Button();
            this.c_select_info = new System.Windows.Forms.Label();
            this.c_compile_info = new System.Windows.Forms.Label();
            this.c_save_info = new System.Windows.Forms.Label();
            this.d_select_info = new System.Windows.Forms.Label();
            this.d_decompile_info = new System.Windows.Forms.Label();
            this.d_save_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // compiler_title
            // 
            this.compiler_title.AutoSize = true;
            this.compiler_title.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compiler_title.ForeColor = System.Drawing.SystemColors.Control;
            this.compiler_title.Location = new System.Drawing.Point(89, 9);
            this.compiler_title.Name = "compiler_title";
            this.compiler_title.Size = new System.Drawing.Size(326, 36);
            this.compiler_title.TabIndex = 0;
            this.compiler_title.Text = "Compiler | file to image";
            // 
            // decompiler_title
            // 
            this.decompiler_title.AutoSize = true;
            this.decompiler_title.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decompiler_title.ForeColor = System.Drawing.SystemColors.Control;
            this.decompiler_title.Location = new System.Drawing.Point(578, 9);
            this.decompiler_title.Name = "decompiler_title";
            this.decompiler_title.Size = new System.Drawing.Size(357, 36);
            this.decompiler_title.TabIndex = 1;
            this.decompiler_title.Text = "Decompiler | image to file";
            // 
            // c_select_file
            // 
            this.c_select_file.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c_select_file.Location = new System.Drawing.Point(24, 66);
            this.c_select_file.Name = "c_select_file";
            this.c_select_file.Size = new System.Drawing.Size(134, 29);
            this.c_select_file.TabIndex = 2;
            this.c_select_file.Text = "Select File";
            this.c_select_file.UseVisualStyleBackColor = true;
            this.c_select_file.Click += new System.EventHandler(this.c_select_file_Click);
            // 
            // c_compile_data
            // 
            this.c_compile_data.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c_compile_data.Location = new System.Drawing.Point(181, 66);
            this.c_compile_data.Name = "c_compile_data";
            this.c_compile_data.Size = new System.Drawing.Size(134, 29);
            this.c_compile_data.TabIndex = 3;
            this.c_compile_data.Text = "Compile Data";
            this.c_compile_data.UseVisualStyleBackColor = true;
            this.c_compile_data.Click += new System.EventHandler(this.c_compile_data_Click);
            // 
            // c_save_image
            // 
            this.c_save_image.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c_save_image.Location = new System.Drawing.Point(338, 66);
            this.c_save_image.Name = "c_save_image";
            this.c_save_image.Size = new System.Drawing.Size(134, 29);
            this.c_save_image.TabIndex = 4;
            this.c_save_image.Text = "Save Image";
            this.c_save_image.UseVisualStyleBackColor = true;
            this.c_save_image.Click += new System.EventHandler(this.c_save_image_Click);
            // 
            // d_save_file
            // 
            this.d_save_file.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d_save_file.Location = new System.Drawing.Point(844, 66);
            this.d_save_file.Name = "d_save_file";
            this.d_save_file.Size = new System.Drawing.Size(134, 29);
            this.d_save_file.TabIndex = 7;
            this.d_save_file.Text = "Save File";
            this.d_save_file.UseVisualStyleBackColor = true;
            this.d_save_file.Click += new System.EventHandler(this.d_save_file_Click);
            // 
            // d_decompile_data
            // 
            this.d_decompile_data.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d_decompile_data.Location = new System.Drawing.Point(687, 66);
            this.d_decompile_data.Name = "d_decompile_data";
            this.d_decompile_data.Size = new System.Drawing.Size(134, 29);
            this.d_decompile_data.TabIndex = 6;
            this.d_decompile_data.Text = "Decompile Data";
            this.d_decompile_data.UseVisualStyleBackColor = true;
            this.d_decompile_data.Click += new System.EventHandler(this.d_decompile_data_Click);
            // 
            // d_select_file
            // 
            this.d_select_file.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d_select_file.Location = new System.Drawing.Point(530, 66);
            this.d_select_file.Name = "d_select_file";
            this.d_select_file.Size = new System.Drawing.Size(134, 29);
            this.d_select_file.TabIndex = 5;
            this.d_select_file.Text = "Select File";
            this.d_select_file.UseVisualStyleBackColor = true;
            this.d_select_file.Click += new System.EventHandler(this.d_select_file_Click);
            // 
            // c_select_info
            // 
            this.c_select_info.AutoSize = true;
            this.c_select_info.ForeColor = System.Drawing.SystemColors.Control;
            this.c_select_info.Location = new System.Drawing.Point(64, 98);
            this.c_select_info.Name = "c_select_info";
            this.c_select_info.Size = new System.Drawing.Size(49, 20);
            this.c_select_info.TabIndex = 8;
            this.c_select_info.Text = "Done!";
            // 
            // c_compile_info
            // 
            this.c_compile_info.AutoSize = true;
            this.c_compile_info.ForeColor = System.Drawing.SystemColors.Control;
            this.c_compile_info.Location = new System.Drawing.Point(221, 98);
            this.c_compile_info.Name = "c_compile_info";
            this.c_compile_info.Size = new System.Drawing.Size(49, 20);
            this.c_compile_info.TabIndex = 9;
            this.c_compile_info.Text = "Done!";
            // 
            // c_save_info
            // 
            this.c_save_info.AutoSize = true;
            this.c_save_info.ForeColor = System.Drawing.SystemColors.Control;
            this.c_save_info.Location = new System.Drawing.Point(380, 98);
            this.c_save_info.Name = "c_save_info";
            this.c_save_info.Size = new System.Drawing.Size(49, 20);
            this.c_save_info.TabIndex = 10;
            this.c_save_info.Text = "Done!";
            // 
            // d_select_info
            // 
            this.d_select_info.AutoSize = true;
            this.d_select_info.ForeColor = System.Drawing.SystemColors.Control;
            this.d_select_info.Location = new System.Drawing.Point(573, 98);
            this.d_select_info.Name = "d_select_info";
            this.d_select_info.Size = new System.Drawing.Size(49, 20);
            this.d_select_info.TabIndex = 11;
            this.d_select_info.Text = "Done!";
            // 
            // d_decompile_info
            // 
            this.d_decompile_info.AutoSize = true;
            this.d_decompile_info.ForeColor = System.Drawing.SystemColors.Control;
            this.d_decompile_info.Location = new System.Drawing.Point(727, 98);
            this.d_decompile_info.Name = "d_decompile_info";
            this.d_decompile_info.Size = new System.Drawing.Size(49, 20);
            this.d_decompile_info.TabIndex = 12;
            this.d_decompile_info.Text = "Done!";
            // 
            // d_save_info
            // 
            this.d_save_info.AutoSize = true;
            this.d_save_info.ForeColor = System.Drawing.SystemColors.Control;
            this.d_save_info.Location = new System.Drawing.Point(886, 98);
            this.d_save_info.Name = "d_save_info";
            this.d_save_info.Size = new System.Drawing.Size(49, 20);
            this.d_save_info.TabIndex = 13;
            this.d_save_info.Text = "Done!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(129, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.d_save_info);
            this.Controls.Add(this.d_decompile_info);
            this.Controls.Add(this.d_select_info);
            this.Controls.Add(this.c_save_info);
            this.Controls.Add(this.c_compile_info);
            this.Controls.Add(this.c_select_info);
            this.Controls.Add(this.d_save_file);
            this.Controls.Add(this.d_decompile_data);
            this.Controls.Add(this.d_select_file);
            this.Controls.Add(this.c_save_image);
            this.Controls.Add(this.c_compile_data);
            this.Controls.Add(this.c_select_file);
            this.Controls.Add(this.decompiler_title);
            this.Controls.Add(this.compiler_title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1019, 420);
            this.MinimumSize = new System.Drawing.Size(1019, 420);
            this.Name = "AIO";
            this.Text = "f2i - file to image converter";
            this.Load += new System.EventHandler(this.AIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label compiler_title;
        private Label decompiler_title;
        private Button c_select_file;
        private Button c_compile_data;
        private Button c_save_image;
        private Button d_save_file;
        private Button d_decompile_data;
        private Button d_select_file;
        private Label c_select_info;
        private Label c_compile_info;
        private Label c_save_info;
        private Label d_select_info;
        private Label d_decompile_info;
        private Label d_save_info;
        private PictureBox pictureBox1;
    }
}