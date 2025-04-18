namespace ImageProcessingBinarization
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
            OriginalImage = new PictureBox();
            BinarizedImage = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            EdgeMap = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)OriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinarizedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EdgeMap).BeginInit();
            SuspendLayout();
            // 
            // OriginalImage
            // 
            OriginalImage.BackColor = SystemColors.Control;
            OriginalImage.Image = Properties.Resources.stock_photo_barcode_label_on_shipping_box_being_scanned_with_red_laser_device_390200806;
            OriginalImage.Location = new Point(97, 12);
            OriginalImage.Name = "OriginalImage";
            OriginalImage.Size = new Size(516, 486);
            OriginalImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OriginalImage.TabIndex = 0;
            OriginalImage.TabStop = false;
            OriginalImage.Click += pictureBox1_Click;
            // 
            // BinarizedImage
            // 
            BinarizedImage.Location = new Point(951, 12);
            BinarizedImage.Name = "BinarizedImage";
            BinarizedImage.Size = new Size(502, 486);
            BinarizedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            BinarizedImage.TabIndex = 1;
            BinarizedImage.TabStop = false;
            BinarizedImage.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 504);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Original image";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1149, 504);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Post-processing image";
            // 
            // button1
            // 
            button1.Location = new Point(677, 396);
            button1.Name = "button1";
            button1.Size = new Size(140, 79);
            button1.TabIndex = 4;
            button1.Text = "Binarize image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(804, 12);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 5;
            button2.Text = "Next Page -->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EdgeMap
            // 
            EdgeMap.Location = new Point(97, 594);
            EdgeMap.Name = "EdgeMap";
            EdgeMap.Size = new Size(516, 455);
            EdgeMap.SizeMode = PictureBoxSizeMode.StretchImage;
            EdgeMap.TabIndex = 6;
            EdgeMap.TabStop = false;
            EdgeMap.Click += pictureBox1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(681, 514);
            button3.Name = "button3";
            button3.Size = new Size(134, 73);
            button3.TabIndex = 7;
            button3.Text = "Do edge detection";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 1061);
            Controls.Add(button3);
            Controls.Add(EdgeMap);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BinarizedImage);
            Controls.Add(OriginalImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinarizedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)EdgeMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox OriginalImage;
        private PictureBox BinarizedImage;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private PictureBox EdgeMap;
        private Button button3;
    }
}
