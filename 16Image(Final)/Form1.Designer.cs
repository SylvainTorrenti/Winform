namespace _15Image_PictureBox_
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
            libPath = new ListBox();
            btAdd = new Button();
            btClear = new Button();
            btDelete = new Button();
            pImage = new Panel();
            pbImage = new PictureBox();
            pImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btImage
            // 
            btImage.Image = _16Image_Final_.Properties.Resources.iPhoto_photo_picture_camera_2661;
            btImage.Location = new Point(12, 12);
            btImage.Name = "btImage";
            btImage.Size = new Size(39, 32);
            btImage.TabIndex = 0;
            btImage.UseVisualStyleBackColor = true;
            btImage.Click += btImage_Click;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(57, 18);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(568, 23);
            tbPath.TabIndex = 1;
            // 
            // libPath
            // 
            libPath.FormattingEnabled = true;
            libPath.ItemHeight = 15;
            libPath.Location = new Point(12, 50);
            libPath.Name = "libPath";
            libPath.Size = new Size(613, 169);
            libPath.TabIndex = 2;
            libPath.SelectedIndexChanged += libPath_SelectedIndexChanged;
            // 
            // btAdd
            // 
            btAdd.Enabled = false;
            btAdd.Image = _16Image_Final_.Properties.Resources.addition_sign_icon_icons_com_73100;
            btAdd.ImageAlign = ContentAlignment.MiddleRight;
            btAdd.Location = new Point(644, 50);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(144, 43);
            btAdd.TabIndex = 4;
            btAdd.Text = "Ajouter";
            btAdd.TextAlign = ContentAlignment.MiddleLeft;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btClear
            // 
            btClear.Enabled = false;
            btClear.Image = _16Image_Final_.Properties.Resources.filesystems_garbage_full_670;
            btClear.ImageAlign = ContentAlignment.MiddleRight;
            btClear.Location = new Point(644, 176);
            btClear.Name = "btClear";
            btClear.Size = new Size(144, 43);
            btClear.TabIndex = 5;
            btClear.Text = "Vider";
            btClear.TextAlign = ContentAlignment.MiddleLeft;
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Enabled = false;
            btDelete.Image = _16Image_Final_.Properties.Resources.delete_delete_exit_1577;
            btDelete.ImageAlign = ContentAlignment.MiddleRight;
            btDelete.Location = new Point(644, 113);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(144, 43);
            btDelete.TabIndex = 6;
            btDelete.Text = "Supprimer";
            btDelete.TextAlign = ContentAlignment.MiddleLeft;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // pImage
            // 
            pImage.AutoScroll = true;
            pImage.BorderStyle = BorderStyle.FixedSingle;
            pImage.Controls.Add(pbImage);
            pImage.Location = new Point(12, 225);
            pImage.Name = "pImage";
            pImage.Size = new Size(776, 213);
            pImage.TabIndex = 7;
            // 
            // pbImage
            // 
            pbImage.InitialImage = null;
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(774, 211);
            pbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pImage);
            Controls.Add(btDelete);
            Controls.Add(btClear);
            Controls.Add(btAdd);
            Controls.Add(libPath);
            Controls.Add(tbPath);
            Controls.Add(btImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Images";
            pImage.ResumeLayout(false);
            pImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btImage;
        private TextBox tbPath;
        private ListBox libPath;
        private Button btAdd;
        private Button btClear;
        private Button btDelete;
        private Panel pImage;
        private PictureBox pbImage;
    }
}