namespace _14Image_listeSansDoublon_
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
            SuspendLayout();
            // 
            // btImage
            // 
            btImage.Image = Properties.Resources.photo_photography_image_picture_108525;
            btImage.Location = new Point(12, 12);
            btImage.Name = "btImage";
            btImage.Size = new Size(41, 34);
            btImage.TabIndex = 0;
            btImage.UseVisualStyleBackColor = true;
            btImage.Click += btImage_Click;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(59, 19);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(567, 23);
            tbPath.TabIndex = 1;
            // 
            // libPath
            // 
            libPath.FormattingEnabled = true;
            libPath.ItemHeight = 15;
            libPath.Location = new Point(12, 52);
            libPath.Name = "libPath";
            libPath.Size = new Size(614, 319);
            libPath.TabIndex = 2;
            libPath.SelectedIndexChanged += libPath_SelectedIndexChanged;
            // 
            // btAdd
            // 
            btAdd.Enabled = false;
            btAdd.Image = Properties.Resources.addition_sign_icon_icons_com_73100;
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(645, 52);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(142, 57);
            btAdd.TabIndex = 3;
            btAdd.Text = "Ajouter";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btClear
            // 
            btClear.Enabled = false;
            btClear.Image = Properties.Resources.filesystems_garbage_full_670;
            btClear.ImageAlign = ContentAlignment.MiddleLeft;
            btClear.Location = new Point(645, 314);
            btClear.Name = "btClear";
            btClear.Size = new Size(142, 57);
            btClear.TabIndex = 4;
            btClear.Text = "Vider";
            btClear.TextAlign = ContentAlignment.MiddleRight;
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDelete
            // 
            btDelete.Enabled = false;
            btDelete.Image = Properties.Resources.delete_delete_exit_1577;
            btDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btDelete.Location = new Point(645, 183);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(142, 57);
            btDelete.TabIndex = 5;
            btDelete.Text = "Supprimer";
            btDelete.TextAlign = ContentAlignment.MiddleRight;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 404);
            Controls.Add(btDelete);
            Controls.Add(btClear);
            Controls.Add(btAdd);
            Controls.Add(libPath);
            Controls.Add(tbPath);
            Controls.Add(btImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
    }
}