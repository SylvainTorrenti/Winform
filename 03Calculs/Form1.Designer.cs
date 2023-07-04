namespace _03Calculs
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
            tbNb1 = new TextBox();
            tbNb2 = new TextBox();
            lbAdition = new Label();
            SuspendLayout();
            // 
            // tbNb1
            // 
            tbNb1.Location = new Point(310, 24);
            tbNb1.Name = "tbNb1";
            tbNb1.Size = new Size(502, 23);
            tbNb1.TabIndex = 0;
            tbNb1.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNb2
            // 
            tbNb2.Location = new Point(310, 78);
            tbNb2.Name = "tbNb2";
            tbNb2.Size = new Size(502, 23);
            tbNb2.TabIndex = 1;
            tbNb2.TextAlign = HorizontalAlignment.Right;
            // 
            // lbAdition
            // 
            lbAdition.AutoSize = true;
            lbAdition.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbAdition.Location = new Point(269, 76);
            lbAdition.Name = "lbAdition";
            lbAdition.Size = new Size(25, 25);
            lbAdition.TabIndex = 2;
            lbAdition.Text = "+";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 200);
            Controls.Add(lbAdition);
            Controls.Add(tbNb2);
            Controls.Add(tbNb1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNb1;
        private TextBox tbNb2;
        private Label lbAdition;
    }
}