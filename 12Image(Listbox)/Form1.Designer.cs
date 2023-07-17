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
            libPath = new ListBox();
            btAdd = new Button();
            btClear = new Button();
            btDelete = new Button();
            ofdImage = new OpenFileDialog();
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
            tbPath.Size = new Size(636, 23);
            tbPath.TabIndex = 1;
            // 
            // libPath
            // 
            libPath.FormattingEnabled = true;
            libPath.ItemHeight = 15;
            libPath.Location = new Point(12, 52);
            libPath.Name = "libPath";
            libPath.Size = new Size(684, 229);
            libPath.TabIndex = 2;
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.addition_sign_icon_icons_com_73100;
            btAdd.ImageAlign = ContentAlignment.MiddleRight;
            btAdd.Location = new Point(733, 52);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(112, 42);
            btAdd.TabIndex = 3;
            btAdd.Text = "Ajouter";
            btAdd.TextAlign = ContentAlignment.MiddleLeft;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btClear
            // 
            btClear.Image = Properties.Resources.filesystems_garbage_full_670;
            btClear.ImageAlign = ContentAlignment.MiddleRight;
            btClear.Location = new Point(733, 239);
            btClear.Name = "btClear";
            btClear.Size = new Size(112, 42);
            btClear.TabIndex = 4;
            btClear.Text = "Vider";
            btClear.TextAlign = ContentAlignment.MiddleLeft;
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Image = Properties.Resources.delete_delete_exit_1577;
            btDelete.ImageAlign = ContentAlignment.MiddleRight;
            btDelete.Location = new Point(733, 141);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 42);
            btDelete.TabIndex = 5;
            btDelete.Text = "Supprimer";
            btDelete.TextAlign = ContentAlignment.MiddleLeft;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // ofdImage
            // 
            ofdImage.FileName = "openFileDialog1";
            ofdImage.Filter = "Images(*.jpeg/*.jpg/*.png)|*.jpeg;*.jpg;*.png";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 325);
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
        private OpenFileDialog ofdImage;
    }
}