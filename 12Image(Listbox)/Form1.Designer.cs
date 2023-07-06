namespace _12Image_Listbox_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btImage = new Button();
            tbPath = new TextBox();
            SuspendLayout();
            // 
            // btImage
            // 
            btImage.Image = Properties.Resources.photo_photography_image_picture_108525;
            btImage.Location = new Point(12, 12);
            btImage.Name = "btImage";
            btImage.Size = new Size(42, 34);
            btImage.TabIndex = 0;
            btImage.UseVisualStyleBackColor = true;
            btImage.Click += btImage_Click;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(60, 19);
            tbPath.Name = "tbPath";
            tbPath.ReadOnly = true;
            tbPath.Size = new Size(753, 23);
            tbPath.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 325);
            Controls.Add(tbPath);
            Controls.Add(btImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Images";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btImage;
        private TextBox tbPath;
    }
}