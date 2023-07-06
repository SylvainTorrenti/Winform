namespace TousEnsemble
{
    partial class Age
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Age));
            lbName = new Label();
            lbBirthday = new Label();
            tbName = new TextBox();
            dtpBirthday = new DateTimePicker();
            btClose = new Button();
            btCalcul = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(43, 16);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Nom";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(43, 63);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(101, 15);
            lbBirthday.TabIndex = 1;
            lbBirthday.Text = "Date de naissance";
            // 
            // tbName
            // 
            tbName.Location = new Point(196, 8);
            tbName.Name = "tbName";
            tbName.Size = new Size(214, 23);
            tbName.TabIndex = 2;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(196, 57);
            dtpBirthday.MaxDate = new DateTime(2023, 7, 6, 0, 0, 0, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(214, 23);
            dtpBirthday.TabIndex = 3;
            dtpBirthday.Value = new DateTime(2023, 7, 6, 0, 0, 0, 0);
            // 
            // btClose
            // 
            btClose.Image = Properties.Resources.star_alt_icon_34347;
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(49, 115);
            btClose.Name = "btClose";
            btClose.Size = new Size(95, 57);
            btClose.TabIndex = 4;
            btClose.Text = "Fermer";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            // 
            // btCalcul
            // 
            btCalcul.Image = Properties.Resources.runner_sport_run_olympics_olympic_athletics_icon_123810;
            btCalcul.ImageAlign = ContentAlignment.MiddleLeft;
            btCalcul.Location = new Point(352, 115);
            btCalcul.Name = "btCalcul";
            btCalcul.Size = new Size(95, 57);
            btCalcul.TabIndex = 5;
            btCalcul.Text = "Calculer";
            btCalcul.TextAlign = ContentAlignment.MiddleRight;
            btCalcul.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 180);
            Controls.Add(btCalcul);
            Controls.Add(btClose);
            Controls.Add(dtpBirthday);
            Controls.Add(tbName);
            Controls.Add(lbBirthday);
            Controls.Add(lbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Age";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Age";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbBirthday;
        private TextBox tbName;
        private DateTimePicker dtpBirthday;
        private Button btClose;
        private Button btCalcul;
    }
}