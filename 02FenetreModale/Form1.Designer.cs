namespace _02FenetreModale
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
            lbTitle = new Label();
            tbTitle = new TextBox();
            btFrmFille = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(254, 21);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Veuillez saisir le titre de la fenêtre 2";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(391, 9);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(403, 23);
            tbTitle.TabIndex = 1;
            // 
            // btFrmFille
            // 
            btFrmFille.Location = new Point(337, 121);
            btFrmFille.Name = "btFrmFille";
            btFrmFille.Size = new Size(140, 40);
            btFrmFille.TabIndex = 2;
            btFrmFille.Text = "Fenêtre fille";
            btFrmFille.UseVisualStyleBackColor = true;
            btFrmFille.Click += btFrmFille_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 190);
            Controls.Add(btFrmFille);
            Controls.Add(tbTitle);
            Controls.Add(lbTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fenêtre pour donner un titre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox tbTitle;
        private Button btFrmFille;
    }
}