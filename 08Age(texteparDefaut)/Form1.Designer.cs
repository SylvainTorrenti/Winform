namespace _08Age_texteparDefaut_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbName = new Label();
            lbBirthday = new Label();
            tbName = new TextBox();
            tbBirthday = new TextBox();
            btClose = new Button();
            btYear = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(68, 33);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Nom";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(68, 91);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(101, 15);
            lbBirthday.TabIndex = 1;
            lbBirthday.Text = "Date de naissance";
            // 
            // tbName
            // 
            tbName.CharacterCasing = CharacterCasing.Upper;
            tbName.Location = new Point(264, 32);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Saisir le nom";
            tbName.Size = new Size(181, 23);
            tbName.TabIndex = 2;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbBirthday
            // 
            tbBirthday.Location = new Point(264, 83);
            tbBirthday.Name = "tbBirthday";
            tbBirthday.PlaceholderText = "Saisir la date (jj/mm/aaaa)";
            tbBirthday.Size = new Size(181, 23);
            tbBirthday.TabIndex = 3;
            tbBirthday.TextChanged += tbBirthday_TextChanged;
            // 
            // btClose
            // 
            btClose.Image = Properties.Resources.star_alt_icon_34347;
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(58, 155);
            btClose.Name = "btClose";
            btClose.Size = new Size(93, 40);
            btClose.TabIndex = 4;
            btClose.Text = "Fermer";
            btClose.TextAlign = ContentAlignment.MiddleRight;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btYear
            // 
            btYear.Enabled = false;
            btYear.Image = Properties.Resources.runner_sport_run_olympics_olympic_athletics_icon_123810;
            btYear.ImageAlign = ContentAlignment.MiddleLeft;
            btYear.Location = new Point(283, 155);
            btYear.Name = "btYear";
            btYear.Size = new Size(93, 40);
            btYear.TabIndex = 5;
            btYear.Text = "Calculer";
            btYear.TextAlign = ContentAlignment.MiddleRight;
            btYear.UseVisualStyleBackColor = true;
            btYear.Click += btYear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 208);
            Controls.Add(btYear);
            Controls.Add(btClose);
            Controls.Add(tbBirthday);
            Controls.Add(tbName);
            Controls.Add(lbBirthday);
            Controls.Add(lbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Age";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbBirthday;
        private TextBox tbName;
        private TextBox tbBirthday;
        private Button btClose;
        private Button btYear;
    }
}