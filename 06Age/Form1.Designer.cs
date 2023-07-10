namespace _06Age
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
            lbName = new Label();
            lbBirthday = new Label();
            tbName = new TextBox();
            tbBirthday = new TextBox();
            btClose = new Button();
            btCalcul = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(53, 40);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Nom";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(53, 91);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(101, 15);
            lbBirthday.TabIndex = 1;
            lbBirthday.Text = "Date de naissance";
            // 
            // tbName
            // 
            tbName.Location = new Point(282, 37);
            tbName.Name = "tbName";
            tbName.Size = new Size(152, 23);
            tbName.TabIndex = 2;
            // 
            // tbBirthday
            // 
            tbBirthday.Location = new Point(282, 91);
            tbBirthday.Name = "tbBirthday";
            tbBirthday.Size = new Size(152, 23);
            tbBirthday.TabIndex = 3;
            // 
            // btClose
            // 
            btClose.Image = Properties.Resources.star_alt_icon_34347;
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(55, 177);
            btClose.Name = "btClose";
            btClose.Size = new Size(99, 33);
            btClose.TabIndex = 4;
            btClose.Text = "Fermer";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btCalcul
            // 
            btCalcul.Image = Properties.Resources.runner_sport_run_olympics_olympic_athletics_icon_123810;
            btCalcul.ImageAlign = ContentAlignment.MiddleLeft;
            btCalcul.Location = new Point(460, 177);
            btCalcul.Name = "btCalcul";
            btCalcul.Size = new Size(95, 33);
            btCalcul.TabIndex = 5;
            btCalcul.Text = "Calculer";
            btCalcul.TextAlign = ContentAlignment.MiddleRight;
            btCalcul.UseVisualStyleBackColor = true;
            btCalcul.Click += btCalcul_Click;
            // 
            // frmMain
            // 
            AcceptButton = btCalcul;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btClose;
            ClientSize = new Size(674, 238);
            Controls.Add(btCalcul);
            Controls.Add(btClose);
            Controls.Add(tbBirthday);
            Controls.Add(tbName);
            Controls.Add(lbBirthday);
            Controls.Add(lbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Age";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbBirthday;
        private TextBox tbName;
        private Button btClose;
        private Button btCalcul;
        internal TextBox tbBirthday;
    }
}