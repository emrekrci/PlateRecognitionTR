namespace PlateRecognitionTR
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
            this.components = new System.ComponentModel.Container();
            this.imgOriginal = new Emgu.CV.UI.ImageBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.btnSetGray = new System.Windows.Forms.Button();
            this.btnSetFilter = new System.Windows.Forms.Button();
            this.btnGetCanny = new System.Windows.Forms.Button();
            this.btnCropPlate = new System.Windows.Forms.Button();
            this.btnDetectPlate = new System.Windows.Forms.Button();
            this.imgClone = new Emgu.CV.UI.ImageBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imgPlate = new Emgu.CV.UI.ImageBox();
            this.imgCannyPlate = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCannyPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOriginal
            // 
            this.imgOriginal.Location = new System.Drawing.Point(13, 13);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(345, 244);
            this.imgOriginal.TabIndex = 2;
            this.imgOriginal.TabStop = false;
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(722, 13);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetImage.TabIndex = 3;
            this.btnGetImage.Text = "GetImage";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // btnSetGray
            // 
            this.btnSetGray.Location = new System.Drawing.Point(722, 42);
            this.btnSetGray.Name = "btnSetGray";
            this.btnSetGray.Size = new System.Drawing.Size(75, 23);
            this.btnSetGray.TabIndex = 4;
            this.btnSetGray.Text = "Gray";
            this.btnSetGray.UseVisualStyleBackColor = true;
            this.btnSetGray.Click += new System.EventHandler(this.btnSetGray_Click);
            // 
            // btnSetFilter
            // 
            this.btnSetFilter.Location = new System.Drawing.Point(722, 72);
            this.btnSetFilter.Name = "btnSetFilter";
            this.btnSetFilter.Size = new System.Drawing.Size(75, 23);
            this.btnSetFilter.TabIndex = 5;
            this.btnSetFilter.Text = "Filter";
            this.btnSetFilter.UseVisualStyleBackColor = true;
            this.btnSetFilter.Click += new System.EventHandler(this.btnSetFilter_Click);
            // 
            // btnGetCanny
            // 
            this.btnGetCanny.Location = new System.Drawing.Point(722, 102);
            this.btnGetCanny.Name = "btnGetCanny";
            this.btnGetCanny.Size = new System.Drawing.Size(75, 23);
            this.btnGetCanny.TabIndex = 6;
            this.btnGetCanny.Text = "Canny";
            this.btnGetCanny.UseVisualStyleBackColor = true;
            this.btnGetCanny.Click += new System.EventHandler(this.btnGetCanny_Click);
            // 
            // btnCropPlate
            // 
            this.btnCropPlate.Location = new System.Drawing.Point(722, 132);
            this.btnCropPlate.Name = "btnCropPlate";
            this.btnCropPlate.Size = new System.Drawing.Size(75, 23);
            this.btnCropPlate.TabIndex = 7;
            this.btnCropPlate.Text = "Crop";
            this.btnCropPlate.UseVisualStyleBackColor = true;
            this.btnCropPlate.Click += new System.EventHandler(this.btnCropPlate_Click);
            // 
            // btnDetectPlate
            // 
            this.btnDetectPlate.Location = new System.Drawing.Point(722, 162);
            this.btnDetectPlate.Name = "btnDetectPlate";
            this.btnDetectPlate.Size = new System.Drawing.Size(75, 23);
            this.btnDetectPlate.TabIndex = 8;
            this.btnDetectPlate.Text = "Detect";
            this.btnDetectPlate.UseVisualStyleBackColor = true;
            this.btnDetectPlate.Click += new System.EventHandler(this.btnDetectPlate_Click);
            // 
            // imgClone
            // 
            this.imgClone.Location = new System.Drawing.Point(399, 12);
            this.imgClone.Name = "imgClone";
            this.imgClone.Size = new System.Drawing.Size(308, 245);
            this.imgClone.TabIndex = 2;
            this.imgClone.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(399, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 108);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // imgPlate
            // 
            this.imgPlate.Location = new System.Drawing.Point(13, 263);
            this.imgPlate.Name = "imgPlate";
            this.imgPlate.Size = new System.Drawing.Size(346, 72);
            this.imgPlate.TabIndex = 2;
            this.imgPlate.TabStop = false;
            // 
            // imgCannyPlate
            // 
            this.imgCannyPlate.Location = new System.Drawing.Point(13, 341);
            this.imgCannyPlate.Name = "imgCannyPlate";
            this.imgCannyPlate.Size = new System.Drawing.Size(345, 77);
            this.imgCannyPlate.TabIndex = 2;
            this.imgCannyPlate.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgCannyPlate);
            this.Controls.Add(this.imgPlate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.imgClone);
            this.Controls.Add(this.btnDetectPlate);
            this.Controls.Add(this.btnCropPlate);
            this.Controls.Add(this.btnGetCanny);
            this.Controls.Add(this.btnSetFilter);
            this.Controls.Add(this.btnSetGray);
            this.Controls.Add(this.btnGetImage);
            this.Controls.Add(this.imgOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCannyPlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgOriginal;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.Button btnSetGray;
        private System.Windows.Forms.Button btnSetFilter;
        private System.Windows.Forms.Button btnGetCanny;
        private System.Windows.Forms.Button btnCropPlate;
        private System.Windows.Forms.Button btnDetectPlate;
        private Emgu.CV.UI.ImageBox imgClone;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Emgu.CV.UI.ImageBox imgPlate;
        private Emgu.CV.UI.ImageBox imgCannyPlate;
    }
}

