namespace ReducirImg
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
            btnSelectImage = new Button();
            cmbResolutions = new ComboBox();
            btnResizeImages = new Button();
            trackBarQuality = new TrackBar();
            lblQuality = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarQuality).BeginInit();
            SuspendLayout();
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(12, 28);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(161, 23);
            btnSelectImage.TabIndex = 0;
            btnSelectImage.Text = "Seleccionar Imagenes";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // cmbResolutions
            // 
            cmbResolutions.FormattingEnabled = true;
            cmbResolutions.Location = new Point(195, 28);
            cmbResolutions.Name = "cmbResolutions";
            cmbResolutions.Size = new Size(121, 23);
            cmbResolutions.TabIndex = 7;
            cmbResolutions.SelectedIndexChanged += cmbResolutions_SelectedIndexChanged;
            // 
            // btnResizeImages
            // 
            btnResizeImages.Location = new Point(226, 87);
            btnResizeImages.Name = "btnResizeImages";
            btnResizeImages.Size = new Size(75, 23);
            btnResizeImages.TabIndex = 8;
            btnResizeImages.Text = "Resized";
            btnResizeImages.UseVisualStyleBackColor = true;
            btnResizeImages.Click += btnResizeImages_Click;
            // 
            // trackBarQuality
            // 
            trackBarQuality.Location = new Point(353, 28);
            trackBarQuality.Maximum = 100;
            trackBarQuality.Name = "trackBarQuality";
            trackBarQuality.Size = new Size(105, 45);
            trackBarQuality.TabIndex = 10;
            trackBarQuality.Scroll += trackBarQuality_Scroll;
            // 
            // lblQuality
            // 
            lblQuality.AutoSize = true;
            lblQuality.Location = new Point(478, 31);
            lblQuality.Name = "lblQuality";
            lblQuality.Size = new Size(38, 15);
            lblQuality.TabIndex = 11;
            lblQuality.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 133);
            Controls.Add(lblQuality);
            Controls.Add(trackBarQuality);
            Controls.Add(btnResizeImages);
            Controls.Add(cmbResolutions);
            Controls.Add(btnSelectImage);
            Name = "Form1";
            Text = "Resized Image";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarQuality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectImage;
        private ComboBox cmbResolutions;
        private Button btnResizeImages;
        private TrackBar trackBarQuality;
        private Label lblQuality;
    }
}
