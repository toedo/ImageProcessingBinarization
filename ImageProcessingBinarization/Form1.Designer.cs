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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OriginalImage = new PictureBox();
            BinarizedImage = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            EdgeMap = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            SobelFilterImage = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            logBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinarizedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EdgeMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SobelFilterImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // OriginalImage
            // 
            OriginalImage.BackColor = SystemColors.Control;
            OriginalImage.Image = (Image)resources.GetObject("OriginalImage.Image");
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
            button1.Click += BinarizeButton;
            // 
            // button2
            // 
            button2.Location = new Point(804, 12);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 5;
            button2.Text = "More options";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EdgeMap
            // 
            EdgeMap.Location = new Point(97, 549);
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
            button3.Click += EdgeDetectButton;
            // 
            // button4
            // 
            button4.Location = new Point(685, 612);
            button4.Name = "button4";
            button4.Size = new Size(129, 62);
            button4.TabIndex = 8;
            button4.Text = "Detect Barcode";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SobelFilterImage
            // 
            SobelFilterImage.AccessibleDescription = "public";
            SobelFilterImage.Location = new Point(940, 543);
            SobelFilterImage.Name = "SobelFilterImage";
            SobelFilterImage.Size = new Size(513, 455);
            SobelFilterImage.SizeMode = PictureBoxSizeMode.StretchImage;
            SobelFilterImage.TabIndex = 9;
            SobelFilterImage.TabStop = false;
            SobelFilterImage.Click += pictureBox1_Click_2;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(734, 198);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Debug";
            label1.Click += label1_Click_1;
            // 
            // logBox
            // 
            logBox.Location = new Point(677, 229);
            logBox.Name = "logBox";
            logBox.Size = new Size(168, 23);
            logBox.TabIndex = 10;
            logBox.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 1016);
            Controls.Add(label1);
            Controls.Add(logBox);
            Controls.Add(SobelFilterImage);
            Controls.Add(button4);
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
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)OriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinarizedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)EdgeMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)SobelFilterImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
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
        private Button button4;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private TextBox logBox;
        public PictureBox SobelFilterImage;
        public PictureBox SobelFilterImagePublic => SobelFilterImage;
    }
}
