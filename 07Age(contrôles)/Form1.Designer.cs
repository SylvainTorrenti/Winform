namespace _07Age_contrôles_
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
            lbName.Location = new Point(52, 31);
            lbName.Name = "lbName";
            lbName.Size = new Size(34, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Nom";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(52, 115);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(101, 15);
            lbBirthday.TabIndex = 1;
            lbBirthday.Text = "Date de naissance";
            // 
            // tbName
            // 
            tbName.CharacterCasing = CharacterCasing.Upper;
            tbName.Location = new Point(238, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(182, 23);
            tbName.TabIndex = 2;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // tbBirthday
            // 
            tbBirthday.Location = new Point(238, 112);
            tbBirthday.Name = "tbBirthday";
            tbBirthday.Size = new Size(182, 23);
            tbBirthday.TabIndex = 3;
            tbBirthday.TextChanged += tbBirthday_TextChanged;
            // 
            // btClose
            // 
            btClose.Image = Properties.Resources.star_alt_icon_34347;
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(54, 265);
            btClose.Name = "btClose";
            btClose.Size = new Size(122, 56);
            btClose.TabIndex = 4;
            btClose.Text = "Fermer";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btYear
            // 
            btYear.Enabled = false;
            btYear.Image = Properties.Resources.runner_sport_run_olympics_olympic_athletics_icon_123810;
            btYear.ImageAlign = ContentAlignment.MiddleLeft;
            btYear.Location = new Point(313, 261);
            btYear.Name = "btYear";
            btYear.Size = new Size(122, 56);
            btYear.TabIndex = 5;
            btYear.Text = "Calculer";
            btYear.UseVisualStyleBackColor = true;
            btYear.Click += btYear_Click;
            // 
            // Form1
            // 
            AcceptButton = btYear;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btClose;
            ClientSize = new Size(500, 353);
            Controls.Add(btYear);
            Controls.Add(btClose);
            Controls.Add(tbBirthday);
            Controls.Add(tbName);
            Controls.Add(lbBirthday);
            Controls.Add(lbName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
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