namespace ImageProcessingBinarization
{
    partial class Form2
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
            BarcodeOutliner = new PictureBox();
            pictureBox1 = new PictureBox();
            BarcodeDetectButton = new Button();
            BarcodeCode = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)BarcodeOutliner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarcodeOutliner
            // 
            BarcodeOutliner.Location = new Point(92, 39);
            BarcodeOutliner.Name = "BarcodeOutliner";
            BarcodeOutliner.Size = new Size(502, 486);
            BarcodeOutliner.SizeMode = PictureBoxSizeMode.StretchImage;
            BarcodeOutliner.TabIndex = 2;
            BarcodeOutliner.TabStop = false;
            BarcodeOutliner.Click += BinarizedImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(907, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 486);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BarcodeDetectButton
            // 
            BarcodeDetectButton.Location = new Point(646, 320);
            BarcodeDetectButton.Name = "BarcodeDetectButton";
            BarcodeDetectButton.Size = new Size(212, 49);
            BarcodeDetectButton.TabIndex = 6;
            BarcodeDetectButton.Text = "Detect Barcode";
            BarcodeDetectButton.UseVisualStyleBackColor = true;
            BarcodeDetectButton.Click += BarcodeDetectButton_Click;
            // 
            // BarcodeCode
            // 
            BarcodeCode.Location = new Point(472, 624);
            BarcodeCode.Name = "BarcodeCode";
            BarcodeCode.Size = new Size(599, 254);
            BarcodeCode.TabIndex = 7;
            BarcodeCode.Text = "";
            BarcodeCode.TextChanged += richTextBox1_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 1189);
            Controls.Add(BarcodeCode);
            Controls.Add(BarcodeDetectButton);
            Controls.Add(pictureBox1);
            Controls.Add(BarcodeOutliner);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)BarcodeOutliner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BarcodeOutliner;
        private PictureBox pictureBox1;
        private Button BarcodeDetectButton;
        private RichTextBox BarcodeCode;
    }
}