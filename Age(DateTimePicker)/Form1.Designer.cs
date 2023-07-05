namespace Age_DateTimePicker_
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
            dtpYear = new DateTimePicker();
            btCancel = new Button();
            btYear = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(55, 21);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Nom";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(55, 59);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(101, 15);
            lbBirthday.TabIndex = 1;
            lbBirthday.Text = "Date de naissance";
            // 
            // tbName
            // 
            tbName.CharacterCasing = CharacterCasing.Upper;
            tbName.Location = new Point(222, 13);
            tbName.Name = "tbName";
            tbName.Size = new Size(253, 23);
            tbName.TabIndex = 2;
            // 
            // dtpYear
            // 
            dtpYear.Location = new Point(222, 53);
            dtpYear.MaxDate = new DateTime(2023, 7, 5, 0, 0, 0, 0);
            dtpYear.Name = "dtpYear";
            dtpYear.Size = new Size(253, 23);
            dtpYear.TabIndex = 3;
            dtpYear.Value = new DateTime(2023, 7, 5, 0, 0, 0, 0);
            // 
            // btCancel
            // 
            btCancel.Image = Properties.Resources.star_alt_icon_34347;
            btCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btCancel.Location = new Point(55, 149);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(101, 68);
            btCancel.TabIndex = 4;
            btCancel.Text = "Fermer";
            btCancel.TextAlign = ContentAlignment.MiddleRight;
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btYear
            // 
            btYear.Enabled = false;
            btYear.Image = Properties.Resources.runner_sport_run_olympics_olympic_athletics_icon_123810;
            btYear.ImageAlign = ContentAlignment.MiddleLeft;
            btYear.Location = new Point(293, 149);
            btYear.Name = "btYear";
            btYear.Size = new Size(101, 68);
            btYear.TabIndex = 5;
            btYear.Text = "Calculer";
            btYear.TextAlign = ContentAlignment.MiddleRight;
            btYear.UseVisualStyleBackColor = true;
            btYear.Click += btYear_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 241);
            Controls.Add(btYear);
            Controls.Add(btCancel);
            Controls.Add(dtpYear);
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
        private DateTimePicker dtpYear;
        private Button btCancel;
        private Button btYear;
    }
}