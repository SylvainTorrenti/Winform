namespace TousEnsemble
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
            btAge = new Button();
            btCalcul = new Button();
            btImage = new Button();
            lbMain = new Label();
            SuspendLayout();
            // 
            // btAge
            // 
            btAge.Image = Properties.Resources.calendar_day_month_date_year_schedule_icon_175599;
            btAge.ImageAlign = ContentAlignment.MiddleLeft;
            btAge.Location = new Point(12, 79);
            btAge.Name = "btAge";
            btAge.Size = new Size(87, 80);
            btAge.TabIndex = 0;
            btAge.Text = "Age";
            btAge.TextAlign = ContentAlignment.MiddleRight;
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // btCalcul
            // 
            btCalcul.Image = Properties.Resources.scienceandfiction_calculate_99165;
            btCalcul.ImageAlign = ContentAlignment.MiddleLeft;
            btCalcul.Location = new Point(305, 79);
            btCalcul.Name = "btCalcul";
            btCalcul.Size = new Size(101, 80);
            btCalcul.TabIndex = 1;
            btCalcul.Text = "Calculer";
            btCalcul.TextAlign = ContentAlignment.MiddleRight;
            btCalcul.UseVisualStyleBackColor = true;
            // 
            // btImage
            // 
            btImage.Image = Properties.Resources.iPhoto_photo_picture_camera_2661;
            btImage.ImageAlign = ContentAlignment.MiddleLeft;
            btImage.Location = new Point(612, 79);
            btImage.Name = "btImage";
            btImage.Size = new Size(92, 80);
            btImage.TabIndex = 2;
            btImage.Text = "Image";
            btImage.TextAlign = ContentAlignment.MiddleRight;
            btImage.UseVisualStyleBackColor = true;
            btImage.Click += btImage_Click;
            // 
            // lbMain
            // 
            lbMain.AutoSize = true;
            lbMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMain.Location = new Point(251, 9);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(231, 25);
            lbMain.TabIndex = 3;
            lbMain.Text = "Choisissez une operations";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 238);
            Controls.Add(lbMain);
            Controls.Add(btImage);
            Controls.Add(btCalcul);
            Controls.Add(btAge);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Melting pot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAge;
        private Button btCalcul;
        private Button btImage;
        private Label lbMain;
    }
}